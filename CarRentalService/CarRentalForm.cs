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
            _context.Fines.Load();

            carBindingSource.DataSource = _context.Cars.Local.ToBindingList();
            clientBindingSource.DataSource = _context.Clients.Local.ToBindingList();
            reservationBindingSource.DataSource = _context.Reservations.Local.ToBindingList();
            fineBindingSource.DataSource = _context.Fines.Local.ToBindingList();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            dataGridView1.Refresh();
        }

        private void saveClientButton_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            dataGridView3.Refresh();
        }

        private void saveReservationButton_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            dataGridView2.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            dataGridView4.Refresh();
        }
    }
}
