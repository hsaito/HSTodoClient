namespace HSTodoClient
{
    partial class HSTodoClient
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.priorityBox = new System.Windows.Forms.ComboBox();
            this.itemList = new System.Windows.Forms.CheckedListBox();
            this.contextEntry = new System.Windows.Forms.TextBox();
            this.createdDate = new System.Windows.Forms.DateTimePicker();
            this.completionCheck = new System.Windows.Forms.CheckBox();
            this.createdCheck = new System.Windows.Forms.CheckBox();
            this.completionDate = new System.Windows.Forms.DateTimePicker();
            this.metaBox = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.contextGroup = new System.Windows.Forms.GroupBox();
            this.contextRemove = new System.Windows.Forms.Button();
            this.contextBox = new System.Windows.Forms.ListBox();
            this.contextAdd = new System.Windows.Forms.Button();
            this.projectGroup = new System.Windows.Forms.GroupBox();
            this.projectRemove = new System.Windows.Forms.Button();
            this.projectBox = new System.Windows.Forms.ListBox();
            this.projectAdd = new System.Windows.Forms.Button();
            this.projectEntry = new System.Windows.Forms.TextBox();
            this.metaKey = new System.Windows.Forms.TextBox();
            this.metaValue = new System.Windows.Forms.TextBox();
            this.metaAdd = new System.Windows.Forms.Button();
            this.removeMeta = new System.Windows.Forms.Button();
            this.taskAdd = new System.Windows.Forms.Button();
            this.removeTask = new System.Windows.Forms.Button();
            this.itemLabel = new System.Windows.Forms.Label();
            this.itemEntry = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextGroup.SuspendLayout();
            this.projectGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(508, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.mainOpen_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(152, 22);
            this.exitMenu.Text = "E&xit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(12, 205);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(38, 13);
            this.priorityLabel.TabIndex = 2;
            this.priorityLabel.Text = "Priority";
            // 
            // priorityBox
            // 
            this.priorityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Items.AddRange(new object[] {
            "-",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.priorityBox.Location = new System.Drawing.Point(56, 202);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(440, 21);
            this.priorityBox.TabIndex = 3;
            this.priorityBox.SelectedIndexChanged += new System.EventHandler(this.priorityBox_SelectedIndexChanged);
            // 
            // itemList
            // 
            this.itemList.FormattingEnabled = true;
            this.itemList.Location = new System.Drawing.Point(12, 27);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(484, 139);
            this.itemList.TabIndex = 4;
            this.itemList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.itemList_ItemCheck);
            this.itemList.SelectedIndexChanged += new System.EventHandler(this.itemList_SelectedIndexChanged);
            // 
            // contextEntry
            // 
            this.contextEntry.Location = new System.Drawing.Point(6, 19);
            this.contextEntry.Name = "contextEntry";
            this.contextEntry.Size = new System.Drawing.Size(129, 20);
            this.contextEntry.TabIndex = 6;
            // 
            // createdDate
            // 
            this.createdDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.createdDate.Location = new System.Drawing.Point(90, 335);
            this.createdDate.Name = "createdDate";
            this.createdDate.Size = new System.Drawing.Size(406, 20);
            this.createdDate.TabIndex = 7;
            this.createdDate.ValueChanged += new System.EventHandler(this.createdDate_ValueChanged);
            // 
            // completionCheck
            // 
            this.completionCheck.AutoSize = true;
            this.completionCheck.Location = new System.Drawing.Point(12, 361);
            this.completionCheck.Name = "completionCheck";
            this.completionCheck.Size = new System.Drawing.Size(78, 17);
            this.completionCheck.TabIndex = 8;
            this.completionCheck.Text = "Completion";
            this.completionCheck.UseVisualStyleBackColor = true;
            this.completionCheck.CheckedChanged += new System.EventHandler(this.completionCheck_CheckedChanged);
            // 
            // createdCheck
            // 
            this.createdCheck.AutoSize = true;
            this.createdCheck.Location = new System.Drawing.Point(12, 338);
            this.createdCheck.Name = "createdCheck";
            this.createdCheck.Size = new System.Drawing.Size(63, 17);
            this.createdCheck.TabIndex = 9;
            this.createdCheck.Text = "Created";
            this.createdCheck.UseVisualStyleBackColor = true;
            this.createdCheck.CheckedChanged += new System.EventHandler(this.createdCheck_CheckedChanged);
            // 
            // completionDate
            // 
            this.completionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.completionDate.Location = new System.Drawing.Point(90, 361);
            this.completionDate.Name = "completionDate";
            this.completionDate.Size = new System.Drawing.Size(406, 20);
            this.completionDate.TabIndex = 10;
            this.completionDate.ValueChanged += new System.EventHandler(this.completionDate_ValueChanged);
            // 
            // metaBox
            // 
            this.metaBox.FormattingEnabled = true;
            this.metaBox.Location = new System.Drawing.Point(12, 413);
            this.metaBox.Name = "metaBox";
            this.metaBox.Size = new System.Drawing.Size(481, 69);
            this.metaBox.TabIndex = 11;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 232);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.contextGroup);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.projectGroup);
            this.splitContainer1.Size = new System.Drawing.Size(484, 100);
            this.splitContainer1.SplitterDistance = 238;
            this.splitContainer1.TabIndex = 15;
            // 
            // contextGroup
            // 
            this.contextGroup.Controls.Add(this.contextRemove);
            this.contextGroup.Controls.Add(this.contextBox);
            this.contextGroup.Controls.Add(this.contextAdd);
            this.contextGroup.Controls.Add(this.contextEntry);
            this.contextGroup.Location = new System.Drawing.Point(3, 3);
            this.contextGroup.Name = "contextGroup";
            this.contextGroup.Size = new System.Drawing.Size(232, 94);
            this.contextGroup.TabIndex = 0;
            this.contextGroup.TabStop = false;
            this.contextGroup.Text = "Context";
            // 
            // contextRemove
            // 
            this.contextRemove.Location = new System.Drawing.Point(184, 19);
            this.contextRemove.Name = "contextRemove";
            this.contextRemove.Size = new System.Drawing.Size(42, 23);
            this.contextRemove.TabIndex = 9;
            this.contextRemove.Text = "R";
            this.contextRemove.UseVisualStyleBackColor = true;
            this.contextRemove.Click += new System.EventHandler(this.contextRemove_Click);
            // 
            // contextBox
            // 
            this.contextBox.FormattingEnabled = true;
            this.contextBox.Location = new System.Drawing.Point(6, 48);
            this.contextBox.Name = "contextBox";
            this.contextBox.Size = new System.Drawing.Size(220, 43);
            this.contextBox.TabIndex = 8;
            // 
            // contextAdd
            // 
            this.contextAdd.Location = new System.Drawing.Point(140, 19);
            this.contextAdd.Name = "contextAdd";
            this.contextAdd.Size = new System.Drawing.Size(42, 23);
            this.contextAdd.TabIndex = 7;
            this.contextAdd.Text = "A";
            this.contextAdd.UseVisualStyleBackColor = true;
            this.contextAdd.Click += new System.EventHandler(this.contextAdd_Click);
            // 
            // projectGroup
            // 
            this.projectGroup.Controls.Add(this.projectRemove);
            this.projectGroup.Controls.Add(this.projectBox);
            this.projectGroup.Controls.Add(this.projectAdd);
            this.projectGroup.Controls.Add(this.projectEntry);
            this.projectGroup.Location = new System.Drawing.Point(3, 3);
            this.projectGroup.Name = "projectGroup";
            this.projectGroup.Size = new System.Drawing.Size(236, 94);
            this.projectGroup.TabIndex = 0;
            this.projectGroup.TabStop = false;
            this.projectGroup.Text = "Project";
            // 
            // projectRemove
            // 
            this.projectRemove.Location = new System.Drawing.Point(188, 19);
            this.projectRemove.Name = "projectRemove";
            this.projectRemove.Size = new System.Drawing.Size(42, 23);
            this.projectRemove.TabIndex = 10;
            this.projectRemove.Text = "R";
            this.projectRemove.UseVisualStyleBackColor = true;
            this.projectRemove.Click += new System.EventHandler(this.projectRemove_Click);
            // 
            // projectBox
            // 
            this.projectBox.FormattingEnabled = true;
            this.projectBox.Location = new System.Drawing.Point(6, 48);
            this.projectBox.Name = "projectBox";
            this.projectBox.Size = new System.Drawing.Size(224, 43);
            this.projectBox.TabIndex = 9;
            // 
            // projectAdd
            // 
            this.projectAdd.Location = new System.Drawing.Point(141, 19);
            this.projectAdd.Name = "projectAdd";
            this.projectAdd.Size = new System.Drawing.Size(42, 23);
            this.projectAdd.TabIndex = 8;
            this.projectAdd.Text = "A";
            this.projectAdd.UseVisualStyleBackColor = true;
            this.projectAdd.Click += new System.EventHandler(this.projectAdd_Click);
            // 
            // projectEntry
            // 
            this.projectEntry.Location = new System.Drawing.Point(6, 19);
            this.projectEntry.Name = "projectEntry";
            this.projectEntry.Size = new System.Drawing.Size(129, 20);
            this.projectEntry.TabIndex = 8;
            // 
            // metaKey
            // 
            this.metaKey.Location = new System.Drawing.Point(12, 387);
            this.metaKey.Name = "metaKey";
            this.metaKey.Size = new System.Drawing.Size(202, 20);
            this.metaKey.TabIndex = 16;
            // 
            // metaValue
            // 
            this.metaValue.Location = new System.Drawing.Point(220, 387);
            this.metaValue.Name = "metaValue";
            this.metaValue.Size = new System.Drawing.Size(202, 20);
            this.metaValue.TabIndex = 17;
            // 
            // metaAdd
            // 
            this.metaAdd.Location = new System.Drawing.Point(428, 387);
            this.metaAdd.Name = "metaAdd";
            this.metaAdd.Size = new System.Drawing.Size(32, 23);
            this.metaAdd.TabIndex = 18;
            this.metaAdd.Text = "A";
            this.metaAdd.UseVisualStyleBackColor = true;
            this.metaAdd.Click += new System.EventHandler(this.metaAdd_Click);
            // 
            // removeMeta
            // 
            this.removeMeta.Location = new System.Drawing.Point(461, 387);
            this.removeMeta.Name = "removeMeta";
            this.removeMeta.Size = new System.Drawing.Size(32, 23);
            this.removeMeta.TabIndex = 19;
            this.removeMeta.Text = "R";
            this.removeMeta.UseVisualStyleBackColor = true;
            // 
            // taskAdd
            // 
            this.taskAdd.Location = new System.Drawing.Point(12, 488);
            this.taskAdd.Name = "taskAdd";
            this.taskAdd.Size = new System.Drawing.Size(235, 49);
            this.taskAdd.TabIndex = 20;
            this.taskAdd.Text = "Add";
            this.taskAdd.UseVisualStyleBackColor = true;
            this.taskAdd.Click += new System.EventHandler(this.taskAdd_Click);
            // 
            // removeTask
            // 
            this.removeTask.Location = new System.Drawing.Point(257, 488);
            this.removeTask.Name = "removeTask";
            this.removeTask.Size = new System.Drawing.Size(236, 49);
            this.removeTask.TabIndex = 21;
            this.removeTask.Text = "Remove";
            this.removeTask.UseVisualStyleBackColor = true;
            this.removeTask.Click += new System.EventHandler(this.removeTask_Click);
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(12, 178);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(27, 13);
            this.itemLabel.TabIndex = 22;
            this.itemLabel.Text = "Item";
            // 
            // itemEntry
            // 
            this.itemEntry.Location = new System.Drawing.Point(56, 175);
            this.itemEntry.Name = "itemEntry";
            this.itemEntry.Size = new System.Drawing.Size(440, 20);
            this.itemEntry.TabIndex = 23;
            this.itemEntry.TextChanged += new System.EventHandler(this.itemEntry_TextChanged);
            this.itemEntry.Leave += new System.EventHandler(this.itemEntry_Leave);
            // 
            // HSTodoClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 547);
            this.Controls.Add(this.itemEntry);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.removeTask);
            this.Controls.Add(this.taskAdd);
            this.Controls.Add(this.removeMeta);
            this.Controls.Add(this.metaAdd);
            this.Controls.Add(this.metaValue);
            this.Controls.Add(this.metaKey);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.metaBox);
            this.Controls.Add(this.completionDate);
            this.Controls.Add(this.createdCheck);
            this.Controls.Add(this.completionCheck);
            this.Controls.Add(this.createdDate);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "HSTodoClient";
            this.Text = "HS Todo Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextGroup.ResumeLayout(false);
            this.contextGroup.PerformLayout();
            this.projectGroup.ResumeLayout(false);
            this.projectGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.ComboBox priorityBox;
        private System.Windows.Forms.CheckedListBox itemList;
        private System.Windows.Forms.TextBox contextEntry;
        private System.Windows.Forms.DateTimePicker createdDate;
        private System.Windows.Forms.CheckBox completionCheck;
        private System.Windows.Forms.CheckBox createdCheck;
        private System.Windows.Forms.DateTimePicker completionDate;
        private System.Windows.Forms.ListBox metaBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox contextGroup;
        private System.Windows.Forms.ListBox contextBox;
        private System.Windows.Forms.Button contextAdd;
        private System.Windows.Forms.GroupBox projectGroup;
        private System.Windows.Forms.ListBox projectBox;
        private System.Windows.Forms.Button projectAdd;
        private System.Windows.Forms.TextBox projectEntry;
        private System.Windows.Forms.Button projectRemove;
        private System.Windows.Forms.TextBox metaKey;
        private System.Windows.Forms.TextBox metaValue;
        private System.Windows.Forms.Button metaAdd;
        private System.Windows.Forms.Button contextRemove;
        private System.Windows.Forms.Button removeMeta;
        private System.Windows.Forms.Button taskAdd;
        private System.Windows.Forms.Button removeTask;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.TextBox itemEntry;
    }
}

