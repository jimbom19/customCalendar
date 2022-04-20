using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class UserControlIncludedDays : UserControl
    {
        public UserControlIncludedDays()
        {
            InitializeComponent();
        }
        public void days(int numday)
        {
            label_Days.Text = numday+"";
        }
    }
}
