namespace Lab5b
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorBox = new System.Windows.Forms.GroupBox();
            this.episodeLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.episodeText = new System.Windows.Forms.TextBox();
            this.ageText = new System.Windows.Forms.TextBox();
            this.yearText = new System.Windows.Forms.TextBox();
            this.actorText = new System.Windows.Forms.TextBox();
            this.seriesText = new System.Windows.Forms.TextBox();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.seriesLabel = new System.Windows.Forms.Label();
            this.playedByLabel = new System.Windows.Forms.Label();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.episodeListText = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.doctorBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(757, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileMenuItem.Text = "File";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.ShortcutKeyDisplayString = "Ctrl + O";
            this.openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openMenuItem.Text = "Open...";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.ShortcutKeyDisplayString = "Ctrl + Q";
            this.exitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // doctorBox
            // 
            this.doctorBox.Controls.Add(this.episodeLabel);
            this.doctorBox.Controls.Add(this.ageLabel);
            this.doctorBox.Controls.Add(this.episodeText);
            this.doctorBox.Controls.Add(this.ageText);
            this.doctorBox.Controls.Add(this.yearText);
            this.doctorBox.Controls.Add(this.actorText);
            this.doctorBox.Controls.Add(this.seriesText);
            this.doctorBox.Controls.Add(this.doctorComboBox);
            this.doctorBox.Controls.Add(this.seriesLabel);
            this.doctorBox.Controls.Add(this.playedByLabel);
            this.doctorBox.Controls.Add(this.doctorLabel);
            this.doctorBox.Location = new System.Drawing.Point(12, 49);
            this.doctorBox.Name = "doctorBox";
            this.doctorBox.Size = new System.Drawing.Size(288, 228);
            this.doctorBox.TabIndex = 1;
            this.doctorBox.TabStop = false;
            this.doctorBox.Text = "The Doctor";
            // 
            // episodeLabel
            // 
            this.episodeLabel.AutoSize = true;
            this.episodeLabel.Location = new System.Drawing.Point(11, 144);
            this.episodeLabel.Name = "episodeLabel";
            this.episodeLabel.Size = new System.Drawing.Size(115, 17);
            this.episodeLabel.TabIndex = 2;
            this.episodeLabel.Text = "First full episode:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(131, 101);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(87, 17);
            this.ageLabel.TabIndex = 8;
            this.ageLabel.Text = "Age at Start:";
            // 
            // episodeText
            // 
            this.episodeText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.episodeText.Enabled = false;
            this.episodeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.episodeText.Location = new System.Drawing.Point(14, 164);
            this.episodeText.Name = "episodeText";
            this.episodeText.ReadOnly = true;
            this.episodeText.Size = new System.Drawing.Size(262, 27);
            this.episodeText.TabIndex = 7;
            this.episodeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ageText
            // 
            this.ageText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ageText.Enabled = false;
            this.ageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageText.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ageText.Location = new System.Drawing.Point(224, 98);
            this.ageText.Name = "ageText";
            this.ageText.ReadOnly = true;
            this.ageText.Size = new System.Drawing.Size(33, 27);
            this.ageText.TabIndex = 6;
            // 
            // yearText
            // 
            this.yearText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.yearText.Enabled = false;
            this.yearText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearText.ForeColor = System.Drawing.SystemColors.Desktop;
            this.yearText.Location = new System.Drawing.Point(224, 35);
            this.yearText.Name = "yearText";
            this.yearText.ReadOnly = true;
            this.yearText.Size = new System.Drawing.Size(52, 27);
            this.yearText.TabIndex = 5;
            // 
            // actorText
            // 
            this.actorText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.actorText.Enabled = false;
            this.actorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actorText.ForeColor = System.Drawing.SystemColors.InfoText;
            this.actorText.Location = new System.Drawing.Point(83, 65);
            this.actorText.Name = "actorText";
            this.actorText.ReadOnly = true;
            this.actorText.Size = new System.Drawing.Size(193, 27);
            this.actorText.TabIndex = 4;
            this.actorText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // seriesText
            // 
            this.seriesText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.seriesText.Enabled = false;
            this.seriesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seriesText.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.seriesText.Location = new System.Drawing.Point(83, 98);
            this.seriesText.Name = "seriesText";
            this.seriesText.ReadOnly = true;
            this.seriesText.Size = new System.Drawing.Size(31, 27);
            this.seriesText.TabIndex = 2;
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(83, 35);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(92, 24);
            this.doctorComboBox.TabIndex = 3;
            this.doctorComboBox.SelectedIndexChanged += new System.EventHandler(this.doctorComboBox_SelectedIndexChanged);
            // 
            // seriesLabel
            // 
            this.seriesLabel.AutoSize = true;
            this.seriesLabel.Location = new System.Drawing.Point(25, 101);
            this.seriesLabel.Name = "seriesLabel";
            this.seriesLabel.Size = new System.Drawing.Size(52, 17);
            this.seriesLabel.TabIndex = 2;
            this.seriesLabel.Text = "Series:";
            // 
            // playedByLabel
            // 
            this.playedByLabel.AutoSize = true;
            this.playedByLabel.Location = new System.Drawing.Point(2, 67);
            this.playedByLabel.Name = "playedByLabel";
            this.playedByLabel.Size = new System.Drawing.Size(75, 17);
            this.playedByLabel.TabIndex = 1;
            this.playedByLabel.Text = "Played By:";
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Location = new System.Drawing.Point(27, 35);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(50, 17);
            this.doctorLabel.TabIndex = 0;
            this.doctorLabel.Text = "Doctor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.episodeListText);
            this.groupBox1.Location = new System.Drawing.Point(306, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 464);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Companions and their first episode with this Doctor:";
            // 
            // episodeListText
            // 
            this.episodeListText.BackColor = System.Drawing.SystemColors.Window;
            this.episodeListText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.episodeListText.Location = new System.Drawing.Point(6, 18);
            this.episodeListText.Multiline = true;
            this.episodeListText.Name = "episodeListText";
            this.episodeListText.ReadOnly = true;
            this.episodeListText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.episodeListText.Size = new System.Drawing.Size(427, 440);
            this.episodeListText.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab5b.Properties.Resources.phone;
            this.pictureBox1.Location = new System.Drawing.Point(17, 283);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 525);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.doctorBox);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.doctorBox.ResumeLayout(false);
            this.doctorBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.GroupBox doctorBox;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.Label seriesLabel;
        private System.Windows.Forms.Label playedByLabel;
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.Label episodeLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox episodeText;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.TextBox actorText;
        private System.Windows.Forms.TextBox seriesText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox episodeListText;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

