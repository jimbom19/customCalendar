using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calendar
{
    public partial class Form1 : Form
    {
        int month, year;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displaDays();
        }

        private void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbl_displayDate.Text = monthName + " " + year;
            //get first day of the month
            DateTime startOfTheMonth = new DateTime(year, month, 1);

            //get day count
            int days = DateTime.DaysInMonth(year, month);

            //convert startOfTheMonth to integer
            int daysOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            //create blank usercontrol (for days that are not in the current month)
            for (int i = 1; i < daysOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daysContainer.Controls.Add(ucblank);
            }

            //now create user control for days included within the month
            for (int i = 1; i <= days; i++)
            {
                UserControlIncludedDays ucidays = new UserControlIncludedDays();
                ucidays.days(i);
                daysContainer.Controls.Add(ucidays);
            }

        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            //clear container
            daysContainer.Controls.Clear();
            /*if (month == 1)
                year--;*/
            //decrement month
            month--;
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbl_displayDate.Text = monthName + " " + year;
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < daysOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daysContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlIncludedDays ucidays = new UserControlIncludedDays();
                ucidays.days(i);
                daysContainer.Controls.Add(ucidays);
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            //clear container
            daysContainer.Controls.Clear();
            /*if (month == 12)
                year++;*/
            //increment month
            month++;
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbl_displayDate.Text = monthName + " " + year;
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < daysOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daysContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlIncludedDays ucidays = new UserControlIncludedDays();
                ucidays.days(i);
                daysContainer.Controls.Add(ucidays);
            }
        }
    }
}
