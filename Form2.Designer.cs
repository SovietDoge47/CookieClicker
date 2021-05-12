
namespace CookieClicker
{
    partial class Form2
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
            this.managersReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // managersReturn
            // 
            this.managersReturn.Location = new System.Drawing.Point(129, 54);
            this.managersReturn.Name = "managersReturn";
            this.managersReturn.Size = new System.Drawing.Size(75, 23);
            this.managersReturn.TabIndex = 0;
            this.managersReturn.Text = "Return";
            this.managersReturn.UseVisualStyleBackColor = true;
            this.managersReturn.Click += new System.EventHandler(this.managersReturn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.managersReturn);
            this.Name = "Form2";
            this.Text = "Managers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button managersReturn;
    }
}