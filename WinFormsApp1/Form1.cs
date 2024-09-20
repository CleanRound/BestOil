using System;
using System.Windows.Forms;

namespace BestOil
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer clearFormTimer;
        private decimal fuelPrice = 0;
        private decimal totalFuelPrice = 0;
        private decimal totalCafePrice = 0;

        public Form1()
        {
            InitializeComponent();
            comboBoxFuel.SelectedIndex = 0;
            UpdateFuelPrice();
        }

        private void comboBoxFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFuelPrice();
        }

        private void UpdateFuelPrice()
        {
            switch (comboBoxFuel.SelectedItem.ToString())
            {
                case "Petrol 92":
                    fuelPrice = 40;
                    break;
                case "Petrol 95":
                    fuelPrice = 45;
                    break;
                case "Diesel":
                    fuelPrice = 38;
                    break;
            }
            textBoxFuelPrice.Text = fuelPrice.ToString("0.00");
        }

        private void radioButtonLiters_CheckedChanged(object sender, EventArgs e)
        {
            textBoxLiters.Enabled = radioButtonLiters.Checked;
            textBoxAmount.Enabled = !radioButtonLiters.Checked;
        }

        private void radioButtonAmount_CheckedChanged(object sender, EventArgs e)
        {
            textBoxAmount.Enabled = radioButtonAmount.Checked;
            textBoxLiters.Enabled = !radioButtonAmount.Checked;
        }

        private void checkBoxHotDog_CheckedChanged(object sender, EventArgs e)
        {
            textBoxHotDogQty.Enabled = checkBoxHotDog.Checked;
        }

        private void checkBoxBurger_CheckedChanged(object sender, EventArgs e)
        {
            textBoxBurgerQty.Enabled = checkBoxBurger.Checked;
        }

        private void checkBoxFries_CheckedChanged(object sender, EventArgs e)
        {
            textBoxFriesQty.Enabled = checkBoxFries.Checked;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            totalFuelPrice = 0;
            totalCafePrice = 0;

            if (radioButtonLiters.Checked)
            {
                if (!string.IsNullOrEmpty(textBoxLiters.Text) && decimal.TryParse(textBoxLiters.Text, out decimal liters))
                {
                    totalFuelPrice = liters * fuelPrice;
                }
                else
                {
                    MessageBox.Show("Please enter a valid number of liters.");
                    return;
                }
            }
            else if (radioButtonAmount.Checked)
            {
                if (!string.IsNullOrEmpty(textBoxAmount.Text) && decimal.TryParse(textBoxAmount.Text, out decimal amount))
                {
                    totalFuelPrice = amount;
                }
                else
                {
                    MessageBox.Show("Please enter a valid amount.");
                    return;
                }
            }

            if (checkBoxHotDog.Checked && decimal.TryParse(textBoxHotDogQty.Text, out decimal hotDogQty))
            {
                totalCafePrice += 30 * hotDogQty; // Example price
            }

            if (checkBoxBurger.Checked && decimal.TryParse(textBoxBurgerQty.Text, out decimal burgerQty))
            {
                totalCafePrice += 40 * burgerQty;
            }

            if (checkBoxFries.Checked && decimal.TryParse(textBoxFriesQty.Text, out decimal friesQty))
            {
                totalCafePrice += 25 * friesQty;
            }

            decimal total = totalFuelPrice + totalCafePrice;
            textBoxTotal.Text = total.ToString("0.00");

            if (clearFormTimer == null)
            {
                clearFormTimer = new System.Windows.Forms.Timer();
                clearFormTimer.Interval = 10000; // 10 seconds
                clearFormTimer.Tick += ClearFormTimer_Tick;
                clearFormTimer.Start();
            }
        }

        private void ClearFormTimer_Tick(object sender, EventArgs e)
        {
            clearFormTimer.Stop();
            clearFormTimer.Dispose();
            clearFormTimer = null;

            var result = MessageBox.Show("Clear form?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                ResetForm();
            }
            else if (result == DialogResult.No)
            {
                clearFormTimer = new System.Windows.Forms.Timer();
                clearFormTimer.Interval = 10000;
                clearFormTimer.Tick += ClearFormTimer_Tick;
                clearFormTimer.Start();
            }
        }


        private void ResetForm()
        {
            comboBoxFuel.SelectedIndex = 0;
            textBoxLiters.Text = string.Empty;
            textBoxAmount.Text = string.Empty;

            checkBoxHotDog.Checked = false;
            checkBoxBurger.Checked = false;
            checkBoxFries.Checked = false;
            textBoxHotDogQty.Text = "0";
            textBoxBurgerQty.Text = "0";
            textBoxFriesQty.Text = "0";

            textBoxTotal.Text = "0.00";
        }
    }
}

