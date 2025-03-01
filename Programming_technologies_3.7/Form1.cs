namespace Programming_technologies_3._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            CalculateFraction('+');
        }

        private void DifButton_Click(object sender, EventArgs e)
        {
            CalculateFraction('-');
        }

        private void MultButton_Click(object sender, EventArgs e)
        {
            CalculateFraction('*');
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            CalculateFraction('/');
        }

        private void ReducButton_Click(object sender, EventArgs e)
        {
            ReduceFractions();
        }

        private void ComButton_Click(object sender, EventArgs e)
        {
            CompareFractions();
        }

        private void CalculateFraction(char operation)
        {
            try
            {
                int num1 = int.Parse(Numerator1.Text);
                int denom1 = int.Parse(Denominator1.Text);
                int num2 = int.Parse(Numerator2.Text);
                int denom2 = int.Parse(Denominator2.Text);

                if (denom1 == 0 || denom2 == 0)
                {
                    MessageBox.Show("Знаменатель не может быть нулем.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int resultNumerator;
                int resultDenominator;

                if (operation == '+')
                {
                    resultNumerator = num1 * denom2 + num2 * denom1;
                    resultDenominator = denom1 * denom2;
                    Sign.Text = "+";
                }
                else if (operation == '-')
                {
                    resultNumerator = num1 * denom2 - num2 * denom1;
                    resultDenominator = denom1 * denom2;
                    Sign.Text = "-";
                }
                else if (operation == '*')
                {
                    resultNumerator = num1 * num2;
                    resultDenominator = denom1 * denom2;
                    Sign.Text = "*";
                }
                else // Деление
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("Числитель второй дроби не может быть нулем при делении.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    resultNumerator = num1 * denom2;
                    resultDenominator = denom1 * num2;
                    Sign.Text = "/";
                }

                // Сокращение дроби
                int gcd = GCD(resultNumerator, resultDenominator);
                resultNumerator /= gcd;
                resultDenominator /= gcd;

                // Вывод результата
                ResultNumerator.Text = resultNumerator.ToString();
                ResultDenominator.Text = resultDenominator.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные числовые значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CompareFractions()
        {
            try
            {
                int num1 = int.Parse(Numerator1.Text);
                int denom1 = int.Parse(Denominator1.Text);
                int num2 = int.Parse(Numerator2.Text);
                int denom2 = int.Parse(Denominator2.Text);

                if (denom1 == 0 || denom2 == 0)
                {
                    MessageBox.Show("Знаменатель не может быть нулем.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Приведение к общему знаменателю
                int leftSide = num1 * denom2;
                int rightSide = num2 * denom1;

                if (leftSide > rightSide)
                {
                    Sign.Text = ">";
                }
                else if (leftSide < rightSide)
                {
                    Sign.Text = "<";
                }
                else
                {
                    Sign.Text = "=";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные числовые значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReduceFractions()
        {
            try
            {
                int num1 = int.Parse(Numerator1.Text);
                int denom1 = int.Parse(Denominator1.Text);
                int num2 = int.Parse(Numerator2.Text);
                int denom2 = int.Parse(Denominator2.Text);

                if (denom1 == 0 || denom2 == 0)
                {
                    MessageBox.Show("Знаменатель не может быть нулем.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int gcd1 = GCD(num1, denom1);
                Numerator1.Text = (num1 / gcd1).ToString();
                Denominator1.Text = (denom1 / gcd1).ToString();

                int gcd2 = GCD(num2, denom2);
                Numerator2.Text = (num2 / gcd2).ToString();
                Denominator2.Text = (denom2 / gcd2).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные числовые значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }

    }
}
