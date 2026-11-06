using ProjectGasStation.Entities;
using ProjectGasStation.Entities.Enums;
using ProjectGasStation.Repositories;

namespace ProjectGasStation.Forms;

public partial class FormSeller : Form
{
    private readonly ISellerRepository _sellerRepository;

    private int? _sellerId;

    public int Id
    {
        set
        {
            try
            {
                var seller = _sellerRepository.ReadSellerById(value);
                if (seller == null)
                {
                    throw new InvalidDataException(nameof(seller));
                }

                textBoxLastName.Text = seller.LastName;
                textBoxFirstName.Text = seller.FirstName;
                comboBoxPost.SelectedItem = seller.SellerPost;
                foreach (FuelType elem in Enum.GetValues(typeof(FuelType)))
                {
                    if ((elem & seller.AllowedFuelTypes) != 0)
                    {
                        checkedListBoxFuelTypes.SetItemChecked(checkedListBoxFuelTypes.Items.IndexOf(elem), true);
                    }
                }

                _sellerId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }

    public FormSeller(ISellerRepository sellerRepository)
    {
        InitializeComponent();
        _sellerRepository = sellerRepository ??
            throw new ArgumentNullException(nameof(sellerRepository));
        comboBoxPost.DataSource = Enum.GetValues(typeof(SellerPost));
        foreach (FuelType elem in Enum.GetValues(typeof(FuelType)))
        {
            if (elem != FuelType.None)
            {
                checkedListBoxFuelTypes.Items.Add(elem);
            }
        }
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                comboBoxPost.SelectedIndex < 1 ||
                checkedListBoxFuelTypes.CheckedItems.Count == 0)
            {
                throw new Exception("Имеются незаполненные поля");
            }

            if (_sellerId.HasValue)
            {
                _sellerRepository.UpdateSeller(CreateSeller(_sellerId.Value));
            }
            else
            {
                _sellerRepository.CreateSeller(CreateSeller(0));
            }

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    private Seller CreateSeller(int id)
    {
        var allowedFuelTypes = FuelType.None;
        foreach (var elem in checkedListBoxFuelTypes.CheckedItems)
        {
            allowedFuelTypes |= (FuelType)elem;
        }

        return Seller.CreateEntity(id,
            textBoxFirstName.Text,
            textBoxLastName.Text,
            (SellerPost)comboBoxPost.SelectedItem!,
            allowedFuelTypes);
    }
}
