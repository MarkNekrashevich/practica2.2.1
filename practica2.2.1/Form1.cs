using System;
using System.Windows.Forms;

namespace practica2._2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double F(double x, double a, double b, double c)
        {
            if (x + c < 0 && a != 0)
            {
                return -(a * x + b) / (x - a);
            }
            else if (x + c > 0 && a == 0)
            {
                return -(x - c) / (x - a);
            }
            else
            {
                return (x + c) / (c + x);
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // �������� �������� ���������� �� ��������� �����
                double x = double.Parse(textBoxX.Text);
                double a = double.Parse(textBoxA.Text);
                double b = double.Parse(textBoxB.Text);
                double c = double.Parse(textBoxC.Text);

                // ������� ������� ����� ����������� ����� ������
                dataGridViewResults.Rows.Clear();

                // ��������� �������, ���� ��� ��� �� ���� ���������
                if (dataGridViewResults.ColumnCount == 0)
                {
                    dataGridViewResults.Columns.Add("X", "X");
                    dataGridViewResults.Columns.Add("F(X)", "F(X)");
                }

                // ��������� � ���������� ���������� � �������
                double startX = -10; // ��������� ��������
                double endX = 10;   // �������� ��������
                double stepX = 0.1;                // ���
                for (double i = startX; i <= endX; i += stepX)
                {
                    double result = F(i, a, b, c);
                    dataGridViewResults.Rows.Add(i, result);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("������: ������� �������� �������� � ���� ��� �����.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("������: " + ex.Message);
            }
        }

        // ����������� ������� ��� ��������� �����, ������ � ������� ����� ���������� �������
        private void textBoxC_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxX_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridViewResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
