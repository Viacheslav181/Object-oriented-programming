using System.Runtime.CompilerServices;

namespace SlavaLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //�������� 1
            label1.Text = "� =";
            label2.Text = "� = ";
            label3.Text = "���������:";
            lblResult.Text = "";
            btnOK.Text = "����������";

            //�������� 2
            label4.Text = "a = ";
            label5.Text = "A8 = ";
            label7.Text = "A10 = ";
            btnOK2.Text = "����������";
            lblResultA8.Text = "";
            lblResultA10.Text = "";

            //�������� 3
            label6.Text = "a = ";
            label8.Text = "b = ";
            label9.Text = "c = ";
            label10.Text = "���������:";
            lblResult3.Text = "";
            btnOK3.Text = "����������";

            //�������� 4
            label11.Text = "a1 =";
            label12.Text = "a2 =";
            label13.Text = "a3 =";
            label14.Text = "a4 =";
            label15.Text = "���������:";
            lblResult4.Text = "";
            btnOK4.Text = "����������";

            //�������� 5
            label16.Text = "������ ����� ��� � ����:";
            label17.Text = "���������:";
            btnOK5.Text = "����������";

            //�������� 6
            label18.Text = "������ �����, ������� �������:";
            label19.Text = "���������:";
            btnOK6.Text = "����������";
            lblResult6.Text = "";

            //�������� 7
            label20.Text = "������ �����:";
            label21.Text = "���������:";
            btnOK7.Text = "����������";
            lblResult7.Text = "";

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtX.Text) ||
                string.IsNullOrWhiteSpace(txtY.Text))

            {
                MessageBox.Show("���������, �������� �� ������� ����");
                return;
            }

            double x = Convert.ToDouble(txtX.Text);
            double y = Convert.ToDouble(txtY.Text);
            double tan_x = Math.Tan(x);
            double cot_x = 1 / tan_x;
            double cos_xy = Math.Cos(x - y);
            double result = Math.Pow((1 - tan_x), cot_x) + cos_xy;
            lblResult.Text = result.ToString();
        }

        private void btnOK2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtA.Text))

            {
                MessageBox.Show("���������, �������� �� ������� ����");
                return;
            }
            double a = Convert.ToDouble(txtA.Text);

            double a2 = a * a;
            double a4 = a2 * a2;
            double a8 = a4 * a4;
            double a10 = a8 * (a2);
            lblResultA8.Text = a8.ToString();
            lblResultA10.Text = a10.ToString();
        }

        private void btnOK3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAa.Text) ||
                string.IsNullOrWhiteSpace(txtB.Text) ||
                string.IsNullOrWhiteSpace(txtC.Text))

            {
                MessageBox.Show("���������, �������� �� ������� ����");
                return;
            }
            double a = Convert.ToDouble(txtAa.Text);
            double b = Convert.ToDouble(txtB.Text);
            double c = Convert.ToDouble(txtC.Text);
            bool hasOppositePair = (a < 0 && b > 0) || (a > 0 && b < 0) ||
                                   (a < 0 && c > 0) || (a > 0 && c < 0) ||
                                   (b < 0 && c > 0) || (b > 0 && c < 0);
            lblResult3.Text = hasOppositePair.ToString();
        }

        private void btnOK4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtA1.Text) ||
                string.IsNullOrWhiteSpace(txtA2.Text) ||
                string.IsNullOrWhiteSpace(txtA3.Text) ||
                string.IsNullOrWhiteSpace(txtA4.Text))

            {
                MessageBox.Show("���������, �������� �� ������� ����");
                return;
            }
            double a1 = Convert.ToDouble(txtA1.Text);
            double a2 = Convert.ToDouble(txtA2.Text);
            double a3 = Convert.ToDouble(txtA3.Text);
            double a4 = Convert.ToDouble(txtA4.Text);
            double n = (a1 != a2 && a1 != a3 && a1 != a4) ? 1 :
                       (a2 != a1 && a2 != a3 && a2 != a4) ? 2 :
                       (a3 != a1 && a3 != a2 && a3 != a4) ? 3 :
                                                             4;
            lblResult4.Text = "an =" + n.ToString();
        }

        private void btnOK5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumber.Text))
            {
                MessageBox.Show("���������, �������� �� ������� ����");
                return;
            }
            double dayOfYear = Convert.ToDouble(txtNumber.Text);
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            int month = 0;
            int day = (int)dayOfYear;
            while (day > daysInMonth[month])
            {
                day -= daysInMonth[month];
                month++;
            }

            lblResult5.Text = $"{dayOfYear + " ���� ����"} - {day} {GetMonthName(month + 1)}";
        }
        static string GetMonthName(int month)
        {
            switch (month)
            {
                case 1: return "����";
                case 2: return "������";
                case 3: return "�������";
                case 4: return "�����";
                case 5: return "������";
                case 6: return "������";
                case 7: return "�����";
                case 8: return "������";
                case 9: return "�������";
                case 10: return "������";
                case 11: return "���������";
                case 12: return "������";
                default: return "��������� �����";
            }
        }

        private void btnOK6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDano.Text))
            {
                MessageBox.Show("���������, �������� �� ������� ����");
                return;
            }
            string input = Convert.ToString(txtDano.Text);
            string[] numbers = input.Split(' ');

            double[] sequence = new double[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                sequence[i] = Convert.ToDouble(numbers[i]);
            }

            double min = sequence[0];
            double max = sequence[0];
            foreach (double number in sequence)
            {
                if (number < min)
                    min = number;
                if (number > max)
                    max = number;
            }

            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] >= 0)
                    sequence[i] *= min * min;
                else
                    sequence[i] *= max * max;
            }

            string result = string.Join(" ", sequence);

            lblResult6.Text = result.ToString();
            foreach (double number in sequence)
            {
                Console.Write(number + " ");
            }
        }

        private void btnOK7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTEXT.Text))
            {
                MessageBox.Show("���������, �������� �� ������� ����");
                return;
            }
            string input = Convert.ToString(txtTEXT.Text);
            string result = "";
            foreach (char c in input)
            {
                if (c != '*')
                {
                    result += c;
                    result += c;
                }
            }
            lblResult7.Text = result.ToString();
        }

        private void txtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;

        }

        private void txtY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;

        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;

        }

        private void txtAa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;

        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;

        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;

        }

        private void txtA1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;

        }

        private void txtA2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;

        }

        private void txtA3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;

        }

        private void txtA4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;

        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;

        }

        private void txtDano_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete || e.KeyChar == ' ')
            {
                return;
            }
            e.Handled = true;
        }
    }
}
