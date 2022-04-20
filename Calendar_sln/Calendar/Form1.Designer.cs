
namespace Calendar
{
    partial class Form1
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
            this.daysContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.label_Monday = new System.Windows.Forms.Label();
            this.label_Tuesday = new System.Windows.Forms.Label();
            this.label_Wednesday = new System.Windows.Forms.Label();
            this.label_Saturday = new System.Windows.Forms.Label();
            this.label_Friday = new System.Windows.Forms.Label();
            this.label_Thursday = new System.Windows.Forms.Label();
            this.label_Sunday = new System.Windows.Forms.Label();
            this.lbl_displayDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // daysContainer
            // 
            this.daysContainer.BackColor = System.Drawing.Color.Gainsboro;
            this.daysContainer.Location = new System.Drawing.Point(12, 124);
            this.daysContainer.Name = "daysContainer";
            this.daysContainer.Size = new System.Drawing.Size(1448, 545);
            this.daysContainer.TabIndex = 0;
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(1304, 675);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(75, 23);
            this.btn_Prev.TabIndex = 0;
            this.btn_Prev.Text = "Previous";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(1385, 675);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 1;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // label_Monday
            // 
            this.label_Monday.AutoSize = true;
            this.label_Monday.Font = new System.Drawing.Font("Microsoft Uighur", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Monday.ForeColor = System.Drawing.Color.Black;
            this.label_Monday.Location = new System.Drawing.Point(269, 76);
            this.label_Monday.Name = "label_Monday";
            this.label_Monday.Size = new System.Drawing.Size(99, 45);
            this.label_Monday.TabIndex = 0;
            this.label_Monday.Text = "Monday";
            // 
            // label_Tuesday
            // 
            this.label_Tuesday.AutoSize = true;
            this.label_Tuesday.Font = new System.Drawing.Font("Microsoft Uighur", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tuesday.ForeColor = System.Drawing.Color.Black;
            this.label_Tuesday.Location = new System.Drawing.Point(474, 76);
            this.label_Tuesday.Name = "label_Tuesday";
            this.label_Tuesday.Size = new System.Drawing.Size(100, 45);
            this.label_Tuesday.TabIndex = 2;
            this.label_Tuesday.Text = "Tuesday";
            // 
            // label_Wednesday
            // 
            this.label_Wednesday.AutoSize = true;
            this.label_Wednesday.Font = new System.Drawing.Font("Microsoft Uighur", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Wednesday.ForeColor = System.Drawing.Color.Black;
            this.label_Wednesday.Location = new System.Drawing.Point(656, 76);
            this.label_Wednesday.Name = "label_Wednesday";
            this.label_Wednesday.Size = new System.Drawing.Size(130, 45);
            this.label_Wednesday.TabIndex = 3;
            this.label_Wednesday.Text = "Wednesday";
            // 
            // label_Saturday
            // 
            this.label_Saturday.AutoSize = true;
            this.label_Saturday.Font = new System.Drawing.Font("Microsoft Uighur", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Saturday.ForeColor = System.Drawing.Color.Black;
            this.label_Saturday.Location = new System.Drawing.Point(1289, 76);
            this.label_Saturday.Name = "label_Saturday";
            this.label_Saturday.Size = new System.Drawing.Size(104, 45);
            this.label_Saturday.TabIndex = 6;
            this.label_Saturday.Text = "Saturday";
            // 
            // label_Friday
            // 
            this.label_Friday.AutoSize = true;
            this.label_Friday.Font = new System.Drawing.Font("Microsoft Uighur", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Friday.ForeColor = System.Drawing.Color.Black;
            this.label_Friday.Location = new System.Drawing.Point(1098, 76);
            this.label_Friday.Name = "label_Friday";
            this.label_Friday.Size = new System.Drawing.Size(80, 45);
            this.label_Friday.TabIndex = 5;
            this.label_Friday.Text = "Friday";
            // 
            // label_Thursday
            // 
            this.label_Thursday.AutoSize = true;
            this.label_Thursday.Font = new System.Drawing.Font("Microsoft Uighur", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Thursday.ForeColor = System.Drawing.Color.Black;
            this.label_Thursday.Location = new System.Drawing.Point(873, 76);
            this.label_Thursday.Name = "label_Thursday";
            this.label_Thursday.Size = new System.Drawing.Size(112, 45);
            this.label_Thursday.TabIndex = 4;
            this.label_Thursday.Text = "Thursday";
            // 
            // label_Sunday
            // 
            this.label_Sunday.AutoSize = true;
            this.label_Sunday.Font = new System.Drawing.Font("Microsoft Uighur", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Sunday.ForeColor = System.Drawing.Color.Black;
            this.label_Sunday.Location = new System.Drawing.Point(59, 76);
            this.label_Sunday.Name = "label_Sunday";
            this.label_Sunday.Size = new System.Drawing.Size(91, 45);
            this.label_Sunday.TabIndex = 7;
            this.label_Sunday.Text = "Sunday";
            // 
            // lbl_displayDate
            // 
            this.lbl_displayDate.AutoSize = true;
            this.lbl_displayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_displayDate.Location = new System.Drawing.Point(610, 22);
            this.lbl_displayDate.Name = "lbl_displayDate";
            this.lbl_displayDate.Size = new System.Drawing.Size(247, 39);
            this.lbl_displayDate.TabIndex = 9;
            this.lbl_displayDate.Text = "MONTH YEAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1472, 701);
            this.Controls.Add(this.lbl_displayDate);
            this.Controls.Add(this.label_Sunday);
            this.Controls.Add(this.label_Saturday);
            this.Controls.Add(this.label_Friday);
            this.Controls.Add(this.label_Thursday);
            this.Controls.Add(this.label_Wednesday);
            this.Controls.Add(this.label_Tuesday);
            this.Controls.Add(this.label_Monday);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.daysContainer);
            this.Name = "Form1";
            this.Text = "PO RECEPTION CALENDAR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel daysContainer;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Label label_Monday;
        private System.Windows.Forms.Label label_Tuesday;
        private System.Windows.Forms.Label label_Wednesday;
        private System.Windows.Forms.Label label_Saturday;
        private System.Windows.Forms.Label label_Friday;
        private System.Windows.Forms.Label label_Thursday;
        private System.Windows.Forms.Label label_Sunday;
        private System.Windows.Forms.Label lbl_displayDate;
    }
}

