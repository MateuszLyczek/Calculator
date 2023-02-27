using System;
using System.Windows.Forms;

namespace Calculator.WindowsFormsApp
{
    public enum Operation
    {
        None,
        Addition,
        Subtract,
        Division,
        Multiplication
    }

    public partial class Form1 : Form
    {
        private Operation _currentOperation = Operation.None;
        private bool _isTheResultOnTheVisable;
        private string _firstValue;
        private string _secondValue;

        public Form1()
        {
            InitializeComponent();
            screen.Text = "0";
        }

        private void OnBtnNrClick(object sender, EventArgs e)
        {
            var clickedValue = ((Button)sender).Text;

            if (screen.Text == "0" && ((Button)sender).Text != ",")
                screen.Text = string.Empty;

            if (_isTheResultOnTheVisable)
            {
                _isTheResultOnTheVisable = false;
                screen.Text = string.Empty;

                if (((Button)sender).Text == ",")
                    clickedValue = "0,";
            }

            screen.Text += ((Button)sender).Text;
            SetResultBtnState(true);

            if (_currentOperation != Operation.None)
                _secondValue += ((Button)sender).Text;
            else
                SetOperationBtnState(true);
        }

        private void OnBtnOperationClick(object sender, EventArgs e)
        {
            _firstValue = screen.Text;

            var operation = ((Button)sender).Text;

            _currentOperation = operation switch
            {
                "+" => Operation.Addition,
                "-" => Operation.Subtract,
                "/" => Operation.Division,
                "*" => Operation.Multiplication,
                _ => Operation.None,
            };

            screen.Text += $" {operation} ";

            if (_isTheResultOnTheVisable)
                _isTheResultOnTheVisable = false;

            SetOperationBtnState(false);
            SetResultBtnState(false);
        }

        private void OnBtnResultClick(object sender, EventArgs e)
        {
            if (_currentOperation == Operation.None)
                return;

            var firstNr = double.Parse(_firstValue);
            var secondNr = double.Parse(_secondValue);

            var result = Calculate(firstNr, secondNr);

            screen.Text = result.ToString();
            _secondValue = string.Empty;
            _currentOperation = Operation.None;
            _isTheResultOnTheVisable = true;
            SetOperationBtnState(true);
            SetResultBtnState(true);
        }

        private double Calculate(double firstNr, double secondNr)
        {
            switch (_currentOperation)
            {
                case Operation.None:
                    return firstNr;
                case Operation.Addition:
                    return firstNr + secondNr;
                case Operation.Subtract:
                    return firstNr - secondNr;
                case Operation.Division:
                    if (secondNr == 0)
                    {
                        MessageBox.Show("Nie można dzielić przez 0!");
                        return 0;
                    }
                    return firstNr / secondNr;
                case Operation.Multiplication:
                    return firstNr * secondNr;
            }

            return 0;
        }

        private void OnBtnClearClick(object sender, EventArgs e)
        {
            screen.Text = "0";
            _firstValue = string.Empty;
            _secondValue = string.Empty;
            _currentOperation = Operation.None;
        }

        private void SetOperationBtnState(bool value)
        {
            bAdd.Enabled = value;
            bMultiplication.Enabled = value;
            bDivision.Enabled = value;
            bSubtract.Enabled = value;
        }

        private void SetResultBtnState(bool value)
        {
            bResult.Enabled = value;
        }
    }
}