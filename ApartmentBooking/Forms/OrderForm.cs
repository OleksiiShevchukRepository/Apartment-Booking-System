using System;
using System.Windows.Forms;

namespace ApartmentBooking.UI.Forms
{
    public partial class OrderForm : Form
    {
        #region Members

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        public string RoomNumber { get; set; }


        #endregion

        #region Constructors

        public OrderForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void btn_MakeOrder_Click(object sender, EventArgs e)
        {
            FirstName = txt_FirstName.Text;
            SecondName = txt_LastName.Text;
            RoomNumber = txt_RoomNumber.Text;
            DateIn = dtp_DateIn.Value;
            DateOut = dtp_DateOut.Value;
            DialogResult = DialogResult.OK;

           // Close();
        }

        #endregion
    }
}
