namespace CST_150_Activity7
{
    partial class piCalcFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(piCalcFrm));
            this.numTermsLbl = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.numTermsTxt = new System.Windows.Forms.TextBox();
            this.answer1Lbl = new System.Windows.Forms.Label();
            this.inputTxt = new System.Windows.Forms.TextBox();
            this.answer2Lbl = new System.Windows.Forms.Label();
            this.answerTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // numTermsLbl
            // 
            this.numTermsLbl.AutoSize = true;
            this.numTermsLbl.Location = new System.Drawing.Point(13, 41);
            this.numTermsLbl.Name = "numTermsLbl";
            this.numTermsLbl.Size = new System.Drawing.Size(112, 17);
            this.numTermsLbl.TabIndex = 0;
            this.numTermsLbl.Text = "Enter # of terms: ";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.Location = new System.Drawing.Point(16, 94);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(114, 42);
            this.calculateBtn.TabIndex = 1;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // numTermsTxt
            // 
            this.numTermsTxt.Location = new System.Drawing.Point(137, 32);
            this.numTermsTxt.Name = "numTermsTxt";
            this.numTermsTxt.Size = new System.Drawing.Size(135, 25);
            this.numTermsTxt.TabIndex = 2;
            // 
            // answer1Lbl
            // 
            this.answer1Lbl.AutoSize = true;
            this.answer1Lbl.Location = new System.Drawing.Point(16, 160);
            this.answer1Lbl.Name = "answer1Lbl";
            this.answer1Lbl.Size = new System.Drawing.Size(183, 17);
            this.answer1Lbl.TabIndex = 3;
            this.answer1Lbl.Text = "Approximate value of Pi after";
            // 
            // inputTxt
            // 
            this.inputTxt.Location = new System.Drawing.Point(214, 151);
            this.inputTxt.Name = "inputTxt";
            this.inputTxt.Size = new System.Drawing.Size(76, 25);
            this.inputTxt.TabIndex = 4;
            this.inputTxt.TextChanged += new System.EventHandler(this.inputTxt_TextChanged);
            // 
            // answer2Lbl
            // 
            this.answer2Lbl.AutoSize = true;
            this.answer2Lbl.Location = new System.Drawing.Point(16, 190);
            this.answer2Lbl.Name = "answer2Lbl";
            this.answer2Lbl.Size = new System.Drawing.Size(53, 17);
            this.answer2Lbl.TabIndex = 5;
            this.answer2Lbl.Text = "terms =";
            // 
            // answerTxt
            // 
            this.answerTxt.Location = new System.Drawing.Point(78, 181);
            this.answerTxt.Name = "answerTxt";
            this.answerTxt.Size = new System.Drawing.Size(132, 25);
            this.answerTxt.TabIndex = 6;
            // 
            // piCalcFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(379, 252);
            this.Controls.Add(this.answerTxt);
            this.Controls.Add(this.answer2Lbl);
            this.Controls.Add(this.inputTxt);
            this.Controls.Add(this.answer1Lbl);
            this.Controls.Add(this.numTermsTxt);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.numTermsLbl);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "piCalcFrm";
            this.Text = "Approximate Pi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numTermsLbl;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox numTermsTxt;
        private System.Windows.Forms.Label answer1Lbl;
        private System.Windows.Forms.TextBox inputTxt;
        private System.Windows.Forms.Label answer2Lbl;
        private System.Windows.Forms.TextBox answerTxt;
    }
}

