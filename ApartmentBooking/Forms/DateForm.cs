using System;
using System.Windows.Forms;

namespace ApartmentBooking.UI.Forms
{
    public partial class DateForm : Form
    {
        #region Members

        public DateTime Date { get; set; }

        #endregion

        #region Constructors

        public DateForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Date = dtp_CheckingDate.Value;
            DialogResult = DialogResult.OK;

            Close();
        }

        #endregion
    }
}
