using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }

        public Customer Customer { get; set; } = new Customer();
        public static List<Order> GetOrders()
        {
            //Veritabanından Order tablosundaki verileri çekip bir liste olarak döndürelim
            string query = (@"SELECT o.CustomerID, o.EmployeeID, o.OrderID, o.OrderDate,
(SELECT ContactName 
 FROM Customers
WHERE CustomerID = o.CustomerID)AS ContactName
 FROM Orders O");
            List<Order> list = new List<Order>();
            DataTable dt =GetDataTable(query);
            foreach (DataRow item in dt.Rows)
            {
                Order o = new Order();
                o.OrderID = (int)item["OrderID"];
                o.CustomerID = (string)item["CustomerID"];
                o.EmployeeID = (int)item["EmployeeID"];
                o.OrderDate = (DateTime)item["OrderDate"];
                o.Customer.ContactName = item["ContactName"].ToString();
                o.Customer.CustomerID = (string)item["CustomerID"];
                list.Add(o);

            }
            return list;
        }
            public static DataTable GetDataTable(string query)
            {
                string cs = "Server=Wissen\\SQLEXPRESS; Database=Northwnd; User ID= Section1; Integrated Security=true;";
                SqlDataAdapter sda = new SqlDataAdapter(query, cs);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
        
    }
    class Customer
    {
        public string CustomerID { get; set; }
        public string ContactName { get; set; }

        public List<Order> Orders { get; set; }

        public int OrderCount
        {
            get
            {
                return Orders.Count;
            }
        }
    }
}
