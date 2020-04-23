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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Text = "메뉴 관리";

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            List<Product> temp = new List<Product>();
            foreach (var item in DataManager.Products)
            {
                if (item.Category == "0")
                {
                    temp.Add(item);
                }
            }
            dataGridView_Noodle.DataSource = temp;

            List<Product> temp1 = new List<Product>();
            foreach (var item in DataManager.Products)
            {
                if (item.Category == "1")
                {
                    temp1.Add(item);
                }
            }
            dataGridView_Rice.DataSource = temp1;

            List<Product> temp2 = new List<Product>();
            foreach (var item in DataManager.Products)
            {
                if (item.Category == "2")
                {
                    temp2.Add(item);
                }
            }
            dataGridView_Cooking.DataSource = temp2;

            List<Product> temp3 = new List<Product>();
            foreach (var item in DataManager.Products)
            {
                if (item.Category == "3")
                {
                    temp3.Add(item);
                }
            }
            dataGridView_SetMenu.DataSource = temp3;

            List<Product> temp4 = new List<Product>();
            foreach (var item in DataManager.Products)
            {
                if (item.Category == "4")
                {
                    temp4.Add(item);
                }
            }
            dataGridView_service.DataSource = temp4;

            List<Product> temp5 = new List<Product>();
            foreach (var item in DataManager.Products)
            {
                if (item.Category == "5")
                {
                    temp5.Add(item);
                }
            }
            dataGridView_Drink.DataSource = temp5;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataManager.Products.Exists((x) => x.Name == textBox_MenuName.Text))
                {
                    MessageBox.Show("중복되는 메뉴입니다.");
                }
                else
                {
                    int sel = comboBox_Select.SelectedIndex;        //combobox에서 선택된 index를 변수에 입력
                    Product product = new Product()                 //새로운 메뉴 등록
                    {
                        Name = textBox_MenuName.Text,
                        Price = int.Parse(textBox_MenuPrice.Text),
                        Category = comboBox_Select.SelectedIndex.ToString()
                    };
                    DataManager.Products.Add(product);              //Products 리스트에 추가

                    if (sel == 0)                                    //index 변수 0(면류)에 추가
                    {
                        dataGridView_Noodle.DataSource = null;

                        List<Product> temp = new List<Product>();

                        foreach (var item in DataManager.Products)  
                        {
                            if (item.Category == sel.ToString())
                            {
                                temp.Add(item);
                            }
                        }
                        dataGridView_Noodle.DataSource = temp;
                        DataManager.Save();
                    }
                    else if (sel == 1)
                    {
                        dataGridView_Rice.DataSource = null;

                        List<Product> temp = new List<Product>();

                        foreach (var item in DataManager.Products)
                        {
                            if (item.Category == sel.ToString())
                            {
                                temp.Add(item);
                            }
                        }
                        dataGridView_Rice.DataSource = temp;
                        DataManager.Save();
                    }
                    else if (sel == 2)
                    {
                        dataGridView_Cooking.DataSource = null;

                        List<Product> temp = new List<Product>();

                        foreach (var item in DataManager.Products)
                        {
                            if (item.Category == sel.ToString())
                            {
                                temp.Add(item);
                            }
                        }
                        dataGridView_Cooking.DataSource = temp;
                        DataManager.Save();
                    }
                    else if (sel == 3)
                    {
                        dataGridView_SetMenu.DataSource = null;

                        List<Product> temp = new List<Product>();

                        foreach (var item in DataManager.Products)
                        {
                            if (item.Category == sel.ToString())
                            {
                                temp.Add(item);
                            }
                        }
                        dataGridView_SetMenu.DataSource = temp;
                        DataManager.Save();
                    }
                    else if (sel == 4)
                    {
                        dataGridView_service.DataSource = null;

                        List<Product> temp = new List<Product>();

                        foreach (var item in DataManager.Products)
                        {
                            if (item.Category == sel.ToString())
                            {
                                temp.Add(item);
                            }
                        }
                        dataGridView_service.DataSource = temp;
                        DataManager.Save();
                    }
                    else
                    {
                        dataGridView_Drink.DataSource = null;

                        List<Product> temp = new List<Product>();

                        foreach (var item in DataManager.Products)
                        {
                            if (item.Category == sel.ToString())
                            {
                                temp.Add(item);
                            }
                        }
                        dataGridView_Drink.DataSource = temp;
                        DataManager.Save();
                    }
                }
            }
            catch (Exception exception)
            {

            }
        }
        private void button_Modify_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception)
            {
                MessageBox.Show("메뉴가 없습니다.");
            }
        }

        private void dataGridView_Noodle_CurrentCellChanged(object sender, EventArgs e)
        {   
            try
            {
                Product product = dataGridView_Noodle.CurrentRow.DataBoundItem as Product;
                textBox_MenuName.Text = product.Name;
                textBox_MenuPrice.Text = product.Price.ToString();
                comboBox_Select.SelectedIndex = 0;
            }
            catch (Exception exception)
            {

            }
        }

        private void dataGridView_Rice_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Product product = dataGridView_Rice.CurrentRow.DataBoundItem as Product;
                textBox_MenuName.Text = product.Name;
                textBox_MenuPrice.Text = product.Price.ToString();
                comboBox_Select.SelectedIndex = 1;
            }
            catch (Exception exception)
            {

            }
        }

        private void dataGridView_Cooking_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Product product = dataGridView_Cooking.CurrentRow.DataBoundItem as Product;
                textBox_MenuName.Text = product.Name;
                textBox_MenuPrice.Text = product.Price.ToString();
                comboBox_Select.SelectedIndex = 2;
            }
            catch (Exception exception)
            {

            }
        }

        private void dataGridView_SetMenu_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Product product = dataGridView_SetMenu.CurrentRow.DataBoundItem as Product;
                textBox_MenuName.Text = product.Name;
                textBox_MenuPrice.Text = product.Price.ToString();
                comboBox_Select.SelectedIndex = 3;
            }
            catch (Exception exception)
            {

            }
        }

        private void dataGridView_service_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Product product = dataGridView_service.CurrentRow.DataBoundItem as Product;
                textBox_MenuName.Text = product.Name;
                textBox_MenuPrice.Text = product.Price.ToString();
                comboBox_Select.SelectedIndex = 4;
            }
            catch (Exception exception)
            {

            }
        }

        private void dataGridView_Drink_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Product product = dataGridView_Drink.CurrentRow.DataBoundItem as Product;
                textBox_MenuName.Text = product.Name;
                textBox_MenuPrice.Text = product.Price.ToString();
                comboBox_Select.SelectedIndex = 5;
            }
            catch (Exception exception)
            {

            }
        }
    }
}
