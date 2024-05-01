namespace SqlServerTest ;

    public partial class MainPage : ContentPage
    {
        private UserDbContext _context;

        public MainPage(UserDbContext dbContext)
        {
            InitializeComponent();
            _context = dbContext;
        }

        private void ShowDataClicked(object sender, EventArgs e)
        {
            try
            {
                var userList = _context.GetUsers().ToList();
                var text = userList.Aggregate("", (current, user) => current + (user.name + "\t" + user.email + "\n"));
                DisplayAlert("Alert", text, "done");
            }
            catch (Exception exception)
            {
                DisplayAlert("Alert", exception.Message, "done");
            }
        }

        private void AddDataClicked(object sender, EventArgs e)
        {
            try
            {
                var name = NameEntry.Text;
                var email = EmailEntry.Text;
                if (!string.IsNullOrEmpty(name) & !string.IsNullOrEmpty(email))
                {
                    _context.AddUser(new User{name = name, email = email});
                }
                DisplayAlert("Alert", "Added successfully", "done");
                NameEntry.Text = "";
                EmailEntry.Text = "";

            }
            catch (Exception exception)
            {
                DisplayAlert("Alert", exception.Message, "done");
            }
        }
    }