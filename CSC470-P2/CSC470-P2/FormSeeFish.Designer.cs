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
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(16, 254);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 44);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnThrowItBack
            // 
            this.btnThrowItBack.Location = new System.Drawing.Point(167, 254);
            this.btnThrowItBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThrowItBack.Name = "btnThrowItBack";
            this.btnThrowItBack.Size = new System.Drawing.Size(135, 44);
            this.btnThrowItBack.TabIndex = 1;
            this.btnThrowItBack.Text = "Throw it Back";
            this.btnThrowItBack.UseVisualStyleBackColor = true;
            this.btnThrowItBack.Click += new System.EventHandler(this.btnThrowItBack_Click);
            // 
            // btnKeepIt
            // 
            this.btnKeepIt.Location = new System.Drawing.Point(317, 254);
            this.btnKeepIt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKeepIt.Name = "btnKeepIt";
            this.btnKeepIt.Size = new System.Drawing.Size(135, 44);
            this.btnKeepIt.TabIndex = 2;
            this.btnKeepIt.Text = "Keep It";
            this.btnKeepIt.UseVisualStyleBackColor = true;
            this.btnKeepIt.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormSeeFish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(469, 343);
            this.Controls.Add(this.btnKeepIt);
            this.Controls.Add(this.btnThrowItBack);
            this.Controls.Add(this.btnCancel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSeeFish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keep it or let it go";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnThrowItBack;
        private System.Windows.Forms.Button btnKeepIt;
    }
}