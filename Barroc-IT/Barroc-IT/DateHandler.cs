using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barroc_IT
{
    static class DateHandler
    {
        public static string GetDate(DateTimePicker dtp)
        {
            string date = dtp.Value.Year.ToString();
            int a = dtp.Value.Month;

            if (a < 10)
            {
                date += "0" + dtp.Value.Month.ToString();
            }
            else
            {
                date += dtp.Value.Month.ToString();
            }
            a = dtp.Value.Day;

            if (a < 10)
            {
                date += "0" + dtp.Value.Day.ToString();
            }
            else
            {
                date += dtp.Value.Day.ToString();
            }

            return date;
        }
    }
}
