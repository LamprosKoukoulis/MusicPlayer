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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new System.Windows.Forms.DataGridView();
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
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Title, Artist, Genre, Language, Year, Count });
            dataGridView1.Location = new System.Drawing.Point(203, 9);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dataGridView1.Size = new System.Drawing.Size(718, 441);
            dataGridView1.TabIndex = 1;
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
            buttonOpenFileDialog.Image = (System.Drawing.Image)resources.GetObject("buttonOpenFileDialog.Image");
            buttonOpenFileDialog.Location = new System.Drawing.Point(858, 457);
            buttonOpenFileDialog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonOpenFileDialog.Name = "buttonOpenFileDialog";
            buttonOpenFileDialog.Size = new System.Drawing.Size(59, 43);
            buttonOpenFileDialog.TabIndex = 2;
            buttonOpenFileDialog.UseVisualStyleBackColor = true;
            buttonOpenFileDialog.Click += buttonOpenFileDialog_Click;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new System.Drawing.Point(11, 457);
            axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (System.Windows.Forms.AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new System.Drawing.Size(571, 45);
            axWindowsMediaPlayer1.TabIndex = 0;
            axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange;
            axWindowsMediaPlayer1.CurrentItemChange += axWindowsMediaPlayer1_CurrentItemChange;
            axWindowsMediaPlayer1.Enter += axWindowsMediaPlayer1_Enter;
            // 
            // buttonAddToPlaylist
            // 
            buttonAddToPlaylist.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonAddToPlaylist.Image = (System.Drawing.Image)resources.GetObject("buttonAddToPlaylist.Image");
            buttonAddToPlaylist.Location = new System.Drawing.Point(791, 457);
            buttonAddToPlaylist.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonAddToPlaylist.Name = "buttonAddToPlaylist";
            buttonAddToPlaylist.Size = new System.Drawing.Size(59, 43);
            buttonAddToPlaylist.TabIndex = 3;
            buttonAddToPlaylist.UseVisualStyleBackColor = true;
            buttonAddToPlaylist.Click += buttonAddToPlaylist_Click;
            // 
            // listBoxPlaylist
            // 
            listBoxPlaylist.Anchor = System.Windows.Forms.AnchorStyles.None;
            listBoxPlaylist.FormattingEnabled = true;
            listBoxPlaylist.ItemHeight = 15;
            listBoxPlaylist.Location = new System.Drawing.Point(1, 9);
            listBoxPlaylist.Name = "listBoxPlaylist";
            listBoxPlaylist.Size = new System.Drawing.Size(195, 424);
            listBoxPlaylist.TabIndex = 4;
            listBoxPlaylist.DoubleClick += listBoxPlaylist_DoubleClick;
            // 
            // buttonShuffle
            // 
            buttonShuffle.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonShuffle.Image = (System.Drawing.Image)resources.GetObject("buttonShuffle.Image");
            buttonShuffle.Location = new System.Drawing.Point(724, 457);
            buttonShuffle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonShuffle.Name = "buttonShuffle";
            buttonShuffle.Size = new System.Drawing.Size(59, 43);
            buttonShuffle.TabIndex = 5;
            buttonShuffle.UseVisualStyleBackColor = true;
            buttonShuffle.Click += button1_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonRemove.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonRemove.Location = new System.Drawing.Point(657, 456);
            buttonRemove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new System.Drawing.Size(59, 43);
            buttonRemove.TabIndex = 6;
            buttonRemove.Text = "Remove From Playlist";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            button1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(590, 456);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(59, 43);
            button1.TabIndex = 7;
            button1.Text = "Edit Track";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(1, 436);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 15);
            label1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(929, 507);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(buttonRemove);
            Controls.Add(buttonShuffle);
            Controls.Add(listBoxPlaylist);
            Controls.Add(buttonAddToPlaylist);
            Controls.Add(buttonOpenFileDialog);
            Controls.Add(dataGridView1);
            Controls.Add(axWindowsMediaPlayer1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}

