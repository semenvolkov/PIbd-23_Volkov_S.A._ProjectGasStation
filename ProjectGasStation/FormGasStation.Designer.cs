namespace ProjectGasStation;

partial class FormGasStation
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        menuStrip = new MenuStrip();
        directoriesToolStripMenuItem = new ToolStripMenuItem();
        fuelsToolStripMenuItem = new ToolStripMenuItem();
        sellersToolStripMenuItem = new ToolStripMenuItem();
        suppliersToolStripMenuItem = new ToolStripMenuItem();
        operationsToolStripMenuItem = new ToolStripMenuItem();
        salesToolStripMenuItem = new ToolStripMenuItem();
        purchasesToolStripMenuItem = new ToolStripMenuItem();
        reportsToolStripMenuItem = new ToolStripMenuItem();
        menuStrip.SuspendLayout();
        SuspendLayout();
        //
        // menuStrip
        //
        menuStrip.ImageScalingSize = new Size(20, 20);
        menuStrip.Items.AddRange(new ToolStripItem[] { directoriesToolStripMenuItem, operationsToolStripMenuItem, reportsToolStripMenuItem });
        menuStrip.Location = new Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Size = new Size(800, 28);
        menuStrip.TabIndex = 0;
        menuStrip.Text = "menuStrip";
        //
        // directoriesToolStripMenuItem
        //
        directoriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fuelsToolStripMenuItem, sellersToolStripMenuItem, suppliersToolStripMenuItem });
        directoriesToolStripMenuItem.Name = "directoriesToolStripMenuItem";
        directoriesToolStripMenuItem.Size = new Size(117, 24);
        directoriesToolStripMenuItem.Text = "Справочники";
        //
        // fuelsToolStripMenuItem
        //
        fuelsToolStripMenuItem.Name = "fuelsToolStripMenuItem";
        fuelsToolStripMenuItem.Size = new Size(224, 26);
        fuelsToolStripMenuItem.Text = "ГСМ";
        fuelsToolStripMenuItem.Click += FuelsToolStripMenuItem_Click;
        //
        // sellersToolStripMenuItem
        //
        sellersToolStripMenuItem.Name = "sellersToolStripMenuItem";
        sellersToolStripMenuItem.Size = new Size(224, 26);
        sellersToolStripMenuItem.Text = "Продавцы";
        sellersToolStripMenuItem.Click += SellersToolStripMenuItem_Click;
        //
        // suppliersToolStripMenuItem
        //
        suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
        suppliersToolStripMenuItem.Size = new Size(224, 26);
        suppliersToolStripMenuItem.Text = "Поставщики";
        suppliersToolStripMenuItem.Click += SuppliersToolStripMenuItem_Click;
        //
        // operationsToolStripMenuItem
        //
        operationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salesToolStripMenuItem, purchasesToolStripMenuItem });
        operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
        operationsToolStripMenuItem.Size = new Size(95, 24);
        operationsToolStripMenuItem.Text = "Операции";
        //
        // salesToolStripMenuItem
        //
        salesToolStripMenuItem.Name = "salesToolStripMenuItem";
        salesToolStripMenuItem.Size = new Size(224, 26);
        salesToolStripMenuItem.Text = "Продажи";
        salesToolStripMenuItem.Click += SalesToolStripMenuItem_Click;
        //
        // purchasesToolStripMenuItem
        //
        purchasesToolStripMenuItem.Name = "purchasesToolStripMenuItem";
        purchasesToolStripMenuItem.Size = new Size(224, 26);
        purchasesToolStripMenuItem.Text = "Закупки у поставщиков";
        purchasesToolStripMenuItem.Click += PurchasesToolStripMenuItem_Click;
        //
        // reportsToolStripMenuItem
        //
        reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
        reportsToolStripMenuItem.Size = new Size(73, 24);
        reportsToolStripMenuItem.Text = "Отчеты";
        //
        // FormGasStation
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(menuStrip);
        MainMenuStrip = menuStrip;
        Name = "FormGasStation";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Учет топлива на АЗС";
        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip;
    private ToolStripMenuItem directoriesToolStripMenuItem;
    private ToolStripMenuItem fuelsToolStripMenuItem;
    private ToolStripMenuItem sellersToolStripMenuItem;
    private ToolStripMenuItem suppliersToolStripMenuItem;
    private ToolStripMenuItem operationsToolStripMenuItem;
    private ToolStripMenuItem salesToolStripMenuItem;
    private ToolStripMenuItem purchasesToolStripMenuItem;
    private ToolStripMenuItem reportsToolStripMenuItem;
}
