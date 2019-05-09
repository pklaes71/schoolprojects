namespace DraftTracker
{
    partial class draftForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newTrackerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamscomboBox = new System.Windows.Forms.ComboBox();
            this.teamlabel = new System.Windows.Forms.Label();
            this.resultstextBox = new System.Windows.Forms.TextBox();
            this.resultlabel = new System.Windows.Forms.Label();
            this.positionslistBox = new System.Windows.Forms.ListBox();
            this.positionslabel = new System.Windows.Forms.Label();
            this.pointscheckBox = new System.Windows.Forms.CheckBox();
            this.functiongroupBox = new System.Windows.Forms.GroupBox();
            this.outputbutton = new System.Windows.Forms.Button();
            this.roundbutton = new System.Windows.Forms.Button();
            this.picksbutton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.functiongroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTrackerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newTrackerToolStripMenuItem
            // 
            this.newTrackerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.newTrackerToolStripMenuItem.Name = "newTrackerToolStripMenuItem";
            this.newTrackerToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.newTrackerToolStripMenuItem.Text = "New Tracker";
            this.newTrackerToolStripMenuItem.Click += new System.EventHandler(this.newTrackerToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(132, 30);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // teamscomboBox
            // 
            this.teamscomboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.teamscomboBox.FormattingEnabled = true;
            this.teamscomboBox.Location = new System.Drawing.Point(56, 108);
            this.teamscomboBox.Name = "teamscomboBox";
            this.teamscomboBox.Size = new System.Drawing.Size(389, 37);
            this.teamscomboBox.TabIndex = 1;
            this.teamscomboBox.SelectedIndexChanged += new System.EventHandler(this.teamscomboBox_SelectedIndexChanged);
            // 
            // teamlabel
            // 
            this.teamlabel.AutoSize = true;
            this.teamlabel.ForeColor = System.Drawing.Color.Red;
            this.teamlabel.Location = new System.Drawing.Point(51, 64);
            this.teamlabel.Name = "teamlabel";
            this.teamlabel.Size = new System.Drawing.Size(88, 29);
            this.teamlabel.TabIndex = 2;
            this.teamlabel.Text = "Teams";
            // 
            // resultstextBox
            // 
            this.resultstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultstextBox.Location = new System.Drawing.Point(530, 457);
            this.resultstextBox.Multiline = true;
            this.resultstextBox.Name = "resultstextBox";
            this.resultstextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultstextBox.Size = new System.Drawing.Size(183, 555);
            this.resultstextBox.TabIndex = 3;
            // 
            // resultlabel
            // 
            this.resultlabel.AutoSize = true;
            this.resultlabel.Location = new System.Drawing.Point(534, 406);
            this.resultlabel.Name = "resultlabel";
            this.resultlabel.Size = new System.Drawing.Size(137, 29);
            this.resultlabel.TabIndex = 4;
            this.resultlabel.Text = "Draft Result";
            // 
            // positionslistBox
            // 
            this.positionslistBox.FormattingEnabled = true;
            this.positionslistBox.ItemHeight = 29;
            this.positionslistBox.Items.AddRange(new object[] {
            "QB",
            "HB",
            "FB",
            "WR",
            "TE",
            "OT",
            "OG",
            "C",
            "DE",
            "DT",
            "ILB",
            "OLB",
            "CB",
            "FS",
            "SS",
            "K",
            "P"});
            this.positionslistBox.Location = new System.Drawing.Point(56, 457);
            this.positionslistBox.Name = "positionslistBox";
            this.positionslistBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.positionslistBox.Size = new System.Drawing.Size(421, 555);
            this.positionslistBox.TabIndex = 5;
            // 
            // positionslabel
            // 
            this.positionslabel.AutoSize = true;
            this.positionslabel.Location = new System.Drawing.Point(56, 406);
            this.positionslabel.Name = "positionslabel";
            this.positionslabel.Size = new System.Drawing.Size(112, 29);
            this.positionslabel.TabIndex = 6;
            this.positionslabel.Text = "Positions";
            // 
            // pointscheckBox
            // 
            this.pointscheckBox.AutoSize = true;
            this.pointscheckBox.Location = new System.Drawing.Point(61, 229);
            this.pointscheckBox.Name = "pointscheckBox";
            this.pointscheckBox.Size = new System.Drawing.Size(190, 33);
            this.pointscheckBox.TabIndex = 7;
            this.pointscheckBox.Text = "Include Points";
            this.pointscheckBox.UseVisualStyleBackColor = true;
            this.pointscheckBox.CheckedChanged += new System.EventHandler(this.pointscheckBox_CheckedChanged);
            // 
            // functiongroupBox
            // 
            this.functiongroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.functiongroupBox.Controls.Add(this.outputbutton);
            this.functiongroupBox.Controls.Add(this.roundbutton);
            this.functiongroupBox.Controls.Add(this.picksbutton);
            this.functiongroupBox.Location = new System.Drawing.Point(467, 64);
            this.functiongroupBox.Name = "functiongroupBox";
            this.functiongroupBox.Size = new System.Drawing.Size(502, 300);
            this.functiongroupBox.TabIndex = 8;
            this.functiongroupBox.TabStop = false;
            this.functiongroupBox.Text = "Functions";
            // 
            // outputbutton
            // 
            this.outputbutton.Enabled = false;
            this.outputbutton.Location = new System.Drawing.Point(63, 187);
            this.outputbutton.Name = "outputbutton";
            this.outputbutton.Size = new System.Drawing.Size(351, 64);
            this.outputbutton.TabIndex = 2;
            this.outputbutton.Text = "Final Result";
            this.outputbutton.UseVisualStyleBackColor = true;
            this.outputbutton.Click += new System.EventHandler(this.outputbutton_Click);
            // 
            // roundbutton
            // 
            this.roundbutton.Enabled = false;
            this.roundbutton.Location = new System.Drawing.Point(63, 108);
            this.roundbutton.Name = "roundbutton";
            this.roundbutton.Size = new System.Drawing.Size(351, 63);
            this.roundbutton.TabIndex = 1;
            this.roundbutton.Text = "Next Round";
            this.roundbutton.UseVisualStyleBackColor = true;
            this.roundbutton.Click += new System.EventHandler(this.roundbutton_Click);
            // 
            // picksbutton
            // 
            this.picksbutton.Location = new System.Drawing.Point(63, 34);
            this.picksbutton.Name = "picksbutton";
            this.picksbutton.Size = new System.Drawing.Size(351, 61);
            this.picksbutton.TabIndex = 0;
            this.picksbutton.Text = "Select Picks";
            this.picksbutton.UseVisualStyleBackColor = true;
            this.picksbutton.Click += new System.EventHandler(this.picksbutton_Click);
            // 
            // draftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1012, 1099);
            this.Controls.Add(this.functiongroupBox);
            this.Controls.Add(this.pointscheckBox);
            this.Controls.Add(this.positionslabel);
            this.Controls.Add(this.positionslistBox);
            this.Controls.Add(this.resultlabel);
            this.Controls.Add(this.resultstextBox);
            this.Controls.Add(this.teamlabel);
            this.Controls.Add(this.teamscomboBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "draftForm";
            this.Text = "Draft Form";
            this.Load += new System.EventHandler(this.draftForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.functiongroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newTrackerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox teamscomboBox;
        private System.Windows.Forms.Label teamlabel;
        private System.Windows.Forms.TextBox resultstextBox;
        private System.Windows.Forms.Label resultlabel;
        private System.Windows.Forms.ListBox positionslistBox;
        private System.Windows.Forms.Label positionslabel;
        private System.Windows.Forms.CheckBox pointscheckBox;
        private System.Windows.Forms.GroupBox functiongroupBox;
        private System.Windows.Forms.Button picksbutton;
        private System.Windows.Forms.Button outputbutton;
        private System.Windows.Forms.Button roundbutton;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    }
}

