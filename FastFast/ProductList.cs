using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFast
{
    class ProductList
    {
        public static void Product_List() {
            try
            {
                Form1 form1 = new Form1();

                List<Product> temp = new List<Product>();
                foreach (var item in DataManager.Products)
                {
                    if (item.Category == "0")
                    {
                        temp.Add(item);
                    }
                }
                form1.DGV_Noodle.DataSource = temp;

                List<Product> temp1 = new List<Product>();
                foreach (var item in DataManager.Products)
                {
                    if (item.Category == "1")
                    {
                        temp1.Add(item);
                    }
                }
                form1.DGV_Rice.DataSource = temp1;

                List<Product> temp2 = new List<Product>();
                foreach (var item in DataManager.Products)
                {
                    if (item.Category == "2")
                    {
                        temp2.Add(item);
                    }
                }
                form1.DGV_Cooking.DataSource = temp2;

                List<Product> temp3 = new List<Product>();
                foreach (var item in DataManager.Products)
                {
                    if (item.Category == "3")
                    {
                        temp3.Add(item);
                    }
                }
                form1.DGV_SetMenu.DataSource = temp3;

                List<Product> temp4 = new List<Product>();
                foreach (var item in DataManager.Products)
                {
                    if (item.Category == "4")
                    {
                        temp4.Add(item);
                    }
                }
                form1.DGV_Service.DataSource = temp4;

                List<Product> temp5 = new List<Product>();
                foreach (var item in DataManager.Products)
                {
                    if (item.Category == "5")
                    {
                        temp5.Add(item);
                    }
                }
                form1.DGV_Drink.DataSource = temp5;
            }
            catch(Exception)
            {

            }
        }
    }
}
