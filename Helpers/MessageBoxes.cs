using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeresiyeDefteri.Helpers
{
    public class MessageBoxes
    {
        public bool YesNoMessageBox(string title, string message)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            var res = MessageBox.Show(message, title, buttons);
            if (res == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        public bool InformationMessageBox(string title, string message)
        {
            var res = MessageBox.Show(message, title);
            if (res == DialogResult.OK)
            {
                return true;
            }
            return false;
        }
    }
}
