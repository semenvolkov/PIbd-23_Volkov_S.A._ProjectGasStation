namespace ProjectGasStation.Forms;

partial class FormFuel
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
        labelName = new Label();
        textBoxName = new TextBox();
        labelFuelType = new Label();
        comboBoxFuelType = new ComboBox();
        labelPrice = new Label();
        numericUpDownPrice = new NumericUpDown();
        buttonSave = new Button();
        buttonCancel = new Button();
        ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
        SuspendLayout();
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Location = new Point(12, 18);
        labelName.Name = "labelName";
        labelName.Size = new Size(140, 20);
        labelName.TabIndex = 0;
        labelName.Text = "Название:";
        // 
        // textBoxName
        // 
        textBoxName.Location = new Point(170, 15);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(260, 27);
        textBoxName.TabIndex = 1;
        // 
        // labelFuelType
        // 
        labelFuelType.AutoSize = true;
        labelFuelType.Location = new Point(12, 58);
        labelFuelType.Name = "labelFuelType";
        labelFuelType.Size = new Size(140, 20);
        labelFuelType.TabIndex = 2;
        labelFuelType.Text = "Вид ГСМ:";
        // 
        // comboBoxFuelType
        // 
        comboBoxFuelType.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxFuelType.FormattingEnabled = true;
        comboBoxFuelType.Location = new Point(170, 55);
        comboBoxFuelType.Name = "comboBoxFuelType";
        comboBoxFuelType.Size = new Size(260, 28);
        comboBoxFuelType.TabIndex = 3;
        // 
        // labelPrice
        // 
        labelPrice.AutoSize = true;
        labelPrice.Location = new Point(12, 98);
        labelPrice.Name = "labelPrice";
        labelPrice.Size = new Size(140, 20);
        labelPrice.TabIndex = 4;
        labelPrice.Text = "Цена за ед., руб.:";
        // 
        // numericUpDownPrice
        // 
        numericUpDownPrice.DecimalPlaces = 2;
        numericUpDownPrice.Location = new Point(170, 95);
        numericUpDownPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        numericUpDownPrice.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
        numericUpDownPrice.Name = "numericUpDownPrice";
        numericUpDownPrice.Size = new Size(260, 27);
        numericUpDownPrice.TabIndex = 5;
        numericUpDownPrice.Value = new decimal(new int[] { 1, 0, 0, 131072 });
        // 
        // buttonSave
        // 
        buttonSave.Location = new Point(60, 143);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(120, 34);
        buttonSave.TabIndex = 6;
        buttonSave.Text = "Сохранить";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += ButtonSave_Click;
        // 
        // buttonCancel
        // 
        buttonCancel.Location = new Point(260, 143);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(120, 34);
        buttonCancel.TabIndex = 7;
        buttonCancel.Text = "Отмена";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += ButtonCancel_Click;
        // 
        // FormFuel
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(444, 193);
        Controls.Add(buttonCancel);
        Controls.Add(buttonSave);
        Controls.Add(numericUpDownPrice);
        Controls.Add(labelPrice);
        Controls.Add(comboBoxFuelType);
        Controls.Add(labelFuelType);
        Controls.Add(textBoxName);
        Controls.Add(labelName);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormFuel";
        StartPosition = FormStartPosition.CenterParent;
        Text = "ГСМ";
        ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelName;
    private TextBox textBoxName;
    private Label labelFuelType;
    private ComboBox comboBoxFuelType;
    private Label labelPrice;
    private NumericUpDown numericUpDownPrice;
    private Button buttonSave;
    private Button buttonCancel;
}
