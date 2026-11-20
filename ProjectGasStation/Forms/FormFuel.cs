using ProjectGasStation.Entities;
using ProjectGasStation.Entities.Enums;
using ProjectGasStation.Repositories;

namespace ProjectGasStation.Forms;

public partial class FormFuel : Form
{
    private readonly IFuelRepository _fuelRepository;

    private int? _fuelId;

    public int Id
    {
        set
        {
            try
            {
                var fuel = _fuelRepository.ReadFuelById(value);
                if (fuel == null)
                {
                    throw new InvalidDataException(nameof(fuel));
                }

                textBoxName.Text = fuel.Name;
                comboBoxFuelType.SelectedItem = fuel.FuelType;
                numericUpDownPrice.Value = (decimal)fuel.Price;
                _fuelId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }

    public FormFuel(IFuelRepository fuelRepository)
    {
        InitializeComponent();
        _fuelRepository = fuelRepository ??
            throw new ArgumentNullException(nameof(fuelRepository));
        comboBoxFuelType.DataSource = Enum.GetValues(typeof(FuelType));
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                comboBoxFuelType.SelectedIndex < 1)
            {
                throw new Exception("Имеются незаполненные поля");
            }

            if (_fuelId.HasValue)
            {
                _fuelRepository.UpdateFuel(CreateFuel(_fuelId.Value));
            }
            else
            {
                _fuelRepository.CreateFuel(CreateFuel(0));
            }

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    private Fuel CreateFuel(int id) => Fuel.CreateEntity(id,
        textBoxName.Text,
        (FuelType)comboBoxFuelType.SelectedItem!,
        Convert.ToDouble(numericUpDownPrice.Value));
}
