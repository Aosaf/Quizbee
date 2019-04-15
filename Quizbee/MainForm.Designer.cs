namespace Quizbee
{
    partial class MainForm
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rdbOption1 = new System.Windows.Forms.RadioButton();
            this.rdbOption2 = new System.Windows.Forms.RadioButton();
            this.rdbOption4 = new System.Windows.Forms.RadioButton();
            this.rdbOption3 = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestion.BackColor = System.Drawing.SystemColors.Control;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(116, 90);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(967, 111);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = " ";
            // 
            // rdbOption1
            // 
            this.rdbOption1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbOption1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOption1.Location = new System.Drawing.Point(122, 204);
            this.rdbOption1.Name = "rdbOption1";
            this.rdbOption1.Size = new System.Drawing.Size(975, 36);
            this.rdbOption1.TabIndex = 1;
            this.rdbOption1.TabStop = true;
            this.rdbOption1.Text = " ";
            this.rdbOption1.UseVisualStyleBackColor = true;
            // 
            // rdbOption2
            // 
            this.rdbOption2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbOption2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOption2.Location = new System.Drawing.Point(122, 246);
            this.rdbOption2.Name = "rdbOption2";
            this.rdbOption2.Size = new System.Drawing.Size(975, 36);
            this.rdbOption2.TabIndex = 2;
            this.rdbOption2.TabStop = true;
            this.rdbOption2.Text = " ";
            this.rdbOption2.UseVisualStyleBackColor = true;
            // 
            // rdbOption4
            // 
            this.rdbOption4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbOption4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOption4.Location = new System.Drawing.Point(122, 330);
            this.rdbOption4.Name = "rdbOption4";
            this.rdbOption4.Size = new System.Drawing.Size(975, 36);
            this.rdbOption4.TabIndex = 4;
            this.rdbOption4.TabStop = true;
            this.rdbOption4.Text = " ";
            this.rdbOption4.UseVisualStyleBackColor = true;
            // 
            // rdbOption3
            // 
            this.rdbOption3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbOption3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOption3.Location = new System.Drawing.Point(122, 288);
            this.rdbOption3.Name = "rdbOption3";
            this.rdbOption3.Size = new System.Drawing.Size(975, 36);
            this.rdbOption3.TabIndex = 3;
            this.rdbOption3.TabStop = true;
            this.rdbOption3.Text = " ";
            this.rdbOption3.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(967, 387);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(116, 52);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSkip.Location = new System.Drawing.Point(845, 387);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(116, 52);
            this.btnSkip.TabIndex = 6;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(723, 387);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(116, 52);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rdbOption4);
            this.Controls.Add(this.rdbOption3);
            this.Controls.Add(this.rdbOption2);
            this.Controls.Add(this.rdbOption1);
            this.Controls.Add(this.lblQuestion);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rdbOption1;
        private System.Windows.Forms.RadioButton rdbOption2;
        private System.Windows.Forms.RadioButton rdbOption4;
        private System.Windows.Forms.RadioButton rdbOption3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnSubmit;
    }
}