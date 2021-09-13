
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
            this.SuspendLayout();
            // 
            // btnSeeFish
            // 
            this.btnSeeFish.Location = new System.Drawing.Point(209, 199);
            this.btnSeeFish.Name = "btnSeeFish";
            this.btnSeeFish.Size = new System.Drawing.Size(77, 23);
            this.btnSeeFish.TabIndex = 0;
            this.btnSeeFish.Text = "See Fish";
            this.btnSeeFish.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 247);
            this.Controls.Add(this.btnSeeFish);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSC470 - P2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeeFish;
    }
}

