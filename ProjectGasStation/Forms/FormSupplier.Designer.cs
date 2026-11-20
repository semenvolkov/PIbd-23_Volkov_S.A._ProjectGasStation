namespace ProjectGasStation.Forms;

partial class FormSupplier
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
        labelPhone = new Label();
        textBoxPhone = new TextBox();
        labelAddress = new Label();
        textBoxAddress = new TextBox();
        buttonSave = new Button();
        buttonCancel = new Button();
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
        // labelPhone
        // 
        labelPhone.AutoSize = true;
        labelPhone.Location = new Point(12, 58);
        labelPhone.Name = "labelPhone";
        labelPhone.Size = new Size(140, 20);
        labelPhone.TabIndex = 2;
        labelPhone.Text = "Телефон:";
        // 
        // textBoxPhone
        // 
        textBoxPhone.Location = new Point(170, 55);
        textBoxPhone.Name = "textBoxPhone";
        textBoxPhone.Size = new Size(260, 27);
        textBoxPhone.TabIndex = 3;
        // 
        // labelAddress
        // 
        labelAddress.AutoSize = true;
        labelAddress.Location = new Point(12, 98);
        labelAddress.Name = "labelAddress";
        labelAddress.Size = new Size(140, 20);
        labelAddress.TabIndex = 4;
        labelAddress.Text = "Адрес:";
        // 
        // textBoxAddress
        // 
        textBoxAddress.Location = new Point(170, 95);
        textBoxAddress.Multiline = true;
        textBoxAddress.Name = "textBoxAddress";
        textBoxAddress.Size = new Size(260, 70);
        textBoxAddress.TabIndex = 5;
        // 
        // buttonSave
        // 
        buttonSave.Location = new Point(60, 185);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(120, 34);
        buttonSave.TabIndex = 6;
        buttonSave.Text = "Сохранить";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += ButtonSave_Click;
        // 
        // buttonCancel
        // 
        buttonCancel.Location = new Point(260, 185);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(120, 34);
        buttonCancel.TabIndex = 7;
        buttonCancel.Text = "Отмена";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += ButtonCancel_Click;
        // 
        // FormSupplier
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(444, 235);
        Controls.Add(buttonCancel);
        Controls.Add(buttonSave);
        Controls.Add(textBoxAddress);
        Controls.Add(labelAddress);
        Controls.Add(textBoxPhone);
        Controls.Add(labelPhone);
        Controls.Add(textBoxName);
        Controls.Add(labelName);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormSupplier";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Поставщик";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelName;
    private TextBox textBoxName;
    private Label labelPhone;
    private TextBox textBoxPhone;
    private Label labelAddress;
    private TextBox textBoxAddress;
    private Button buttonSave;
    private Button buttonCancel;
}
