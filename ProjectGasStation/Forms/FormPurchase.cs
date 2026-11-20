using ProjectGasStation.Entities;
using ProjectGasStation.Repositories;

namespace ProjectGasStation.Forms;

public partial class FormPurchase : Form
{
    private readonly IPurchaseRepository _purchaseRepository;

    public FormPurchase(IPurchaseRepository purchaseRepository, ISupplierRepository supplierRepository, IFuelRepository fuelRepository)
    {
        InitializeComponent();
        _purchaseRepository = purchaseRepository ??
            throw new ArgumentNullException(nameof(purchaseRepository));

        comboBoxSupplier.DataSource = supplierRepository.ReadSuppliers();
        comboBoxSupplier.DisplayMember = "Name";
        comboBoxSupplier.ValueMember = "Id";

        ColumnFuel.DataSource = fuelRepository.ReadFuels();
        ColumnFuel.DisplayMember = "Name";
        ColumnFuel.ValueMember = "Id";
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            var fuelPurchases = CreateListFuelPurchasesFromDataGrid();
            if (comboBoxSupplier.SelectedIndex < 0 ||
                fuelPurchases.Count == 0)
            {
                throw new Exception("Имеются незаполненные поля");
            }

            _purchaseRepository.CreatePurchase(Purchase.CreateOperation(0,
                (int)comboBoxSupplier.SelectedValue!,
                fuelPurchases));
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    private List<FuelPurchase> CreateListFuelPurchasesFromDataGrid()
    {
        var list = new List<FuelPurchase>();
        foreach (DataGridViewRow row in dataGridViewFuels.Rows)
        {
            if (row.Cells["ColumnFuel"].Value == null ||
                row.Cells["ColumnQuantity"].Value == null ||
                row.Cells["ColumnPrice"].Value == null)
            {
                continue;
            }

            list.Add(FuelPurchase.CreateElement(0,
                Convert.ToInt32(row.Cells["ColumnFuel"].Value),
                Convert.ToDouble(row.Cells["ColumnQuantity"].Value),
                Convert.ToDouble(row.Cells["ColumnPrice"].Value)));
        }

        return list;
    }
}
