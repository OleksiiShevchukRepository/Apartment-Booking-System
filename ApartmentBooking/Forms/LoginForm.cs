using System;
using System.Windows.Forms;
using ApartmentBooking.Entities;
using System.Configuration;
using System.Data.SqlClient;
using ApartmentBooking.Repositories.Interfaces;
using ApartmentBooking.Repositories.Repositories;
using ApartmentBooking.UI.Code;

namespace ApartmentBooking.UI.Forms
{
    public partial class LoginForm : Form
    {
        #region Members

        private readonly IUserRepository _userRepository;

        #endregion

        #region Constructors

        public LoginForm()
        {
            _userRepository = new SqlUserRepository(
                ConfigurationManager.ConnectionStrings["DBBookings"].ConnectionString);
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string login = txt_Login.Text;
            User loggedUser = null;
            string password = txt_Password.Text;
            try
            {
                loggedUser = _userRepository.GetUserByLogin(login, password);
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (loggedUser != null)
            {
                CurrentUser.Initialize(loggedUser);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Wrong name or password", "Authorization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }

        }

        #endregion
    }
}
