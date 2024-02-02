namespace FinalProject_FV1_
{
    partial class CreateTestCase
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
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scenarioTB = new System.Windows.Forms.RichTextBox();
            this.ValidationsC = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SectionC = new System.Windows.Forms.ComboBox();
            this.SuitC = new System.Windows.Forms.ComboBox();
            this.StepsC = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(612, 69);
            this.HeaderPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.scenarioTB);
            this.panel1.Controls.Add(this.ValidationsC);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.SectionC);
            this.panel1.Controls.Add(this.SuitC);
            this.panel1.Controls.Add(this.StepsC);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 631);
            this.panel1.TabIndex = 3;
            // 
            // scenarioTB
            // 
            this.scenarioTB.Location = new System.Drawing.Point(142, 40);
            this.scenarioTB.Name = "scenarioTB";
            this.scenarioTB.Size = new System.Drawing.Size(373, 96);
            this.scenarioTB.TabIndex = 3;
            this.scenarioTB.Text = "";
            // 
            // ValidationsC
            // 
            this.ValidationsC.FormattingEnabled = true;
            this.ValidationsC.Location = new System.Drawing.Point(142, 403);
            this.ValidationsC.Name = "ValidationsC";
            this.ValidationsC.Size = new System.Drawing.Size(373, 24);
            this.ValidationsC.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(142, 403);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(321, 24);
            this.comboBox2.TabIndex = 2;
            // 
            // SectionC
            // 
            this.SectionC.FormattingEnabled = true;
            this.SectionC.Location = new System.Drawing.Point(142, 236);
            this.SectionC.Name = "SectionC";
            this.SectionC.Size = new System.Drawing.Size(373, 24);
            this.SectionC.TabIndex = 2;
            // 
            // SuitC
            // 
            this.SuitC.FormattingEnabled = true;
            this.SuitC.Location = new System.Drawing.Point(142, 185);
            this.SuitC.Name = "SuitC";
            this.SuitC.Size = new System.Drawing.Size(373, 24);
            this.SuitC.TabIndex = 2;
            this.SuitC.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // StepsC
            // 
            this.StepsC.FormattingEnabled = true;
            this.StepsC.Location = new System.Drawing.Point(142, 290);
            this.StepsC.Name = "StepsC";
            this.StepsC.Size = new System.Drawing.Size(373, 24);
            this.StepsC.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Validations :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Steps :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "SectionId :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "SuitId :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateTestCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 718);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "CreateTestCase";
            this.Text = "CreateTestCase";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox scenarioTB;
        private System.Windows.Forms.ComboBox ValidationsC;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox SectionC;
        private System.Windows.Forms.ComboBox SuitC;
        private System.Windows.Forms.ComboBox StepsC;
        private System.Windows.Forms.Label label5;
    }
}