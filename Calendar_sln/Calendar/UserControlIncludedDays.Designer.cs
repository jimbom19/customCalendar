
namespace Calendar
{
    partial class UserControlIncludedDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Days = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Days
            // 
            this.label_Days.AutoSize = true;
            this.label_Days.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Days.Location = new System.Drawing.Point(3, 0);
            this.label_Days.Name = "label_Days";
            this.label_Days.Size = new System.Drawing.Size(59, 36);
            this.label_Days.TabIndex = 0;
            this.label_Days.Text = "label1";
            // 
            // UserControlIncludedDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.label_Days);
            this.Name = "UserControlIncludedDays";
            this.Size = new System.Drawing.Size(200, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Days;
    }
}
