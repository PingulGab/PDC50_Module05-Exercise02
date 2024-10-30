using Module07DataAccess.Services;
using MySql.Data.MySqlClient;

namespace Module07DataAccess

{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        private readonly DatabaseConnectionService _dbConnectionService;

        public MainPage()
        {
            InitializeComponent();

            //Initialize Database Connection
            _dbConnectionService = new DatabaseConnectionService();

        }
        private async void OnViewEmployeePageClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//EmployeePage");
        }
        /* private async void OnTestConnectionClicked (object sender, EventArgs e)
        {
            var connectionString = _dbConnectionService.GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    ConnectionStatusLabel.Text = "Connection " +
                        "Success!";
                    ConnectionStatusLabel.TextColor = Colors.Green;
                }
            }
            catch (Exception ex)
            {
                ConnectionStatusLabel.Text = $"Connection Failed: {ex.Message}";
                ConnectionStatusLabel.TextColor = Colors.Red;

            }
        } */


    }

}
