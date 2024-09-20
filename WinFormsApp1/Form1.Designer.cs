namespace BestOil
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxFuel = new System.Windows.Forms.ComboBox();
            this.labelFuelPrice = new System.Windows.Forms.Label();
            this.textBoxFuelPrice = new System.Windows.Forms.TextBox();
            this.radioButtonLiters = new System.Windows.Forms.RadioButton();
            this.radioButtonAmount = new System.Windows.Forms.RadioButton();
            this.textBoxLiters = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.groupBoxFuel = new System.Windows.Forms.GroupBox();
            this.groupBoxMiniCafe = new System.Windows.Forms.GroupBox();
            this.checkBoxHotDog = new System.Windows.Forms.CheckBox();
            this.checkBoxBurger = new System.Windows.Forms.CheckBox();
            this.checkBoxFries = new System.Windows.Forms.CheckBox();
            this.textBoxHotDogQty = new System.Windows.Forms.TextBox();
            this.textBoxBurgerQty = new System.Windows.Forms.TextBox();
            this.textBoxFriesQty = new System.Windows.Forms.TextBox();

            // New text boxes for the price per cafe item
            this.textBoxHotDogPrice = new System.Windows.Forms.TextBox();
            this.textBoxBurgerPrice = new System.Windows.Forms.TextBox();
            this.textBoxFriesPrice = new System.Windows.Forms.TextBox();

            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelTotalToPay = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.groupBoxFuel.SuspendLayout();
            this.groupBoxMiniCafe.SuspendLayout();
            this.SuspendLayout();

            // ComboBox for Fuel Selection
            this.comboBoxFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuel.FormattingEnabled = true;
            this.comboBoxFuel.Items.AddRange(new object[] {
            "Petrol 92",
            "Petrol 95",
            "Diesel"});
            this.comboBoxFuel.Location = new System.Drawing.Point(20, 30);
            this.comboBoxFuel.Name = "comboBoxFuel";
            this.comboBoxFuel.Size = new System.Drawing.Size(100, 24);
            this.comboBoxFuel.TabIndex = 0;
            this.comboBoxFuel.SelectedIndexChanged += new System.EventHandler(this.comboBoxFuel_SelectedIndexChanged);

            // Label for Fuel Price
            this.labelFuelPrice.AutoSize = true;
            this.labelFuelPrice.Location = new System.Drawing.Point(130, 30);
            this.labelFuelPrice.Name = "labelFuelPrice";
            this.labelFuelPrice.Size = new System.Drawing.Size(74, 17);
            this.labelFuelPrice.TabIndex = 1;
            this.labelFuelPrice.Text = "Price (UAH)";

            // TextBox for Fuel Price (read-only)
            this.textBoxFuelPrice.Location = new System.Drawing.Point(210, 30);
            this.textBoxFuelPrice.Name = "textBoxFuelPrice";
            this.textBoxFuelPrice.ReadOnly = true;
            this.textBoxFuelPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxFuelPrice.TabIndex = 2;

            // RadioButton for choosing Liters
            this.radioButtonLiters.AutoSize = true;
            this.radioButtonLiters.Location = new System.Drawing.Point(20, 70);
            this.radioButtonLiters.Name = "radioButtonLiters";
            this.radioButtonLiters.Size = new System.Drawing.Size(64, 21);
            this.radioButtonLiters.TabIndex = 3;
            this.radioButtonLiters.TabStop = true;
            this.radioButtonLiters.Text = "Liters";
            this.radioButtonLiters.UseVisualStyleBackColor = true;
            this.radioButtonLiters.CheckedChanged += new System.EventHandler(this.radioButtonLiters_CheckedChanged);

            // RadioButton for choosing Amount
            this.radioButtonAmount.AutoSize = true;
            this.radioButtonAmount.Location = new System.Drawing.Point(100, 70);
            this.radioButtonAmount.Name = "radioButtonAmount";
            this.radioButtonAmount.Size = new System.Drawing.Size(78, 21);
            this.radioButtonAmount.TabIndex = 4;
            this.radioButtonAmount.TabStop = true;
            this.radioButtonAmount.Text = "Amount";
            this.radioButtonAmount.UseVisualStyleBackColor = true;
            this.radioButtonAmount.CheckedChanged += new System.EventHandler(this.radioButtonAmount_CheckedChanged);

            // TextBox for Liters Input
            this.textBoxLiters.Enabled = false;
            this.textBoxLiters.Location = new System.Drawing.Point(20, 100);
            this.textBoxLiters.Name = "textBoxLiters";
            this.textBoxLiters.Size = new System.Drawing.Size(100, 22);
            this.textBoxLiters.TabIndex = 5;

            // TextBox for Amount Input
            this.textBoxAmount.Enabled = false;
            this.textBoxAmount.Location = new System.Drawing.Point(130, 100);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 22);
            this.textBoxAmount.TabIndex = 6;

            // GroupBox for Fuel Section
            this.groupBoxFuel.Controls.Add(this.comboBoxFuel);
            this.groupBoxFuel.Controls.Add(this.labelFuelPrice);
            this.groupBoxFuel.Controls.Add(this.textBoxFuelPrice);
            this.groupBoxFuel.Controls.Add(this.radioButtonLiters);
            this.groupBoxFuel.Controls.Add(this.textBoxAmount);
            this.groupBoxFuel.Controls.Add(this.radioButtonAmount);
            this.groupBoxFuel.Controls.Add(this.textBoxLiters);
            this.groupBoxFuel.Location = new System.Drawing.Point(20, 20);
            this.groupBoxFuel.Name = "groupBoxFuel";
            this.groupBoxFuel.Size = new System.Drawing.Size(330, 150);
            this.groupBoxFuel.TabIndex = 7;
            this.groupBoxFuel.TabStop = false;
            this.groupBoxFuel.Text = "Fuel";

            // GroupBox for Mini-Cafe Section
            this.groupBoxMiniCafe.Controls.Add(this.checkBoxHotDog);
            this.groupBoxMiniCafe.Controls.Add(this.checkBoxBurger);
            this.groupBoxMiniCafe.Controls.Add(this.checkBoxFries);
            this.groupBoxMiniCafe.Controls.Add(this.textBoxHotDogQty);
            this.groupBoxMiniCafe.Controls.Add(this.textBoxBurgerQty);
            this.groupBoxMiniCafe.Controls.Add(this.textBoxFriesQty);

            // Adding price TextBoxes for Mini Cafe Items
            this.groupBoxMiniCafe.Controls.Add(this.textBoxHotDogPrice);
            this.groupBoxMiniCafe.Controls.Add(this.textBoxBurgerPrice);
            this.groupBoxMiniCafe.Controls.Add(this.textBoxFriesPrice);

            this.groupBoxMiniCafe.Location = new System.Drawing.Point(20, 180);
            this.groupBoxMiniCafe.Name = "groupBoxMiniCafe";
            this.groupBoxMiniCafe.Size = new System.Drawing.Size(330, 150);
            this.groupBoxMiniCafe.TabIndex = 8;
            this.groupBoxMiniCafe.TabStop = false;
            this.groupBoxMiniCafe.Text = "Mini-Cafe";

            // CheckBox for HotDog
            this.checkBoxHotDog.AutoSize = true;
            this.checkBoxHotDog.Location = new System.Drawing.Point(20, 30);
            this.checkBoxHotDog.Name = "checkBoxHotDog";
            this.checkBoxHotDog.Size = new System.Drawing.Size(82, 21);
            this.checkBoxHotDog.TabIndex = 0;
            this.checkBoxHotDog.Text = "Hot Dog";
            this.checkBoxHotDog.UseVisualStyleBackColor = true;
            this.checkBoxHotDog.CheckedChanged += new System.EventHandler(this.checkBoxHotDog_CheckedChanged);

            // CheckBox for Burger
            this.checkBoxBurger.AutoSize = true;
            this.checkBoxBurger.Location = new System.Drawing.Point(20, 70);
            this.checkBoxBurger.Name = "checkBoxBurger";
            this.checkBoxBurger.Size = new System.Drawing.Size(74, 21);
            this.checkBoxBurger.TabIndex = 1;
            this.checkBoxBurger.Text = "Burger";
            this.checkBoxBurger.UseVisualStyleBackColor = true;
            this.checkBoxBurger.CheckedChanged += new System.EventHandler(this.checkBoxBurger_CheckedChanged);

            // CheckBox for Fries
            this.checkBoxFries.AutoSize = true;
            this.checkBoxFries.Location = new System.Drawing.Point(20, 110);
            this.checkBoxFries.Name = "checkBoxFries";
            this.checkBoxFries.Size = new System.Drawing.Size(61, 21);
            this.checkBoxFries.TabIndex = 2;
            this.checkBoxFries.Text = "Fries";
            this.checkBoxFries.UseVisualStyleBackColor = true;
            this.checkBoxFries.CheckedChanged += new System.EventHandler(this.checkBoxFries_CheckedChanged);

            // TextBox for Hot Dog Quantity
            this.textBoxHotDogQty.Enabled = false;
            this.textBoxHotDogQty.Location = new System.Drawing.Point(120, 30);
            this.textBoxHotDogQty.Name = "textBoxHotDogQty";
            this.textBoxHotDogQty.Size = new System.Drawing.Size(50, 22);
            this.textBoxHotDogQty.TabIndex = 3;

            // TextBox for Burger Quantity
            this.textBoxBurgerQty.Enabled = false;
            this.textBoxBurgerQty.Location = new System.Drawing.Point(120, 70);
            this.textBoxBurgerQty.Name = "textBoxBurgerQty";
            this.textBoxBurgerQty.Size = new System.Drawing.Size(50, 22);
            this.textBoxBurgerQty.TabIndex = 4;

            // TextBox for Fries Quantity
            this.textBoxFriesQty.Enabled = false;
            this.textBoxFriesQty.Location = new System.Drawing.Point(120, 110);
            this.textBoxFriesQty.Name = "textBoxFriesQty";
            this.textBoxFriesQty.Size = new System.Drawing.Size(50, 22);
            this.textBoxFriesQty.TabIndex = 5;

            // TextBox for Hot Dog Price (read-only)
            this.textBoxHotDogPrice.Location = new System.Drawing.Point(190, 30);
            this.textBoxHotDogPrice.Name = "textBoxHotDogPrice";
            this.textBoxHotDogPrice.ReadOnly = true;
            this.textBoxHotDogPrice.Size = new System.Drawing.Size(50, 22);
            this.textBoxHotDogPrice.TabIndex = 6;
            this.textBoxHotDogPrice.Text = "30"; // Set default price for Hot Dog

            // TextBox for Burger Price (read-only)
            this.textBoxBurgerPrice.Location = new System.Drawing.Point(190, 70);
            this.textBoxBurgerPrice.Name = "textBoxBurgerPrice";
            this.textBoxBurgerPrice.ReadOnly = true;
            this.textBoxBurgerPrice.Size = new System.Drawing.Size(50, 22);
            this.textBoxBurgerPrice.TabIndex = 7;
            this.textBoxBurgerPrice.Text = "40"; // Set default price for Burger

            // TextBox for Fries Price (read-only)
            this.textBoxFriesPrice.Location = new System.Drawing.Point(190, 110);
            this.textBoxFriesPrice.Name = "textBoxFriesPrice";
            this.textBoxFriesPrice.ReadOnly = true;
            this.textBoxFriesPrice.Size = new System.Drawing.Size(50, 22);
            this.textBoxFriesPrice.TabIndex = 8;
            this.textBoxFriesPrice.Text = "25"; // Set default price for Fries

            // Calculate Button
            this.buttonCalculate.Location = new System.Drawing.Point(20, 340);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 30);
            this.buttonCalculate.TabIndex = 9;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);

            // Label for Total to Pay
            this.labelTotalToPay.AutoSize = true;
            this.labelTotalToPay.Location = new System.Drawing.Point(130, 340);
            this.labelTotalToPay.Name = "labelTotalToPay";
            this.labelTotalToPay.Size = new System.Drawing.Size(90, 17);
            this.labelTotalToPay.TabIndex = 10;
            this.labelTotalToPay.Text = "Total to Pay:";

            // TextBox for Total Amount
            this.textBoxTotal.Location = new System.Drawing.Point(230, 340);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(100, 22);
            this.textBoxTotal.TabIndex = 11;

            // Form Settings
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelTotalToPay);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBoxMiniCafe);
            this.Controls.Add(this.groupBoxFuel);
            this.Name = "Form1";
            this.Text = "BestOil";
            this.groupBoxFuel.ResumeLayout(false);
            this.groupBoxFuel.PerformLayout();
            this.groupBoxMiniCafe.ResumeLayout(false);
            this.groupBoxMiniCafe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFuel;
        private System.Windows.Forms.Label labelFuelPrice;
        private System.Windows.Forms.TextBox textBoxFuelPrice;
        private System.Windows.Forms.RadioButton radioButtonLiters;
        private System.Windows.Forms.RadioButton radioButtonAmount;
        private System.Windows.Forms.TextBox textBoxLiters;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.GroupBox groupBoxFuel;
        private System.Windows.Forms.GroupBox groupBoxMiniCafe;
        private System.Windows.Forms.CheckBox checkBoxHotDog;
        private System.Windows.Forms.CheckBox checkBoxBurger;
        private System.Windows.Forms.CheckBox checkBoxFries;
        private System.Windows.Forms.TextBox textBoxHotDogQty;
        private System.Windows.Forms.TextBox textBoxBurgerQty;
        private System.Windows.Forms.TextBox textBoxFriesQty;

        // Price text boxes
        private System.Windows.Forms.TextBox textBoxHotDogPrice;
        private System.Windows.Forms.TextBox textBoxBurgerPrice;
        private System.Windows.Forms.TextBox textBoxFriesPrice;

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelTotalToPay;
        private System.Windows.Forms.TextBox textBoxTotal;
    }
}
