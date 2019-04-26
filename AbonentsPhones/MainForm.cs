using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbonentsPhones
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (var context = new DataContext())
            {
                var cities = context.Cities.ToList();
                foreach(var item in cities)
                {
                    listCities.Items.Add(item.Name);
                    labelValue.Text = item.Kod;
                }
                listCities.SelectedIndex = 0;
                labelValue.Refresh();
            }

        }

        private void listCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new DataContext())
            {
                var cities = context.Cities.ToList();
                labelValue.Text = cities[listCities.SelectedIndex].Kod;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxNumber.Text == "")
            {
                MessageBox.Show("Введите номер телефона!");
                textBoxNumber.Focus();
            }
            else if (textBoxFio.Text == "")
            {
                MessageBox.Show("Введите ФИО абонента!");
                textBoxFio.Focus();
            }
            else
            {
                using (var context = new DataContext())
                {
                    var abonents = context.Abonents.ToList();
                    var cities = context.Cities.ToList();
                    var citiesId = cities[listCities.SelectedIndex].Id;
                    City city = cities[listCities.SelectedIndex];

                    context.Abonents.Add(new Abonent { Number = city.Kod + "-" + textBoxNumber.Text, Fio = textBoxFio.Text, City = city });
                    context.SaveChanges();

                    MessageBox.Show("Данные абонента добавлены!");

                    listCities.SelectedIndex = 0;
                    textBoxNumber.Text = "";
                    textBoxFio.Text = "";

                }
            }
        }
    }
}
