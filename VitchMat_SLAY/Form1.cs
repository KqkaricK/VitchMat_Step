using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Forms;
                                                                             // для теста:
namespace VitchMat_SLAY                                                      // 5  -1  3
{                                                                            // 2   3  25
    public partial class Form1 : DarkForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Razmer()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = Convert.ToInt32(t_raz.Text);
            dataGridView1.ColumnCount = Convert.ToInt32(t_raz.Text);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = 0;
                }
            }
            Cleaner();
        }
        double Norm(DataGridView A)
        {
            double tmp = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                tmp += Convert.ToDouble(A.Rows[i].Cells[0].Value.ToString()) * Convert.ToDouble(A.Rows[i].Cells[0].Value.ToString());
            }
            return Math.Sqrt(tmp);
        }
        void Cleaner()
        {
            Xmax.Rows.Clear();
            Y0.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView2.RowCount = dataGridView1.RowCount;
            dataGridView2.ColumnCount = dataGridView1.RowCount;
            dataGridView3.RowCount = dataGridView1.RowCount;
            Xmax.RowCount = dataGridView1.RowCount;
            Xmin.RowCount = dataGridView1.RowCount;
            Y0.RowCount = dataGridView1.RowCount;
            Y0.Rows[0].Cells[0].Value = 1;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (i != 0)
                {
                    Y0.Rows[i].Cells[0].Value = 0;
                }
                dataGridView3.Rows[i].Cells[0].Value = 0;
                Xmax.Rows[i].Cells[0].Value = 0;
                Xmin.Rows[i].Cells[0].Value = 0;
            }
        }
        private void darkButton1_Click(object sender, EventArgs e)
        {
            if (Chek() == false)
            {
                MessageBox.Show("Размерность должна быть больше 1 и меньше 11");
            }
            else
            {
                Razmer();
                darkButton2.Enabled = true;
                Lmax.Text = "0";
                Lmin.Text = "0";
                l_k.Text = "0";
            }
        }

        /*Ниже куча проверок*/

        bool FirstZero()
        {
            if (Convert.ToInt32(Y0.Rows[0].Cells[0].Value.ToString()) != 0)
            {
                return false;
            }
            else
            {
                MessageBox.Show("Ошибка! Первый элемент в Y0 не должен быть равен 0");
                return true;
            }
        }
        bool IsNumber()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    double d;
                    if (Double.TryParse(dataGridView1.Rows[i].Cells[j].Value.ToString(), out d) == false)
                    {
                        MessageBox.Show("Ошибка! Коэффициенты должны быть числами");
                        return false;
                    }
                }
            }
            return true;
        }
        bool Chek()
        {
            if (t_raz.Text == "")
            {
                return false;
            }
            else if (Convert.ToInt32(t_raz.Text) < 2 || Convert.ToInt32(t_raz.Text) > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void t_raz_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && e.KeyChar != '-' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);
        }
        private void t_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }
        bool ChekEpsilon(double E, double tmp, string s) //gthtgbcfnm
        {
            if (Math.Abs(tmp - Convert.ToDouble(s)) < E)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*Куча проверок закончена*/

        private void darkButton2_Click_1(object sender, EventArgs e)
        {
            int k = 1;
            double lambda = 1;
            if (IsNumber() == true && FirstZero() == false)
            {
                if (t_e.Text == "")
                {
                    MessageBox.Show("Ошибка ввода E");
                }
                else
                {
                    double E = Convert.ToDouble("0," + t_e.Text);
                    for (int i = 0; i < dataGridView1.RowCount; i++) //1 ed vector
                    {
                        Xmax.Rows[i].Cells[0].Value = Convert.ToDouble(Y0.Rows[i].Cells[0].Value.ToString()) / Norm(Y0);
                    }
                    while(ChekEpsilon(E, lambda, Lmax.Text) == false)
                    {
                        Lmax.Text = lambda.ToString();
                        for (int i = 0; i < dataGridView1.RowCount; i++) //y
                        {
                            Xmin.Rows[i].Cells[0].Value = 0;
                            for (int j = 0; j < dataGridView1.RowCount; j++)
                            {
                                Xmin.Rows[i].Cells[0].Value = Convert.ToDouble(Xmin.Rows[i].Cells[0].Value.ToString()) + Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value.ToString()) * Convert.ToDouble(Xmax.Rows[j].Cells[0].Value.ToString());
                            }
                        }
                        for (int i = 0; i < dataGridView1.RowCount; i++) //x
                        {
                            Xmax.Rows[i].Cells[0].Value = Convert.ToDouble(Xmin.Rows[i].Cells[0].Value.ToString()) / Norm(Xmin);
                        }
                        lambda = Convert.ToDouble(Xmin.Rows[0].Cells[0].Value.ToString()) / Convert.ToDouble(Xmax.Rows[0].Cells[0].Value.ToString());
                        k++;
                    }
                    Xmin.Rows.Clear();
                    Xmin.RowCount = dataGridView1.RowCount;
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {
                            if (i == j)
                            {
                                dataGridView2.Rows[i].Cells[j].Value = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value.ToString()) - lambda;
                            }
                            else
                            {
                                dataGridView2.Rows[i].Cells[j].Value = dataGridView1.Rows[i].Cells[j].Value;
                            }
                        }
                    }
                    Lmax.Text = lambda.ToString();
                    l_k.Text = k.ToString();
                    lambda = 1;
                    for (int i = 0; i < dataGridView1.RowCount; i++) //1 ed vector
                    {
                        Xmin.Rows[i].Cells[0].Value = Convert.ToDouble(Y0.Rows[i].Cells[0].Value.ToString()) / Norm(Y0);
                    }
                    while (ChekEpsilon(E, lambda, Lmin.Text) == false)
                    {
                        Lmin.Text = lambda.ToString();
                        for (int i = 0; i < dataGridView1.RowCount; i++) //y
                        {
                            dataGridView3.Rows[i].Cells[0].Value = 0;
                            for (int j = 0; j < dataGridView1.RowCount; j++)
                            {
                                 dataGridView3.Rows[i].Cells[0].Value = Convert.ToDouble(dataGridView3.Rows[i].Cells[0].Value.ToString()) + Convert.ToDouble(dataGridView2.Rows[i].Cells[j].Value.ToString()) * Convert.ToDouble(Xmin.Rows[j].Cells[0].Value.ToString());
                            }
                        }
                        for (int i = 0; i < dataGridView1.RowCount; i++) //x
                        {
                            Xmin.Rows[i].Cells[0].Value = Convert.ToDouble(dataGridView3.Rows[i].Cells[0].Value.ToString()) / Norm(dataGridView3);
                        }
                        lambda = Convert.ToDouble(dataGridView3.Rows[0].Cells[0].Value.ToString()) / Convert.ToDouble(Xmin.Rows[0].Cells[0].Value.ToString());
                    }
                    lambda = lambda - Convert.ToDouble(Lmax.Text);
                    lambda = Math.Abs(lambda);
                    lambda = Math.Round(lambda, 4);
                    Lmin.Text = lambda.ToString();
                    lambda = Convert.ToDouble(Lmax.Text);
                    lambda = Math.Round(lambda, 4);
                    Lmax.Text = lambda.ToString();
                }
            }
        }
    }
}
