
namespace CSC470_P2
{
    partial class FormMain
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

        //Testing GitHub

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSeeFish = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCrappie = new System.Windows.Forms.RadioButton();
            this.radioPerch = new System.Windows.Forms.RadioButton();
            this.radioWalleye = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSeeFish
            // 
            this.btnSeeFish.Location = new System.Drawing.Point(279, 245);
            this.btnSeeFish.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeeFish.Name = "btnSeeFish";
            this.btnSeeFish.Size = new System.Drawing.Size(103, 28);
            this.btnSeeFish.TabIndex = 0;
            this.btnSeeFish.Text = "See Fish";
            this.btnSeeFish.UseVisualStyleBackColor = true;
            this.btnSeeFish.Click += new System.EventHandler(this.btnSeeFish_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioWalleye);
            this.groupBox1.Controls.Add(this.radioPerch);
            this.groupBox1.Controls.Add(this.radioCrappie);
            this.groupBox1.Location = new System.Drawing.Point(95, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 153);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose a fish to see";
            // 
            // radioCrappie
            // 
            this.radioCrappie.AutoSize = true;
            this.radioCrappie.Location = new System.Drawing.Point(47, 30);
            this.radioCrappie.Name = "radioCrappie";
            this.radioCrappie.Size = new System.Drawing.Size(78, 21);
            this.radioCrappie.TabIndex = 0;
            this.radioCrappie.TabStop = true;
            this.radioCrappie.Text = "Crappie";
            this.radioCrappie.UseVisualStyleBackColor = true;
            // 
            // radioPerch
            // 
            this.radioPerch.AutoSize = true;
            this.radioPerch.Location = new System.Drawing.Point(47, 67);
            this.radioPerch.Name = "radioPerch";
            this.radioPerch.Size = new System.Drawing.Size(66, 21);
            this.radioPerch.TabIndex = 1;
            this.radioPerch.TabStop = true;
            this.radioPerch.Text = "Perch";
            this.radioPerch.UseVisualStyleBackColor = true;
            // 
            // radioWalleye
            // 
            this.radioWalleye.AutoSize = true;
            this.radioWalleye.Location = new System.Drawing.Point(47, 107);
            this.radioWalleye.Name = "radioWalleye";
            this.radioWalleye.Size = new System.Drawing.Size(79, 21);
            this.radioWalleye.TabIndex = 2;
            this.radioWalleye.TabStop = true;
            this.radioWalleye.Text = "Walleye";
            this.radioWalleye.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 304);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSeeFish);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSC470 - P2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeeFish;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioWalleye;
        private System.Windows.Forms.RadioButton radioPerch;
        private System.Windows.Forms.RadioButton radioCrappie;
    }
}

