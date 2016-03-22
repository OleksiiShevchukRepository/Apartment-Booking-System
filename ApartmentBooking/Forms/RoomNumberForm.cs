using System;
using System.Windows.Forms;

namespace ApartmentBooking.UI.Forms
{
    public partial class RoomNumberForm : Form
    {
        #region Members

        public string RoomNumber { get; set; }

        #endregion

        #region Constructors

        public RoomNumberForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void btn_OK_Click(object sender, EventArgs e)
        {
            RoomNumber = txt_RoomNumber.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        #endregion
    }
}
