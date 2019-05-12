namespace _2002807_Maeda_XtremeCinema12
{
    partial class Form1
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearForNextItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderCompleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorChange = new System.Windows.Forms.ColorDialog();
            this.fontChange = new System.Windows.Forms.FontDialog();
            this.boxInfo = new System.Windows.Forms.GroupBox();
            this.buttonBD = new System.Windows.Forms.RadioButton();
            this.buttonDVD = new System.Windows.Forms.RadioButton();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.checkMember = new System.Windows.Forms.CheckBox();
            this.checkNew = new System.Windows.Forms.CheckBox();
            this.menu.SuspendLayout();
            this.boxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(189, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem,
            this.eXitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.summaryToolStripMenuItem.Text = "&Summary";
            // 
            // eXitToolStripMenuItem
            // 
            this.eXitToolStripMenuItem.Name = "eXitToolStripMenuItem";
            this.eXitToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eXitToolStripMenuItem.Text = "E&xit";
            this.eXitToolStripMenuItem.Click += new System.EventHandler(this.eXitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.clearForNextItemToolStripMenuItem,
            this.orderCompleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.colorToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.calculateToolStripMenuItem.Text = "C&alculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // clearForNextItemToolStripMenuItem
            // 
            this.clearForNextItemToolStripMenuItem.Name = "clearForNextItemToolStripMenuItem";
            this.clearForNextItemToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.clearForNextItemToolStripMenuItem.Text = "Clear for &Next Item";
            this.clearForNextItemToolStripMenuItem.Click += new System.EventHandler(this.clearForNextItemToolStripMenuItem_Click);
            // 
            // orderCompleteToolStripMenuItem
            // 
            this.orderCompleteToolStripMenuItem.Name = "orderCompleteToolStripMenuItem";
            this.orderCompleteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.orderCompleteToolStripMenuItem.Text = "&Order Complete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.colorToolStripMenuItem.Text = "&Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // boxInfo
            // 
            this.boxInfo.Controls.Add(this.buttonBD);
            this.boxInfo.Controls.Add(this.buttonDVD);
            this.boxInfo.Location = new System.Drawing.Point(12, 80);
            this.boxInfo.Name = "boxInfo";
            this.boxInfo.Size = new System.Drawing.Size(166, 76);
            this.boxInfo.TabIndex = 1;
            this.boxInfo.TabStop = false;
            this.boxInfo.Text = "Movie Info";
            // 
            // buttonBD
            // 
            this.buttonBD.AutoSize = true;
            this.buttonBD.Location = new System.Drawing.Point(6, 19);
            this.buttonBD.Name = "buttonBD";
            this.buttonBD.Size = new System.Drawing.Size(62, 17);
            this.buttonBD.TabIndex = 2;
            this.buttonBD.TabStop = true;
            this.buttonBD.Text = "Blu-Ray";
            this.buttonBD.UseVisualStyleBackColor = true;
            // 
            // buttonDVD
            // 
            this.buttonDVD.AutoSize = true;
            this.buttonDVD.Location = new System.Drawing.Point(6, 43);
            this.buttonDVD.Name = "buttonDVD";
            this.buttonDVD.Size = new System.Drawing.Size(48, 17);
            this.buttonDVD.TabIndex = 3;
            this.buttonDVD.TabStop = true;
            this.buttonDVD.Text = "DVD";
            this.buttonDVD.UseVisualStyleBackColor = true;
            // 
            // titleInput
            // 
            this.titleInput.Location = new System.Drawing.Point(76, 37);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(83, 20);
            this.titleInput.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(11, 40);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(59, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Movie Title";
            // 
            // checkMember
            // 
            this.checkMember.AutoSize = true;
            this.checkMember.Location = new System.Drawing.Point(12, 162);
            this.checkMember.Name = "checkMember";
            this.checkMember.Size = new System.Drawing.Size(64, 17);
            this.checkMember.TabIndex = 2;
            this.checkMember.Text = "Member";
            this.checkMember.UseVisualStyleBackColor = true;
            // 
            // checkNew
            // 
            this.checkNew.AutoSize = true;
            this.checkNew.Location = new System.Drawing.Point(82, 162);
            this.checkNew.Name = "checkNew";
            this.checkNew.Size = new System.Drawing.Size(90, 17);
            this.checkNew.TabIndex = 3;
            this.checkNew.Text = "New Release";
            this.checkNew.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 197);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.checkNew);
            this.Controls.Add(this.checkMember);
            this.Controls.Add(this.boxInfo);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "Xtreme Cinema 12";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.boxInfo.ResumeLayout(false);
            this.boxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearForNextItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderCompleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorChange;
        private System.Windows.Forms.FontDialog fontChange;
        private System.Windows.Forms.GroupBox boxInfo;
        private System.Windows.Forms.RadioButton buttonDVD;
        private System.Windows.Forms.RadioButton buttonBD;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.CheckBox checkMember;
        private System.Windows.Forms.CheckBox checkNew;
    }
}

