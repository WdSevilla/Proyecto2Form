using Proyecto2Form.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2Form
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool loggedIn = false;
            int attempts = 0;
            while (!loggedIn && attempts < 3)
            {
                using (Login loginForm = new Login())
                {
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        loggedIn = true;
                    }
                    else
                    {
                        attempts++;
                        if (attempts >= 3)
                        {
                            MessageBox.Show("Demasiados intentos fallidos. La aplicación se cerrará.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }

            if (loggedIn)
            {
                Application.Run(new Form1());
            }
        }
    }
}