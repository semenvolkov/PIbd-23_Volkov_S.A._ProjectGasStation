namespace ProjectGasStation.Forms;

partial class FormSeller
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
        labelLastName = new Label();
        textBoxLastName = new TextBox();
        labelFirstName = new Label();
        textBoxFirstName = new TextBox();
        labelPost = new Label();
        comboBoxPost = new ComboBox();
        labelFuelTypes = new Label();
        checkedListBoxFuelTypes = new CheckedListBox();
        buttonSave = new Button();
        buttonCancel = new Button();
        SuspendLayout();
        // 
        // labelLastName
        // 
        labelLastName.AutoSize = true;
        labelLastName.Location = new Point(12, 18);
        labelLastName.Name = "labelLastName";
        labelLastName.Size = new Size(140, 20);
        labelLastName.TabIndex = 0;
        labelLastName.Text = "Фамилия:";
        // 
        // textBoxLastName
        // 
        textBoxLastName.Location = new Point(170, 15);
        textBoxLastName.Name = "textBoxLastName";
        textBoxLastName.Size = new Size(260, 27);
        textBoxLastName.TabIndex = 1;
        // 
        // labelFirstName
        // 
        labelFirstName.AutoSize = true;
        labelFirstName.Location = new Point(12, 58);
        labelFirstName.Name = "labelFirstName";
        labelFirstName.Size = new Size(140, 20);
        labelFirstName.TabIndex = 2;
        labelFirstName.Text = "Имя:";
        // 
        // textBoxFirstName
        // 
        textBoxFirstName.Location = new Point(170, 55);
        textBoxFirstName.Name = "textBoxFirstName";
        textBoxFirstName.Size = new Size(260, 27);
        textBoxFirstName.TabIndex = 3;
        // 
        // labelPost
        // 
        labelPost.AutoSize = true;
        labelPost.Location = new Point(12, 98);
        labelPost.Name = "labelPost";
        labelPost.Size = new Size(140, 20);
        labelPost.TabIndex = 4;
        labelPost.Text = "Должность:";
        // 
        // comboBoxPost
        // 
        comboBoxPost.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxPost.FormattingEnabled = true;
        comboBoxPost.Location = new Point(170, 95);
        comboBoxPost.Name = "comboBoxPost";
        comboBoxPost.Size = new Size(260, 28);
        comboBoxPost.TabIndex = 5;
        // 
        // labelFuelTypes
        // 
        labelFuelTypes.AutoSize = true;
        labelFuelTypes.Location = new Point(12, 138);
        labelFuelTypes.Name = "labelFuelTypes";
        labelFuelTypes.Size = new Size(140, 20);
        labelFuelTypes.TabIndex = 6;
        labelFuelTypes.Text = "Допущен к ГСМ:";
        // 
        // checkedListBoxFuelTypes
        // 
        checkedListBoxFuelTypes.CheckOnClick = true;
        checkedListBoxFuelTypes.FormattingEnabled = true;
        checkedListBoxFuelTypes.Location = new Point(170, 135);
        checkedListBoxFuelTypes.Name = "checkedListBoxFuelTypes";
        checkedListBoxFuelTypes.Size = new Size(260, 136);
        checkedListBoxFuelTypes.TabIndex = 7;
        // 
        // buttonSave
        // 
        buttonSave.Location = new Point(60, 291);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(120, 34);
        buttonSave.TabIndex = 8;
        buttonSave.Text = "Сохранить";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += ButtonSave_Click;
        // 
        // buttonCancel
        // 
        buttonCancel.Location = new Point(260, 291);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(120, 34);
        buttonCancel.TabIndex = 9;
        buttonCancel.Text = "Отмена";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += ButtonCancel_Click;
        // 
        // FormSeller
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(444, 341);
        Controls.Add(buttonCancel);
        Controls.Add(buttonSave);
        Controls.Add(checkedListBoxFuelTypes);
        Controls.Add(labelFuelTypes);
        Controls.Add(comboBoxPost);
        Controls.Add(labelPost);
        Controls.Add(textBoxFirstName);
        Controls.Add(labelFirstName);
        Controls.Add(textBoxLastName);
        Controls.Add(labelLastName);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormSeller";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Продавец";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelLastName;
    private TextBox textBoxLastName;
    private Label labelFirstName;
    private TextBox textBoxFirstName;
    private Label labelPost;
    private ComboBox comboBoxPost;
    private Label labelFuelTypes;
    private CheckedListBox checkedListBoxFuelTypes;
    private Button buttonSave;
    private Button buttonCancel;
}
