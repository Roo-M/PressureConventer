namespace PressureConventer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string pressureKpa = textBoxkPa.Text;
            double kiloPascals = Convert.ToDouble(pressureKpa);
            double bars = Math.Round(kiloPascals * 0.01d, 1);
            double psi = Math.Round(kiloPascals * 0.145d, 1);
            textBoxBar.Text = Convert.ToString(bars);
            textBoxPsi.Text = Convert.ToString(psi);
        }

        private void textBoxkPa_Leave(object sender, EventArgs e)
        {
            // Check if textBoxkPa contain numeric value
            double kPa;
            bool numericValue = double.TryParse(textBoxkPa.Text, out kPa);
            if (kPa <= 10)
            {
                string message = "Virheellinen painetieto, paine pitää olla yli 10kPa, anna pelkkiä numeroita";
                string header = "Väärä paine";
                DialogResult kPaErrorMsg;
                kPaErrorMsg = MessageBox.Show(message, header, MessageBoxButtons.RetryCancel);

                // Change button state to enabled
                buttonCalculate.Enabled = false;
            }

            else
            {
                // Change button state to enabled
                buttonCalculate.Enabled = true;
                buttonCalculate.Focus();

            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxkPa.Text = string.Empty;
            textBoxkPa.Focus();
            textBoxPsi.Text = string.Empty;
            textBoxBar.Text = string.Empty;
            buttonCalculate.Enabled = false;
        }
    }
}
