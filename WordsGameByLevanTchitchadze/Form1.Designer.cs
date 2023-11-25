namespace WordsGameByLevanTchitchadze
{
    partial class GamePlatform
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
            this.StartGameButton = new System.Windows.Forms.Button();
            this.CharLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartGameButton
            // 
            this.StartGameButton.Location = new System.Drawing.Point(564, 615);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(88, 35);
            this.StartGameButton.TabIndex = 0;
            this.StartGameButton.Text = "Start Game";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // CharLabel
            // 
            this.CharLabel.AutoSize = true;
            this.CharLabel.Location = new System.Drawing.Point(96, 211);
            this.CharLabel.Name = "CharLabel";
            this.CharLabel.Size = new System.Drawing.Size(61, 13);
            this.CharLabel.TabIndex = 1;
            this.CharLabel.Text = "CharLabel: ";
            // 
            // GamePlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 733);
            this.Controls.Add(this.CharLabel);
            this.Controls.Add(this.StartGameButton);
            this.KeyPreview = true;
            this.Name = "GamePlatform";
            this.Text = "Words game ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GamePlatform_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GamePlatform_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Label CharLabel;
    }
}

