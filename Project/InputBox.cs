using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class InputBox : Form
    {
        private Func<string, bool> StringCheck;
        private string input;
        public string Input
        {
            get { return input;}
        }

        public InputBox(string title, string infLable, string checkLable, Color color, 
            Func<string, bool> StringCheck)
        {
            InitializeComponent();
            Text = title;
            lblInfo.Text = infLable;
            lblCheck.Text = checkLable;
            BackColor = color;
            this.StringCheck = StringCheck;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if(StringCheck(tbInput.Text))
            {
                input = tbInput.Text;
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            tbInput.Clear();
            Close();
        }

        private void TbInput_TextChanged(object sender, EventArgs e)
        {
            lblCheck.Visible = !StringCheck(tbInput.Text);
            btnOK.Enabled = StringCheck(tbInput.Text);
            tbInput.BackColor = StringCheck(tbInput.Text) ?
                Color.Green : Color.White;
        }
    }
}
