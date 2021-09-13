namespace CSC470_P2
{
    partial class FormSeeFish
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnThrowItBack = new System.Windows.Forms.Button();
            this.btnKeepIt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 301);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 36);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnThrowItBack
            // 
            this.btnThrowItBack.Location = new System.Drawing.Point(168, 301);
            this.btnThrowItBack.Name = "btnThrowItBack";
            this.btnThrowItBack.Size = new System.Drawing.Size(101, 36);
            this.btnThrowItBack.TabIndex = 1;
            this.btnThrowItBack.Text = "Throw it Back";
            this.btnThrowItBack.UseVisualStyleBackColor = true;
            this.btnThrowItBack.Click += new System.EventHandler(this.btnThrowItBack_Click);
            // 
            // btnKeepIt
            // 
            this.btnKeepIt.Location = new System.Drawing.Point(321, 301);
            this.btnKeepIt.Name = "btnKeepIt";
            this.btnKeepIt.Size = new System.Drawing.Size(101, 36);
            this.btnKeepIt.TabIndex = 2;
            this.btnKeepIt.Text = "Keep It";
            this.btnKeepIt.UseVisualStyleBackColor = true;
            this.btnKeepIt.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CSC470_P2.Properties.Resources.Crappie;
            this.pictureBox1.Location = new System.Drawing.Point(38, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormSeeFish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKeepIt);
            this.Controls.Add(this.btnThrowItBack);
            this.Controls.Add(this.btnCancel);
            this.Name = "FormSeeFish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keep it or let it go";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnThrowItBack;
        private System.Windows.Forms.Button btnKeepIt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}