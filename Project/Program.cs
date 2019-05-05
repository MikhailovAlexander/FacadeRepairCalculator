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
            var conn = new NpgsqlConnection(connString);
            var driver = new PostgresDriver(conn);
            var hashPasswordCreator = new HashPasswordCreator();
            try
            {
                Application.Run(new MainForm(driver, hashPasswordCreator));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
