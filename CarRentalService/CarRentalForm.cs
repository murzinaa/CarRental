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
            _context.Cars.Load();
            _context.Clients.Load();

            carBindingSource.DataSource = _context.Cars.Local.ToBindingList();
            clientBindingSource.DataSource = _context.Clients.Local.ToBindingList();
            reservationBindingSource.DataSource = _context.Reservations.Local.ToBindingList();
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            dataGridView1.Refresh();
        }
    }
}
