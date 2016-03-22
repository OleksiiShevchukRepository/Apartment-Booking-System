using System;
using System.Windows.Forms;

namespace ApartmentBooking.UI.Forms
{
    public partial class ExtendOrderForm : Form
    {
        #region Members

        public string RoomNumber { get; set; }
        public DateTime NewDateOut { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        #endregion

        #region Constructors

        public ExtendOrderForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void btn_OK_Click(object sender, EventArgs e)
        {
            RoomNumber = txt_RoomNumber.Text;
            NewDateOut = dtp_NewDateOut.Value;
            FirstName = txt_FirstName.Text;
            SecondName = txt_SecondName.Text;
            DialogResult = DialogResult.OK;

            Close();
        }

        #endregion
    }
}
