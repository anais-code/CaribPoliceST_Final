namespace CaribPoliceST

{
    public partial class Home : Form
    {
        private LoginForm loginForm;
        
        public Home()
        {
            InitializeComponent();
            loginForm = new LoginForm();
            loginForm.TopLevel = false; // Set the login form as non-top-level
            loginForm.FormBorderStyle = FormBorderStyle.None; // Remove border from the login form
            loginForm.Dock = DockStyle.Fill; // Dock the login form to fill the panel
            LoginPanel.Controls.Add(loginForm); // Add the login form to the loginPanel

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = true;
        }
    }
}
