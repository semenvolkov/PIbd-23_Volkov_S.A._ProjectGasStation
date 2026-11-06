using ProjectGasStation.Repositories;
using Unity;

namespace ProjectGasStation.Forms;

public partial class FormSales : Form
{
    private readonly IUnityContainer _container;

    private readonly ISaleRepository _saleRepository;

    public FormSales(IUnityContainer container, ISaleRepository saleRepository)
    {
        InitializeComponent();
        _container = container ??
            throw new ArgumentNullException(nameof(container));
        _saleRepository = saleRepository ??
            throw new ArgumentNullException(nameof(saleRepository));
    }

    private void FormSales_Load(object sender, EventArgs e)
    {
        try
        {
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonAdd_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormSale>().ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadList() => dataGridViewData.DataSource = _saleRepository.ReadSales();
}
