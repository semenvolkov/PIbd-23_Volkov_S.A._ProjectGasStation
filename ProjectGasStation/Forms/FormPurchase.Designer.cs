namespace ProjectGasStation.Forms;

partial class FormPurchase
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
        labelSupplier = new Label();
        comboBoxSupplier = new ComboBox();
        labelDate = new Label();
        dateTimePickerDate = new DateTimePicker();
        groupBoxFuels = new GroupBox();
        dataGridViewFuels = new DataGridView();
        ColumnFuel = new DataGridViewComboBoxColumn();
        ColumnQuantity = new DataGridViewTextBoxColumn();
        ColumnPrice = new DataGridViewTextBoxColumn();
        buttonSave = new Button();
        buttonCancel = new Button();
        groupBoxFuels.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewFuels).BeginInit();
        SuspendLayout();
        // 
        // labelSupplier
        // 
        labelSupplier.AutoSize = true;
        labelSupplier.Location = new Point(12, 18);
        labelSupplier.Name = "labelSupplier";
        labelSupplier.Size = new Size(140, 20);
        labelSupplier.TabIndex = 0;
        labelSupplier.Text = "Поставщик:";
        // 
        // comboBoxSupplier
        // 
        comboBoxSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxSupplier.FormattingEnabled = true;
        comboBoxSupplier.Location = new Point(170, 15);
        comboBoxSupplier.Name = "comboBoxSupplier";
        comboBoxSupplier.Size = new Size(260, 28);
        comboBoxSupplier.TabIndex = 1;
        // 
        // labelDate
        // 
        labelDate.AutoSize = true;
        labelDate.Location = new Point(12, 58);
        labelDate.Name = "labelDate";
        labelDate.Size = new Size(140, 20);
        labelDate.TabIndex = 2;
        labelDate.Text = "Дата:";
        // 
        // dateTimePickerDate
        // 
        dateTimePickerDate.Enabled = false;
        dateTimePickerDate.Location = new Point(170, 55);
        dateTimePickerDate.Name = "dateTimePickerDate";
        dateTimePickerDate.Size = new Size(260, 27);
        dateTimePickerDate.TabIndex = 3;
        // 
        // groupBoxFuels
        // 
        groupBoxFuels.Controls.Add(dataGridViewFuels);
        groupBoxFuels.Location = new Point(12, 95);
        groupBoxFuels.Name = "groupBoxFuels";
        groupBoxFuels.Size = new Size(418, 260);
        groupBoxFuels.TabIndex = 4;
        groupBoxFuels.TabStop = false;
        groupBoxFuels.Text = "ГСМ";
        // 
        // dataGridViewFuels
        // 
        dataGridViewFuels.AllowUserToResizeColumns = false;
        dataGridViewFuels.AllowUserToResizeRows = false;
        dataGridViewFuels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewFuels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewFuels.Columns.AddRange(new DataGridViewColumn[] { ColumnFuel, ColumnQuantity, ColumnPrice });
        dataGridViewFuels.Dock = DockStyle.Fill;
        dataGridViewFuels.Location = new Point(3, 23);
        dataGridViewFuels.MultiSelect = false;
        dataGridViewFuels.Name = "dataGridViewFuels";
        dataGridViewFuels.RowHeadersWidth = 51;
        dataGridViewFuels.Size = new Size(412, 234);
        dataGridViewFuels.TabIndex = 0;
        // 
        // ColumnFuel
        // 
        ColumnFuel.HeaderText = "ГСМ";
        ColumnFuel.MinimumWidth = 6;
        ColumnFuel.Name = "ColumnFuel";
        // 
        // ColumnQuantity
        // 
        ColumnQuantity.HeaderText = "Количество";
        ColumnQuantity.MinimumWidth = 6;
        ColumnQuantity.Name = "ColumnQuantity";
        // 
        // ColumnPrice
        // 
        ColumnPrice.HeaderText = "Цена за ед., руб.";
        ColumnPrice.MinimumWidth = 6;
        ColumnPrice.Name = "ColumnPrice";
        // 
        // buttonSave
        // 
        buttonSave.Location = new Point(60, 375);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(120, 34);
        buttonSave.TabIndex = 5;
        buttonSave.Text = "Сохранить";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += ButtonSave_Click;
        // 
        // buttonCancel
        // 
        buttonCancel.Location = new Point(260, 375);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(120, 34);
        buttonCancel.TabIndex = 6;
        buttonCancel.Text = "Отмена";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += ButtonCancel_Click;
        // 
        // FormPurchase
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(444, 425);
        Controls.Add(buttonCancel);
        Controls.Add(buttonSave);
        Controls.Add(groupBoxFuels);
        Controls.Add(dateTimePickerDate);
        Controls.Add(labelDate);
        Controls.Add(comboBoxSupplier);
        Controls.Add(labelSupplier);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormPurchase";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Закупка у поставщика";
        groupBoxFuels.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridViewFuels).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelSupplier;
    private ComboBox comboBoxSupplier;
    private Label labelDate;
    private DateTimePicker dateTimePickerDate;
    private GroupBox groupBoxFuels;
    private DataGridView dataGridViewFuels;
    private DataGridViewComboBoxColumn ColumnFuel;
    private DataGridViewTextBoxColumn ColumnQuantity;
    private DataGridViewTextBoxColumn ColumnPrice;
    private Button buttonSave;
    private Button buttonCancel;
}
