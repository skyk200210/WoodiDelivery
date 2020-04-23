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
        }

    }
}
