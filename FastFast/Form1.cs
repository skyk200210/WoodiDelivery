using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;       //윈폼 전체화면

            DGV_Noodle.DataSource = DataManager.Products;

            List<Product> temp = new List<Product>();
            foreach (var item in DataManager.Products)
            {
                if (item.Category == "0")
                {
                    temp.Add(item);
                }
            }
            DGV_Noodle.DataSource = temp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<Product> temp = new List<Product>();
            //foreach (var item in DataManager.Products)
            //{
            //    if (item.Category == "0")
            //    {
            //        temp.Add(item);
            //    }
            //}
            //DGV_Noodle.DataSource = temp;

            //List<Product> temp1 = new List<Product>();
            //foreach (var item in DataManager.Products)
            //{
            //    if (item.Category == "1")
            //    {
            //        temp1.Add(item);
            //    }
            //}
            //dataGridView_Rice.DataSource = temp1;

            //List<Product> temp2 = new List<Product>();
            //foreach (var item in DataManager.Products)
            //{
            //    if (item.Category == "2")
            //    {
            //        temp2.Add(item);
            //    }
            //}
            //dataGridView_Cooking.DataSource = temp2;

            //List<Product> temp3 = new List<Product>();
            //foreach (var item in DataManager.Products)
            //{
            //    if (item.Category == "3")
            //    {
            //        temp3.Add(item);
            //    }
            //}
            //dataGridView_SetMenu.DataSource = temp3;

            //List<Product> temp4 = new List<Product>();
            //foreach (var item in DataManager.Products)
            //{
            //    if (item.Category == "4")
            //    {
            //        temp4.Add(item);
            //    }
            //}
            //dataGridView_service.DataSource = temp4;

            //List<Product> temp5 = new List<Product>();
            //foreach (var item in DataManager.Products)
            //{
            //    if (item.Category == "5")
            //    {
            //        temp5.Add(item);
            //    }
            //}
            //dataGridView_Drink.DataSource = temp5;
        }


        private void button_radish_Click(object sender, EventArgs e)
        {
            Uniqueness.Text += "단무지추가 ";        //특이사항에 text 추가
        }

        private void button_onion_Click(object sender, EventArgs e)
        {
            Uniqueness.Text += "양파추가 ";
        }

        private void button_Chunjang_Click(object sender, EventArgs e)
        {
            Uniqueness.Text += "춘장추가 ";
        }

        private void button_Soy_Click(object sender, EventArgs e)
        {
            Uniqueness.Text += "간장추가 ";
        }

        private void button_chiliPowder_Click(object sender, EventArgs e)
        {
            Uniqueness.Text += "고추가루추가 ";
        }

        private void button_chopsticks_Click(object sender, EventArgs e)
        {
            Uniqueness.Text += "수저 ";
        }

        private void button_spoon_Click(object sender, EventArgs e)
        {
            Uniqueness.Text += "숟가락 ";
        }

        private void Button_Bell(object sender, EventArgs e)
        {
            Uniqueness.Text += "벨누르지마세요 ";
        }

        private void Button_TotalDelete(object sender, EventArgs e)
        {
            Uniqueness.Text = "";
        }

        private void 메뉴관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
            DataManager.Load();
            DGV_Noodle.DataSource = null;
            DGV_Noodle.DataSource = DataManager.Products;
        }

    }
}
