namespace ProjectGasStation.Forms;

partial class FormSale
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
        labelSeller = new Label();
        comboBoxSeller = new ComboBox();
        labelShift = new Label();
        comboBoxShift = new ComboBox();
        labelFuel = new Label();
        comboBoxFuel = new ComboBox();
        labelQuantity = new Label();
        numericUpDownQuantity = new NumericUpDown();
        labelSum = new Label();
        numericUpDownSum = new NumericUpDown();
        labelDate = new Label();
        dateTimePickerDate = new DateTimePicker();
        buttonSave = new Button();
        buttonCancel = new Button();
        ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDownSum).BeginInit();
        SuspendLayout();
        // 
        // labelSeller
        // 
        labelSeller.AutoSize = true;
        labelSeller.Location = new Point(12, 18);
        labelSeller.Name = "labelSeller";
        labelSeller.Size = new Size(140, 20);
        labelSeller.TabIndex = 0;
        labelSeller.Text = "Продавец:";
        // 
        // comboBoxSeller
        // 
        comboBoxSeller.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxSeller.FormattingEnabled = true;
        comboBoxSeller.Location = new Point(170, 15);
        comboBoxSeller.Name = "comboBoxSeller";
        comboBoxSeller.Size = new Size(260, 28);
        comboBoxSeller.TabIndex = 1;
        // 
        // labelShift
        // 
        labelShift.AutoSize = true;
        labelShift.Location = new Point(12, 58);
        labelShift.Name = "labelShift";
        labelShift.Size = new Size(140, 20);
        labelShift.TabIndex = 2;
        labelShift.Text = "Смена:";
        // 
        // comboBoxShift
        // 
        comboBoxShift.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxShift.FormattingEnabled = true;
        comboBoxShift.Location = new Point(170, 55);
        comboBoxShift.Name = "comboBoxShift";
        comboBoxShift.Size = new Size(260, 28);
        comboBoxShift.TabIndex = 3;
        // 
        // labelFuel
        // 
        labelFuel.AutoSize = true;
        labelFuel.Location = new Point(12, 98);
        labelFuel.Name = "labelFuel";
        labelFuel.Size = new Size(140, 20);
        labelFuel.TabIndex = 4;
        labelFuel.Text = "ГСМ:";
        // 
        // comboBoxFuel
        // 
        comboBoxFuel.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxFuel.FormattingEnabled = true;
        comboBoxFuel.Location = new Point(170, 95);
        comboBoxFuel.Name = "comboBoxFuel";
        comboBoxFuel.Size = new Size(260, 28);
        comboBoxFuel.TabIndex = 5;
        comboBoxFuel.SelectedIndexChanged += ComboBoxFuel_SelectedIndexChanged;
        // 
        // labelQuantity
        // 
        labelQuantity.AutoSize = true;
        labelQuantity.Location = new Point(12, 138);
        labelQuantity.Name = "labelQuantity";
        labelQuantity.Size = new Size(140, 20);
        labelQuantity.TabIndex = 6;
        labelQuantity.Text = "Количество:";
        // 
        // numericUpDownQuantity
        // 
        numericUpDownQuantity.DecimalPlaces = 2;
        numericUpDownQuantity.Location = new Point(170, 135);
        numericUpDownQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        numericUpDownQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
        numericUpDownQuantity.Name = "numericUpDownQuantity";
        numericUpDownQuantity.Size = new Size(260, 27);
        numericUpDownQuantity.TabIndex = 7;
        numericUpDownQuantity.Value = new decimal(new int[] { 1, 0, 0, 131072 });
        numericUpDownQuantity.ValueChanged += NumericUpDownQuantity_ValueChanged;
        // 
        // labelSum
        // 
        labelSum.AutoSize = true;
        labelSum.Location = new Point(12, 178);
        labelSum.Name = "labelSum";
        labelSum.Size = new Size(140, 20);
        labelSum.TabIndex = 8;
        labelSum.Text = "Сумма, руб.:";
        // 
        // numericUpDownSum
        // 
        numericUpDownSum.DecimalPlaces = 2;
        numericUpDownSum.Enabled = false;
        numericUpDownSum.Location = new Point(170, 175);
        numericUpDownSum.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
        numericUpDownSum.Name = "numericUpDownSum";
        numericUpDownSum.Size = new Size(260, 27);
        numericUpDownSum.TabIndex = 9;
        // 
        // labelDate
        // 
        labelDate.AutoSize = true;
        labelDate.Location = new Point(12, 218);
        labelDate.Name = "labelDate";
        labelDate.Size = new Size(140, 20);
        labelDate.TabIndex = 10;
        labelDate.Text = "Дата:";
        // 
        // dateTimePickerDate
        // 
        dateTimePickerDate.Enabled = false;
        dateTimePickerDate.Location = new Point(170, 215);
        dateTimePickerDate.Name = "dateTimePickerDate";
        dateTimePickerDate.Size = new Size(260, 27);
        dateTimePickerDate.TabIndex = 11;
        // 
        // buttonSave
        // 
        buttonSave.Location = new Point(60, 263);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(120, 34);
        buttonSave.TabIndex = 12;
        buttonSave.Text = "Сохранить";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += ButtonSave_Click;
        // 
        // buttonCancel
        // 
        buttonCancel.Location = new Point(260, 263);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(120, 34);
        buttonCancel.TabIndex = 13;
        buttonCancel.Text = "Отмена";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += ButtonCancel_Click;
        // 
        // FormSale
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(444, 313);
        Controls.Add(buttonCancel);
        Controls.Add(buttonSave);
        Controls.Add(dateTimePickerDate);
        Controls.Add(labelDate);
        Controls.Add(numericUpDownSum);
        Controls.Add(labelSum);
        Controls.Add(numericUpDownQuantity);
        Controls.Add(labelQuantity);
        Controls.Add(comboBoxFuel);
        Controls.Add(labelFuel);
        Controls.Add(comboBoxShift);
        Controls.Add(labelShift);
        Controls.Add(comboBoxSeller);
        Controls.Add(labelSeller);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormSale";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Продажа";
        ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDownSum).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelSeller;
    private ComboBox comboBoxSeller;
    private Label labelShift;
    private ComboBox comboBoxShift;
    private Label labelFuel;
    private ComboBox comboBoxFuel;
    private Label labelQuantity;
    private NumericUpDown numericUpDownQuantity;
    private Label labelSum;
    private NumericUpDown numericUpDownSum;
    private Label labelDate;
    private DateTimePicker dateTimePickerDate;
    private Button buttonSave;
    private Button buttonCancel;
}
