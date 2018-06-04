using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CriadorDeUsers
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

           /*using (StreamWriter writer = new StreamWriter("C:\\Users\\raphael.santos\\Desktop\\criacaoDeUsers.txt", true))
            {
                writer.WriteLine("Testando criação de usuário");
                writer.WriteLine("Testando nova linha de usuário");
            }*/
        }
    }
}
