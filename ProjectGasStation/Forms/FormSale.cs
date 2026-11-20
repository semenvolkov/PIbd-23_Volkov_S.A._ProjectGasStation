using ProjectGasStation.Entities;
using ProjectGasStation.Entities.Enums;
using ProjectGasStation.Repositories;

namespace ProjectGasStation.Forms;

public partial class FormSale : Form
{
    private readonly ISaleRepository _saleRepository;

    public FormSale(ISaleRepository saleRepository, ISellerRepository sellerRepository, IFuelRepository fuelRepository)
    {
        InitializeComponent();
        _saleRepository = saleRepository ??
            throw new ArgumentNullException(nameof(saleRepository));

        comboBoxSeller.DataSource = sellerRepository.ReadSellers();
        comboBoxSeller.DisplayMember = "LastName";
        comboBoxSeller.ValueMember = "Id";

        comboBoxFuel.DataSource = fuelRepository.ReadFuels();
        comboBoxFuel.DisplayMember = "Name";
        comboBoxFuel.ValueMember = "Id";

        comboBoxShift.DataSource = Enum.GetValues(typeof(ShiftType));
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (comboBoxSeller.SelectedIndex < 0 ||
                comboBoxShift.SelectedIndex < 1 ||
                comboBoxFuel.SelectedIndex < 0)
            {
                throw new Exception("Имеются незаполненные поля");
            }

            var seller = (Seller)comboBoxSeller.SelectedItem!;
            var fuel = (Fuel)comboBoxFuel.SelectedItem!;
            if ((seller.AllowedFuelTypes & fuel.FuelType) == 0)
            {
                throw new Exception("Продавец не допущен к продаже выбранного вида ГСМ");
            }

            _saleRepository.CreateSale(Sale.CreateOperation(0,
                seller.Id,
                fuel.Id,
                (ShiftType)comboBoxShift.SelectedItem!,
                Convert.ToDouble(numericUpDownQuantity.Value),
                Convert.ToDouble(numericUpDownSum.Value)));
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    private void ComboBoxFuel_SelectedIndexChanged(object sender, EventArgs e) => CalculateSum();

    private void NumericUpDownQuantity_ValueChanged(object sender, EventArgs e) => CalculateSum();

    private void CalculateSum()
    {
        if (comboBoxFuel.SelectedItem is not Fuel fuel)
        {
            numericUpDownSum.Value = 0;
            return;
        }

        numericUpDownSum.Value = Math.Min(numericUpDownSum.Maximum, (decimal)fuel.Price * numericUpDownQuantity.Value);
    }
}
