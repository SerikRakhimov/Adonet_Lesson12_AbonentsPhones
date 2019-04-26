using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbonentsPhones
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            using (var context = new DataContext())
            {
                //context.Cities.Add(new City { Name = "Бишкек", Population = 2000000 });
                //context.SaveChanges();
                //foreach (var city in context.Cities.ToList())
                //{
                //    Console.WriteLine(city.Name);
                //}
                var Abonent = context.Abonents.ToList();
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            {

            }
        }
    }
}
