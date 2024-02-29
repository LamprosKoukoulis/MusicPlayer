namespace MusicPlayerApp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Image = new System.Windows.Forms.DataGridViewImageColumn();
            Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            artistColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            buttonOpenFileDialog = new System.Windows.Forms.Button();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            buttonAddToPlaylist = new System.Windows.Forms.Button();
            listBoxPlaylist = new System.Windows.Forms.ListBox();
            buttonShuffle = new System.Windows.Forms.Button();
            buttonRemove = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(127, 121, 121);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(193, 189, 179);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(95, 91, 107);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Image, Album, artistColumn, Title, Artist, Genre, Language, Year, Count });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(193, 189, 179);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(95, 91, 107);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = System.Drawing.Color.FromArgb(193, 189, 179);
            dataGridView1.Location = new System.Drawing.Point(232, 8);
            dataGridView1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(193, 189, 179);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(95, 91, 107);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dataGridView1.Size = new System.Drawing.Size(821, 406);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // Image
            // 
            Image.HeaderText = "";
            Image.Name = "Image";
            Image.ReadOnly = true;
            Image.Width = 80;
            // 
            // Album
            // 
            Album.HeaderText = "Album";
            Album.Name = "Album";
            Album.Width = 80;
            // 
            // artistColumn
            // 
            artistColumn.HeaderText = "Column1";
            artistColumn.Name = "artistColumn";
            artistColumn.Width = 10;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.Name = "Title";
            // 
            // Artist
            // 
            Artist.HeaderText = "Artist";
            Artist.Name = "Artist";
            // 
            // Genre
            // 
            Genre.HeaderText = "Genre";
            Genre.Name = "Genre";
            // 
            // Language
            // 
            Language.HeaderText = "Language";
            Language.Name = "Language";
            // 
            // Year
            // 
            Year.HeaderText = "Year";
            Year.Name = "Year";
            Year.Width = 50;
            // 
            // Count
            // 
            Count.HeaderText = "Count";
            Count.Name = "Count";
            Count.Width = 50;
            // 
            // buttonOpenFileDialog
            // 
            buttonOpenFileDialog.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonOpenFileDialog.BackColor = System.Drawing.Color.FromArgb(193, 189, 179);
            buttonOpenFileDialog.Image = (System.Drawing.Image)resources.GetObject("buttonOpenFileDialog.Image");
            buttonOpenFileDialog.Location = new System.Drawing.Point(981, 427);
            buttonOpenFileDialog.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            buttonOpenFileDialog.Name = "buttonOpenFileDialog";
            buttonOpenFileDialog.Size = new System.Drawing.Size(67, 40);
            buttonOpenFileDialog.TabIndex = 2;
            buttonOpenFileDialog.UseVisualStyleBackColor = false;
            buttonOpenFileDialog.Click += buttonOpenFileDialog_Click;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new System.Drawing.Point(1, 424);
            axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (System.Windows.Forms.AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new System.Drawing.Size(663, 45);
            axWindowsMediaPlayer1.TabIndex = 0;
            axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange;
            axWindowsMediaPlayer1.CurrentItemChange += axWindowsMediaPlayer1_CurrentItemChange;
            axWindowsMediaPlayer1.Enter += axWindowsMediaPlayer1_Enter;
            // 
            // buttonAddToPlaylist
            // 
            buttonAddToPlaylist.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonAddToPlaylist.BackColor = System.Drawing.Color.FromArgb(193, 189, 179);
            buttonAddToPlaylist.Image = (System.Drawing.Image)resources.GetObject("buttonAddToPlaylist.Image");
            buttonAddToPlaylist.Location = new System.Drawing.Point(904, 427);
            buttonAddToPlaylist.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            buttonAddToPlaylist.Name = "buttonAddToPlaylist";
            buttonAddToPlaylist.Size = new System.Drawing.Size(67, 40);
            buttonAddToPlaylist.TabIndex = 3;
            buttonAddToPlaylist.UseVisualStyleBackColor = false;
            buttonAddToPlaylist.Click += buttonAddToPlaylist_Click;
            // 
            // listBoxPlaylist
            // 
            listBoxPlaylist.Anchor = System.Windows.Forms.AnchorStyles.None;
            listBoxPlaylist.BackColor = System.Drawing.Color.FromArgb(127, 121, 121);
            listBoxPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            listBoxPlaylist.FormattingEnabled = true;
            listBoxPlaylist.ItemHeight = 14;
            listBoxPlaylist.Location = new System.Drawing.Point(1, 8);
            listBoxPlaylist.Name = "listBoxPlaylist";
            listBoxPlaylist.Size = new System.Drawing.Size(222, 406);
            listBoxPlaylist.TabIndex = 4;
            listBoxPlaylist.DoubleClick += listBoxPlaylist_DoubleClick;
            // 
            // buttonShuffle
            // 
            buttonShuffle.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonShuffle.BackColor = System.Drawing.Color.FromArgb(193, 189, 179);
            buttonShuffle.Image = (System.Drawing.Image)resources.GetObject("buttonShuffle.Image");
            buttonShuffle.Location = new System.Drawing.Point(827, 427);
            buttonShuffle.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            buttonShuffle.Name = "buttonShuffle";
            buttonShuffle.Size = new System.Drawing.Size(67, 40);
            buttonShuffle.TabIndex = 5;
            buttonShuffle.UseVisualStyleBackColor = false;
            buttonShuffle.Click += button1_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonRemove.BackColor = System.Drawing.Color.FromArgb(193, 189, 179);
            buttonRemove.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonRemove.Location = new System.Drawing.Point(751, 426);
            buttonRemove.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new System.Drawing.Size(67, 40);
            buttonRemove.TabIndex = 6;
            buttonRemove.Text = "Remove From Playlist";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            button1.BackColor = System.Drawing.Color.FromArgb(193, 189, 179);
            button1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(674, 426);
            button1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(67, 40);
            button1.TabIndex = 7;
            button1.Text = "Edit Track";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(127, 121, 121);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(12, 400);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 14);
            label1.TabIndex = 8;
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(61, 59, 60);
            ClientSize = new System.Drawing.Size(1062, 473);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(buttonRemove);
            Controls.Add(buttonShuffle);
            Controls.Add(buttonAddToPlaylist);
            Controls.Add(buttonOpenFileDialog);
            Controls.Add(dataGridView1);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(listBoxPlaylist);
            Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            Name = "Form1";
            Text = "Music PLayer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonOpenFileDialog;
        private System.Windows.Forms.Button buttonAddToPlaylist;
        private System.Windows.Forms.ListBox listBoxPlaylist;
        private System.Windows.Forms.Button buttonShuffle;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private System.Windows.Forms.DataGridViewComboBoxColumn artistColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}

