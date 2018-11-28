using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab14ProgSem2
{
    public partial class FormLog : Form
    {
        public FormLog()
        {
            InitializeComponent();
        }
        bool isPresent;
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            CheckCode check = new CheckCode();
            string code = textBoxActCode.Text;
            isPresent = check.Check(code);
            MessageBox.Show(isPresent.ToString());
            textBoxActCode.Text = "";

        }
        public bool IsPRESENTCODE()
        {
            if (isPresent)
            {
                return true;
            }
            return false;
        }

    }
}
