using CarRentalService.DataAccess;

namespace CarRentalService
{
    public partial class CarRentalForm : Form
    {
        public CarRentalForm()
        {
            InitializeComponent();
        }

        private void CarRentalForm_Load_1(object sender, EventArgs e)
        {
            using (var context = new CarRentalContext())
            {
                context.Database.EnsureCreated();
                
                // dataGridView1.DataSource = authors;
            }
        }
    }
}
