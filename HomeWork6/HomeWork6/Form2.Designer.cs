namespace HomeWork6
{
    partial class MainPage
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
            this.SongsDataGridView = new System.Windows.Forms.DataGridView();
            this.AddMusic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SongsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SongsDataGridView
            // 
            this.SongsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SongsDataGridView.Location = new System.Drawing.Point(12, 74);
            this.SongsDataGridView.Name = "SongsDataGridView";
            this.SongsDataGridView.RowHeadersWidth = 51;
            this.SongsDataGridView.RowTemplate.Height = 24;
            this.SongsDataGridView.Size = new System.Drawing.Size(955, 506);
            this.SongsDataGridView.TabIndex = 0;
            // 
            // AddMusic
            // 
            this.AddMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMusic.Location = new System.Drawing.Point(928, 12);
            this.AddMusic.Name = "AddMusic";
            this.AddMusic.Size = new System.Drawing.Size(39, 36);
            this.AddMusic.TabIndex = 1;
            this.AddMusic.Text = "+";
            this.AddMusic.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 592);
            this.Controls.Add(this.AddMusic);
            this.Controls.Add(this.SongsDataGridView);
            this.Name = "MainPage";
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SongsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SongsDataGridView;
        private System.Windows.Forms.Button AddMusic;
    }
}