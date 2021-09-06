using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LINQProject
{
    public class LinqExample
    {
        /// <summary>
        /// LINQ demo
        /// </summary>
        public static void Demo()
        {
            string[] names = { "Ram", "Raj", "Ravi" };
            var myLinqQuery = from name in names
                              where name.Contains('e')
                              select name;
            foreach (var name in myLinqQuery)
            {
                Console.WriteLine(name + " ");
            }
        }
        /// <summary>
        /// add the DataTable
        /// </summary>
        public static void AddDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("ProductName");

            table.Rows.Add("1", "Cooldrink");
            table.Rows.Add("2", "Tea");
            table.Rows.Add("3", "Coffee");
            DisplayProduct(table);
        }
        /// <summary>
        /// print product
        /// </summary>
        /// <param name="table"></param>
        private static void DisplayProduct(DataTable table)
        {
            var productNames = from products in table.AsEnumerable() select products.Field<string>("ProductName");
            Console.WriteLine("Product Names");
            foreach (string productName in productNames)
            {
                Console.WriteLine(productName);
            }
        }
    }
}