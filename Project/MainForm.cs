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
    public partial class MainForm : Form
    {
        IDriverDB driver;
        public User actualUser;

        public MainForm(IDriverDB driver, User actualUser)
        {
            InitializeComponent();
            this.driver = driver;
            this.actualUser = actualUser;
            //Entry entryForm = new Entry(driver, ref this.actualUser);
            MessageBox.Show(actualUser.Name);
            CreateUser createUserForm = new CreateUser(actualUser, driver);
        }
    }
}
