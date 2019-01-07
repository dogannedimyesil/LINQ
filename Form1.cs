using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form1 : Form
    {
        int[] numbers = { -9, -5, 55555, 5, 0, 100, -10 };
        List<string> names = new List<string>();
        public Form1()
        {
            InitializeComponent();
            names.Add("Doğan");
            names.Add("Anıl");
            names.Add("Nedim");
            names.Add("Yeşil");
            names.Add("Can");
            names.Add("Küçükaydın");
        }

        private void btn_AllNumbers_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = numbers.ToList();
        }

        private void btn_Negatives_Click(object sender, EventArgs e)
        {
            //lambda expression
            //=> lambda

            //Foreach ile dolaşabildiğimiz generic bir interface
            IEnumerable<int> n = numbers.Where(smt => smt < 0);
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();
        }

        private void btn_Pozitive_Click(object sender, EventArgs e)
        {
            IEnumerable<int> p= numbers.Where(numP => numP > 0);
            listBox1.DataSource = null;
            listBox1.DataSource = p.ToList();
        }

        private void btn_Even_Click(object sender, EventArgs e)
        {
            IEnumerable<int> even = numbers.Where(evenN => evenN % 2 == 0);
            listBox1.DataSource = null;
            listBox1.DataSource = even.ToList();
        }

        private void btn_Odd_Click(object sender, EventArgs e)
        {
            IEnumerable<int> odd = numbers.Where(oddN => oddN % 2 == 1 || oddN % 2 == -1);
            listBox1.DataSource = null;
            listBox1.DataSource = odd.ToList();
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {
            int maxNumber = numbers.Max();
            MessageBox.Show(maxNumber.ToString());
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            int minNumber = numbers.Min();
            MessageBox.Show(minNumber.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int qtyofNumbers = numbers.Length;
            MessageBox.Show(qtyofNumbers.ToString());
        }

        private void name_Alphabetical_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = names.OrderBy(x => x).ToList();
        }

        private void alphabetical_Reverse_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = names.OrderByDescending(x => x).ToList();
        }

        private void name_Lengths_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = names.Select(x => x.Length).ToList();
        }

        private void names_IncludesD_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = names.Select(x =>x + x.ToUpper().Contains("D")).ToList();
        }

        private void startswithA_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = names.Select(x => x + x.StartsWith("A")).ToList();
        }

        private void justDates_Click(object sender, EventArgs e)
        {
            List<Order> orders = Order.GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.Select(x => x.OrderDate).ToList();
        }

        private void btn_AllOrders_Click(object sender, EventArgs e)
        {
            List<Order> orders = Order.GetOrders();
            var gorunen = orders.Select(satir => new
            {
                SiparisNo = satir.OrderID,
                Tarih = satir.OrderDate,
                Musteri = satir.Customer.ContactName
            });
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gorunen.ToList();
        }

        private void firstFive_Click(object sender, EventArgs e)
        {
            List<Order> orders = Order.GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.Take(5).ToList();
        }

        private void lastFive_Click(object sender, EventArgs e)
        {
            List<Order> orders = Order.GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.OrderByDescending(x => x.OrderID).Take(5).Select(x => new
            {
                x.OrderID,
                x.Customer.ContactName,
                x.OrderDate
            }
            ).ToList();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            List<Order> orders = Order.GetOrders();
            var filter = orders.Where(x => x.Customer.ContactName == "Yang Wang").ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filter;
        }

        private void qtyofOrders_Click(object sender, EventArgs e)
        {
            List<Order> orders = Order.GetOrders();
            //int sayi = orders.Count();
            int sayi2 = orders.Count;
            MessageBox.Show(sayi2.ToString());
        }
    }
}
