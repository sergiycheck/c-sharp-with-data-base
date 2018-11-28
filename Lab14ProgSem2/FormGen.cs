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
    public partial class FormGen : Form
    {
        public FormGen()
        {
            InitializeComponent();
        }
        const int ProductCode = 1;
        Random rnd;

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            rnd = new Random(unchecked((int)DateTime.Now.Ticks));
            string serialNum = "";
            string partOf = "";
            int num;
            int digit;
            char let;
            int choice;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    digit = rnd.Next(0, 9);
                    num = rnd.Next(0, 26);
                    let = (char)('a' + num);
                    choice = rnd.Next(0, 2);
                    if (choice == 1)
                    {
                        partOf += let.ToString().ToUpper();
                    }
                    else
                    {
                        partOf += digit.ToString();
                    }
                }
                if (i != 4)
                {
                    serialNum += partOf + "-";
                }
                else
                {
                    serialNum += partOf;
                }

                partOf = "";

            }
            textBoxCode.Text = "";
            textBoxCode.Text = serialNum;
            CheckCode check = new CheckCode();
            check.InsertCode(serialNum);
            bool isPresent = check.Check(serialNum);
            MessageBox.Show(isPresent.ToString());
        }
    }

}
