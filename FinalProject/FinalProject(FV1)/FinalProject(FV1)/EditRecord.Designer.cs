namespace FinalProject_FV1_
{
    partial class EditRecord
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
            this.OkButton = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.IsActiveCB = new System.Windows.Forms.CheckBox();
            this.IsDeletedCB = new System.Windows.Forms.CheckBox();
            this.ScenarTB = new System.Windows.Forms.TextBox();
            this.SectionC = new System.Windows.Forms.ComboBox();
            this.SuitC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IdL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(355, 390);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(101, 32);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(486, 69);
            this.HeaderPanel.TabIndex = 1;
            // 
            // IsActiveCB
            // 
            this.IsActiveCB.AutoSize = true;
            this.IsActiveCB.Location = new System.Drawing.Point(88, 264);
            this.IsActiveCB.Name = "IsActiveCB";
            this.IsActiveCB.Size = new System.Drawing.Size(79, 20);
            this.IsActiveCB.TabIndex = 3;
            this.IsActiveCB.Text = "Is Active";
            this.IsActiveCB.UseVisualStyleBackColor = true;
            // 
            // IsDeletedCB
            // 
            this.IsDeletedCB.AutoSize = true;
            this.IsDeletedCB.Location = new System.Drawing.Point(88, 300);
            this.IsDeletedCB.Name = "IsDeletedCB";
            this.IsDeletedCB.Size = new System.Drawing.Size(90, 20);
            this.IsDeletedCB.TabIndex = 3;
            this.IsDeletedCB.Text = "Is Deleted";
            this.IsDeletedCB.UseVisualStyleBackColor = true;
            // 
            // ScenarTB
            // 
            this.ScenarTB.Location = new System.Drawing.Point(88, 75);
            this.ScenarTB.Multiline = true;
            this.ScenarTB.Name = "ScenarTB";
            this.ScenarTB.Size = new System.Drawing.Size(341, 70);
            this.ScenarTB.TabIndex = 4;
            // 
            // SectionC
            // 
            this.SectionC.FormattingEnabled = true;
            this.SectionC.Location = new System.Drawing.Point(88, 202);
            this.SectionC.Name = "SectionC";
            this.SectionC.Size = new System.Drawing.Size(341, 24);
            this.SectionC.TabIndex = 5;
            // 
            // SuitC
            // 
            this.SuitC.FormattingEnabled = true;
            this.SuitC.Location = new System.Drawing.Point(88, 166);
            this.SuitC.Name = "SuitC";
            this.SuitC.Size = new System.Drawing.Size(341, 24);
            this.SuitC.TabIndex = 5;
            this.SuitC.SelectedIndexChanged += new System.EventHandler(this.SuitC_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Scenar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Section :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Suit :";
            // 
            // IdL
            // 
            this.IdL.AutoSize = true;
            this.IdL.Location = new System.Drawing.Point(88, 34);
            this.IdL.Name = "IdL";
            this.IdL.Size = new System.Drawing.Size(14, 16);
            this.IdL.TabIndex = 8;
            this.IdL.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.OkButton);
            this.panel1.Controls.Add(this.IdL);
            this.panel1.Controls.Add(this.IsActiveCB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.IsDeletedCB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ScenarTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SectionC);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SuitC);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 438);
            this.panel1.TabIndex = 9;
            // 
            // EditRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 527);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "EditRecord";
            this.Text = "EditRecord";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.CheckBox IsActiveCB;
        private System.Windows.Forms.CheckBox IsDeletedCB;
        private System.Windows.Forms.TextBox ScenarTB;
        private System.Windows.Forms.ComboBox SectionC;
        private System.Windows.Forms.ComboBox SuitC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IdL;
        private System.Windows.Forms.Panel panel1;
    }
}