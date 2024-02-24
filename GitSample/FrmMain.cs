using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitSample
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            int a;
            int b;

            string text1 = txtExpression1.Text;
            string text2 = txtExpression2.Text;

            a = int.Parse(text1);
            b = int.Parse(text2);

                txtResult.Text = (a + b).ToString();
            }
            catch (Exception ex)
            {
                txtResult.Text = "計算できません";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a;
                int b;

                string text1 = txtExpression1.Text;
                string text2 = txtExpression2.Text;

                a = int.Parse(text1);
                b = int.Parse(text2);

                txtResult.Text = (a - b).ToString();
            }
            catch (Exception ex)
            {
                txtResult.Text = "計算できません";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int a;
                int b;

                string text1 = txtExpression1.Text;
                string text2 = txtExpression2.Text;

                a = int.Parse(text1);
                b = int.Parse(text2);

                txtResult.Text = (a * b).ToString();
            }
            catch (Exception ex)
            {
                txtResult.Text = "計算できません";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //割り算追加分
                //コメント
                double a;
                double b;

                string text1 = txtExpression1.Text;
                string text2 = txtExpression2.Text;

                a = double.Parse(text1);
                b = double.Parse(text2);

                txtResult.Text = (a / b).ToString();
            }catch (Exception ex)
            {
                txtResult.Text = "計算できません。";
            }
        }
    }
}
