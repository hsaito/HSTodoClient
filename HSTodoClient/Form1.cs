using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoTxtLib;

namespace HSTodoClient
{
    public partial class HSTodoClient : Form
    {
        private FileInfo mainFileData;
        private FileInfo archiveFileData;
        private List<TodoItem> main = new List<TodoItem>();
        private List<TodoItem> archive = new List<TodoItem>();

        public HSTodoClient()
        {
            InitializeComponent();
        }

        private void SaveTodo()
        {
            using (var file = File.Create(mainFileData.FullName))
            {
                var writer = new StreamWriter(file) {AutoFlush = true};
                foreach (var item in main)
                {
                    writer.WriteLine(TodoTxt.GenerateTodoLine(item));
                }
            }
        }

        private void taskAdd_Click(object sender, EventArgs e)
        {
            var newItem = new TodoItem();

            newItem.Body = "New task";
            newItem.Priority = '-';

            main.Add(newItem);

            itemList.Items.Clear();

            foreach (var item in main)
            {
                itemList.Items.Add(item.Body);
            }
            SaveTodo();
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainOpen_Click(object sender, EventArgs e)
        {
            var file = new OpenFileDialog();
            file.CheckFileExists = true;

            var result = file.ShowDialog(this);

            if (result != DialogResult.OK)
                return;

            main.Clear();

            using (var mainFile = File.OpenRead(file.FileName))
            {
                var reader = new StreamReader(mainFile);

                do
                {
                    main.Add(TodoTxt.Parse(reader.ReadLine()));
                } while (!reader.EndOfStream);
            }

            itemList.Items.Clear();

            foreach (var item in main)
            {
                itemList.Items.Add(item.Body);
            }

            mainFileData = new FileInfo(file.FileName);
        }

        private void itemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemList.SelectedIndices.Count != 0)
            {
                var selectedItem = main[itemList.SelectedIndex];
                updateEntry(selectedItem);
            }
            else
            {
                itemList.ClearSelected();
            }
        }

        private void updateEntry(TodoItem item)
        {
            itemEntry.Text = item.Body;
            priorityBox.Text = item.Priority.ToString();

            contextBox.Items.Clear();
            foreach (var contextItem in item.Context)
            {
                contextBox.Items.Add(contextItem);
            }

            projectBox.Items.Clear();
            foreach (var projectItem in item.Project)
            {
                projectBox.Items.Add(projectItem);
            }

            if (item.TodoMode == TodoMode.Completion)
            {
                completionCheck.Checked = true;
                createdCheck.Checked = true;

                completionDate.Value = item.Completion;
                createdDate.Value = item.Creation;
            }
            else if (item.TodoMode == TodoMode.Creation)
            {
                completionCheck.Checked = false;
                createdCheck.Checked = true;
                createdDate.Value = item.Creation;
            }
            else
            {
                completionCheck.Checked = false;
                createdCheck.Checked = false;
            }

            metaBox.Items.Clear();

            foreach (var metaitem in item.Meta)
            {
                metaBox.Items.Add(metaitem.Key + ":" + metaitem.Value);
            }
        }

        private void itemList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (itemList.CheckedIndices.Contains(itemList.SelectedIndex))
            {
                main[itemList.SelectedIndex].Completed = true;
            }
            else
            {
                main[itemList.SelectedIndex].Completed = false;
            }
            
