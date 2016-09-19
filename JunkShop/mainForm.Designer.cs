namespace JunkShop
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelObjects = new System.Windows.Forms.Panel();
            this.numericUpDownCost = new JunkShop.NumericUpDownG();
            this.labelCost = new System.Windows.Forms.Label();
            this.comboBoxItem4 = new System.Windows.Forms.ComboBox();
            this.labelItem4 = new System.Windows.Forms.Label();
            this.numericUpDownQua1 = new System.Windows.Forms.NumericUpDown();
            this.comboBoxItem3 = new System.Windows.Forms.ComboBox();
            this.numericUpDownQua2 = new System.Windows.Forms.NumericUpDown();
            this.labelItem3 = new System.Windows.Forms.Label();
            this.numericUpDownQua3 = new System.Windows.Forms.NumericUpDown();
            this.comboBoxItem2 = new System.Windows.Forms.ComboBox();
            this.numericUpDownQua4 = new System.Windows.Forms.NumericUpDown();
            this.labelItem2 = new System.Windows.Forms.Label();
            this.labelItem1 = new System.Windows.Forms.Label();
            this.comboBoxItem1 = new System.Windows.Forms.ComboBox();
            this.labelQuantity1 = new System.Windows.Forms.Label();
            this.labelQuantity4 = new System.Windows.Forms.Label();
            this.labelQuantity2 = new System.Windows.Forms.Label();
            this.labelQuantity3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelRightAlign = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBoxWeapons = new JunkShop.ListtBoxEx();
            this.comboBoxLang = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panelObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQua1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQua2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQua3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQua4)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelObjects);
            this.panel1.Name = "panel1";
            // 
            // panelObjects
            // 
            resources.ApplyResources(this.panelObjects, "panelObjects");
            this.panelObjects.Controls.Add(this.numericUpDownCost);
            this.panelObjects.Controls.Add(this.labelCost);
            this.panelObjects.Controls.Add(this.comboBoxItem4);
            this.panelObjects.Controls.Add(this.labelItem4);
            this.panelObjects.Controls.Add(this.numericUpDownQua1);
            this.panelObjects.Controls.Add(this.comboBoxItem3);
            this.panelObjects.Controls.Add(this.numericUpDownQua2);
            this.panelObjects.Controls.Add(this.labelItem3);
            this.panelObjects.Controls.Add(this.numericUpDownQua3);
            this.panelObjects.Controls.Add(this.comboBoxItem2);
            this.panelObjects.Controls.Add(this.numericUpDownQua4);
            this.panelObjects.Controls.Add(this.labelItem2);
            this.panelObjects.Controls.Add(this.labelItem1);
            this.panelObjects.Controls.Add(this.comboBoxItem1);
            this.panelObjects.Controls.Add(this.labelQuantity1);
            this.panelObjects.Controls.Add(this.labelQuantity4);
            this.panelObjects.Controls.Add(this.labelQuantity2);
            this.panelObjects.Controls.Add(this.labelQuantity3);
            this.panelObjects.Name = "panelObjects";
            // 
            // numericUpDownCost
            // 
            resources.ApplyResources(this.numericUpDownCost, "numericUpDownCost");
            this.numericUpDownCost.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCost.Maximum = new decimal(new int[] {
            2550,
            0,
            0,
            0});
            this.numericUpDownCost.Name = "numericUpDownCost";
            this.numericUpDownCost.ReadOnly = true;
            // 
            // labelCost
            // 
            resources.ApplyResources(this.labelCost, "labelCost");
            this.labelCost.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelCost.Name = "labelCost";
            // 
            // comboBoxItem4
            // 
            resources.ApplyResources(this.comboBoxItem4, "comboBoxItem4");
            this.comboBoxItem4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItem4.FormattingEnabled = true;
            this.comboBoxItem4.Name = "comboBoxItem4";
            // 
            // labelItem4
            // 
            resources.ApplyResources(this.labelItem4, "labelItem4");
            this.labelItem4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelItem4.Name = "labelItem4";
            // 
            // numericUpDownQua1
            // 
            resources.ApplyResources(this.numericUpDownQua1, "numericUpDownQua1");
            this.numericUpDownQua1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownQua1.Name = "numericUpDownQua1";
            // 
            // comboBoxItem3
            // 
            resources.ApplyResources(this.comboBoxItem3, "comboBoxItem3");
            this.comboBoxItem3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItem3.FormattingEnabled = true;
            this.comboBoxItem3.Name = "comboBoxItem3";
            // 
            // numericUpDownQua2
            // 
            resources.ApplyResources(this.numericUpDownQua2, "numericUpDownQua2");
            this.numericUpDownQua2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownQua2.Name = "numericUpDownQua2";
            // 
            // labelItem3
            // 
            resources.ApplyResources(this.labelItem3, "labelItem3");
            this.labelItem3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelItem3.Name = "labelItem3";
            // 
            // numericUpDownQua3
            // 
            resources.ApplyResources(this.numericUpDownQua3, "numericUpDownQua3");
            this.numericUpDownQua3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownQua3.Name = "numericUpDownQua3";
            // 
            // comboBoxItem2
            // 
            resources.ApplyResources(this.comboBoxItem2, "comboBoxItem2");
            this.comboBoxItem2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItem2.FormattingEnabled = true;
            this.comboBoxItem2.Name = "comboBoxItem2";
            // 
            // numericUpDownQua4
            // 
            resources.ApplyResources(this.numericUpDownQua4, "numericUpDownQua4");
            this.numericUpDownQua4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownQua4.Name = "numericUpDownQua4";
            // 
            // labelItem2
            // 
            resources.ApplyResources(this.labelItem2, "labelItem2");
            this.labelItem2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelItem2.Name = "labelItem2";
            // 
            // labelItem1
            // 
            resources.ApplyResources(this.labelItem1, "labelItem1");
            this.labelItem1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelItem1.Name = "labelItem1";
            // 
            // comboBoxItem1
            // 
            resources.ApplyResources(this.comboBoxItem1, "comboBoxItem1");
            this.comboBoxItem1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItem1.FormattingEnabled = true;
            this.comboBoxItem1.Name = "comboBoxItem1";
            // 
            // labelQuantity1
            // 
            resources.ApplyResources(this.labelQuantity1, "labelQuantity1");
            this.labelQuantity1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelQuantity1.Name = "labelQuantity1";
            // 
            // labelQuantity4
            // 
            resources.ApplyResources(this.labelQuantity4, "labelQuantity4");
            this.labelQuantity4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelQuantity4.Name = "labelQuantity4";
            // 
            // labelQuantity2
            // 
            resources.ApplyResources(this.labelQuantity2, "labelQuantity2");
            this.labelQuantity2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelQuantity2.Name = "labelQuantity2";
            // 
            // labelQuantity3
            // 
            resources.ApplyResources(this.labelQuantity3, "labelQuantity3");
            this.labelQuantity3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelQuantity3.Name = "labelQuantity3";
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.BackColor = System.Drawing.Color.Gray;
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStatus,
            this.toolStripStatusLabelRightAlign,
            this.toolStripStatusLabelFile});
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.SizingGrip = false;
            // 
            // toolStripStatusLabelStatus
            // 
            resources.ApplyResources(this.toolStripStatusLabelStatus, "toolStripStatusLabelStatus");
            this.toolStripStatusLabelStatus.BackColor = System.Drawing.Color.Gray;
            this.toolStripStatusLabelStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabelStatus.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.toolStripStatusLabelStatus.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            // 
            // toolStripStatusLabelRightAlign
            // 
            resources.ApplyResources(this.toolStripStatusLabelRightAlign, "toolStripStatusLabelRightAlign");
            this.toolStripStatusLabelRightAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabelRightAlign.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.toolStripStatusLabelRightAlign.Name = "toolStripStatusLabelRightAlign";
            this.toolStripStatusLabelRightAlign.Spring = true;
            // 
            // toolStripStatusLabelFile
            // 
            resources.ApplyResources(this.toolStripStatusLabelFile, "toolStripStatusLabelFile");
            this.toolStripStatusLabelFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabelFile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.toolStripStatusLabelFile.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.toolStripStatusLabelFile.Name = "toolStripStatusLabelFile";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Name = "panel2";
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.AllowMerge = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.toolStripSeparator1,
            this.saveToolStripButton,
            this.toolStripSeparator2,
            this.helpToolStripButton});
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.ShowItemToolTips = false;
            // 
            // openToolStripButton
            // 
            resources.ApplyResources(this.openToolStripButton, "openToolStripButton");
            this.openToolStripButton.Margin = new System.Windows.Forms.Padding(6, 1, 0, 2);
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // saveToolStripButton
            // 
            resources.ApplyResources(this.saveToolStripButton, "saveToolStripButton");
            this.saveToolStripButton.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // helpToolStripButton
            // 
            resources.ApplyResources(this.helpToolStripButton, "helpToolStripButton");
            this.helpToolStripButton.Image = global::JunkShop.Properties.Resources.Information_icon;
            this.helpToolStripButton.Margin = new System.Windows.Forms.Padding(2, 1, 0, 2);
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.listBoxWeapons);
            this.panel3.Name = "panel3";
            // 
            // listBoxWeapons
            // 
            resources.ApplyResources(this.listBoxWeapons, "listBoxWeapons");
            this.listBoxWeapons.FormattingEnabled = true;
            this.listBoxWeapons.Name = "listBoxWeapons";
            this.listBoxWeapons.SelectedIndexChanged += new System.EventHandler(this.listBoxWeapons_SelectedIndexChanged);
            // 
            // comboBoxLang
            // 
            resources.ApplyResources(this.comboBoxLang, "comboBoxLang");
            this.comboBoxLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLang.FormattingEnabled = true;
            this.comboBoxLang.Items.AddRange(new object[] {
            resources.GetString("comboBoxLang.Items"),
            resources.GetString("comboBoxLang.Items1"),
            resources.GetString("comboBoxLang.Items2"),
            resources.GetString("comboBoxLang.Items3"),
            resources.GetString("comboBoxLang.Items4")});
            this.comboBoxLang.Name = "comboBoxLang";
            this.comboBoxLang.SelectedIndexChanged += new System.EventHandler(this.comboBoxLang_SelectedIndexChanged);
            // 
            // mainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.comboBoxLang);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panelObjects.ResumeLayout(false);
            this.panelObjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQua1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQua2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQua3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQua4)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelItem4;
        private System.Windows.Forms.NumericUpDown numericUpDownQua4;
        private System.Windows.Forms.NumericUpDown numericUpDownQua3;
        private System.Windows.Forms.NumericUpDown numericUpDownQua2;
        private System.Windows.Forms.NumericUpDown numericUpDownQua1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRightAlign;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelObjects;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ComboBox comboBoxItem4;
        private System.Windows.Forms.ComboBox comboBoxItem3;
        private System.Windows.Forms.Label labelItem3;
        private System.Windows.Forms.ComboBox comboBoxItem2;
        private System.Windows.Forms.Label labelItem2;
        private System.Windows.Forms.ComboBox comboBoxItem1;
        private System.Windows.Forms.Label labelQuantity4;
        private System.Windows.Forms.Label labelQuantity3;
        private System.Windows.Forms.Label labelQuantity2;
        private System.Windows.Forms.Label labelQuantity1;
        private System.Windows.Forms.Label labelItem1;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxLang;
        private ListtBoxEx listBoxWeapons;
        private NumericUpDownG numericUpDownCost;
    }
}

