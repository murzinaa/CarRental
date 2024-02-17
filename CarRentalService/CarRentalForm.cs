using CarRentalService.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace CarRentalService
{
    public partial class CarRentalForm : Form
    {
        private CarRentalContext _context;

        public CarRentalForm()
        {
            InitializeComponent();
        }

        private void CarRentalForm_Load_1(object sender, EventArgs e)
        {
            _context = new CarRentalContext();
            _context.Database.EnsureCreated();
            _context.Reservations.Load();

        }

        private void carTabPage_Click(object sender, EventArgs e)
        {
            _context.Cars.Load();
            // dataGridView1.Columns..DataSource = context.Cars.Local.ToBindingList();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            dataGridView1.Refresh();
        }
    }
}