            SaveTodo();
        }

        private void itemEntry_Leave(object sender, EventArgs e)
        {
            main[itemList.SelectedIndex].Body = itemEntry.Text;
            itemList.Items[itemList.SelectedIndex] = itemEntry.Text;
            SaveTodo();
        }

        private void priorityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            main[itemList.SelectedIndex].Priority = Convert.ToChar(priorityBox.SelectedItem.ToString());
            SaveTodo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void removeTask_Click(object sender, EventArgs e)
        {
            var index = itemList.SelectedIndex;
            itemList.ClearSelected();
            itemList.Items.RemoveAt(index);
            main.RemoveAt(index);
            SaveTodo();
        }

        private void contextAdd_Click(object sender, EventArgs e)
        {
            contextBox.Items.Add(contextEntry.Text);

            main[itemList.SelectedIndex].Context.Clear();
            foreach (var item in contextBox.Items)
            {
                main[itemList.SelectedIndex].Context.Add(item.ToString());
            }
            SaveTodo();
        }

        private void projectAdd_Click(object sender, EventArgs e)
        {
            projectBox.Items.Add(projectEntry.Text);

            main[itemList.SelectedIndex].Project.Clear();
            foreach (var item in projectBox.Items)
            {
                main[itemList.SelectedIndex].Project.Add(item.ToString());
            }
            SaveTodo();
        }

        private void contextRemove_Click(object sender, EventArgs e)
        {
            contextBox.Items.RemoveAt(contextBox.SelectedIndex);

            main[itemList.SelectedIndex].Context.Clear();
            foreach (var item in contextBox.Items)
            {
                main[itemList.SelectedIndex].Context.Add(item.ToString());
            }
            SaveTodo();
        }

        private void projectRemove_Click(object sender, EventArgs e)
        {
            projectBox.Items.RemoveAt(projectBox.SelectedIndex);

            main[itemList.SelectedIndex].Project.Clear();
            foreach (var item in projectBox.Items)
            {
                main[itemList.SelectedIndex].Project.Add(item.ToString());
            }
            SaveTodo();
        }

        private void itemEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void createdCheck_CheckedChanged(object sender, EventArgs e)
        {

            main[itemList.SelectedIndex].TodoMode = checkForMode();
            main[itemList.SelectedIndex].Completion = completionDate.Value;
            main[itemList.SelectedIndex].Creation = createdDate.Value;
            SaveTodo();
        }

        private TodoMode checkForMode()
        {
            if (createdCheck.Checked && completionCheck.Checked)
            {
                return TodoMode.Completion;
            }
            else if (createdCheck.Checked && !completionCheck.Checked)
            {
                return TodoMode.Creation;
            }
            else if (!createdCheck.Checked && !completionCheck.Checked)
            {
                return TodoMode.None;
            }
            else if (completionCheck.Checked && !createdCheck.Checked)
            {
                createdCheck.Checked = true;
                return TodoMode.Completion;
            }

            return TodoMode.None;
        }

        private void completionCheck_CheckedChanged(object sender, EventArgs e)
        {
            main[itemList.SelectedIndex].TodoMode = checkForMode();
            main[itemList.SelectedIndex].Completion = completionDate.Value;
            main[itemList.SelectedIndex].Creation = createdDate.Value;
            SaveTodo();
        }

        private void createdDate_ValueChanged(object sender, EventArgs e)
        {
            main[itemList.SelectedIndex].TodoMode = checkForMode();
            main[itemList.SelectedIndex].Completion = completionDate.Value;
            main[itemList.SelectedIndex].Creation = createdDate.Value;
            SaveTodo();
        }

        private void completionDate_ValueChanged(object sender, EventArgs e)
        {
            main[itemList.SelectedIndex].TodoMode = checkForMode();
            main[itemList.SelectedIndex].Completion = completionDate.Value;
            main[itemList.SelectedIndex].Creation = createdDate.Value;
            SaveTodo();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void metaAdd_Click(object sender, EventArgs e)
        {
            if (metaKey.Text != "" && metaValue.Text != "")
            {
                if (metaKey.Text.Contains(" ") || metaValue.Text.Contains(" "))
                {
                    return;
                }
                main[itemList.SelectedIndex].Meta.Add(metaKey.Text, metaValue.Text);
                metaBox.Items.Add(metaKey.Text + ":" + metaValue.Text);
                SaveTodo();
            }
        }
    }
}
