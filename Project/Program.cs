using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Project
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string connString = "Host=localhost;Username=Alexandr;Password=1828bd;Database=postgres";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            PostgresDriver driver = new PostgresDriver(conn);
            Application.Run(new Entry(driver));

            //User actualUser = new User();
            //try
            //{
            //    actualUser = driver.ReadUser("vestroy@gmail.com");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //if (actualUser.Name != "None") Application.Run(new CreateUser(actualUser, driver));



        }
    }
}
