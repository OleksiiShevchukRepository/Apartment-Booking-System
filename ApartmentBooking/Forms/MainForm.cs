using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ApartmentBooking.Entities;
using ApartmentBooking.Repositories;
using System.Configuration;
using System.Data.SqlClient;
using ApartmentBooking.Repositories.Interfaces;
using ApartmentBooking.Repositories.Repositories;
using ApartmentBooking.UI.Code;

namespace ApartmentBooking.UI.Forms
{
    public partial class MainForm : Form
    {
        #region Private Members
        private readonly IPriceListRepository _priceListRepository;
        private readonly IRoomRepository _roomRepository;
        private readonly IBookingRepository _bookingRepository;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["DBBookings"].ConnectionString;

        #endregion

        #region Constructors

        public MainForm()
        {
            _priceListRepository = new SqlPriceListRepository(connectionString);
            _roomRepository = new SqlRoomRepository(connectionString);
            _bookingRepository = new SqlBookingRepository(connectionString);

            InitializeComponent();
        }

        #endregion

        #region Methods

        private void str_menu_item_NewOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
            if (orderForm.DialogResult == DialogResult.OK)
            {
                var firstName = orderForm.FirstName;
                var secondName = orderForm.SecondName;
                var dateIn = orderForm.DateIn;
                var dateOut = orderForm.DateOut;
                var roomNumber = orderForm.RoomNumber;

                try
                {
                    _bookingRepository.MakeOrder(firstName, secondName, roomNumber, dateIn, dateOut);
                    MessageBox.Show(string.Format("{0} {1} had been added to All Booking List", firstName, secondName));
                    str_menu_item_ShowAllOrders_Click(this, e);
                    orderForm.Close();
                }
                catch (SqlException exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(ArgumentNullException exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                str_menu_item_AllHotelRooms_Click(sender, e);

                var priceList = _priceListRepository.GetPriceList().ToList();
                var finalPriceList = from l in priceList
                                     select new { RoomType = l.TypeOfRoom, Rate = l.Rate, PlacesCount = l.PlacesCount };

                Text = string.Format("Apartment Booking: {0} {1}", CurrentUser.FirstName, CurrentUser.SecondName);
                dgv_PriceList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_PriceList.DataSource = finalPriceList.ToList();

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentNullException exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void str_menu_item_RoomInfo_Click(object sender, EventArgs e)
        {
            RoomNumberForm roomNumberForm = new RoomNumberForm();
            roomNumberForm.ShowDialog();

            if (roomNumberForm.DialogResult == DialogResult.OK)
            {
                Room resultRoom = null;
                string roomNumber = roomNumberForm.RoomNumber;
                try
                {
                    resultRoom = _roomRepository.GetRoomInformation(roomNumber);

                    if (resultRoom != null)
                    {
                        MessageBox.Show(string.Format("Number: {0}{4}Places Count: {1}{4}Rate: {2}{4}Type: {3}{4}",
                                resultRoom.Number, resultRoom.PlacesCount, resultRoom.Rate,
                                resultRoom.RoomType.TypeOfRoom, Environment.NewLine),
                                string.Format("Room: {0}", resultRoom.Number), MessageBoxButtons.OK);
                    }
                }
                catch (SqlException exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentNullException exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void str_menu_item_AllHotelRooms_Click(object sender, EventArgs e)
        {
            try
            {
                var list = _roomRepository.GetAllRooms();
                var roomList = from l in list
                               select new
                               {
                                   Number = l.Number,
                                   Places = l.PlacesCount,
                                   Rate = l.Rate,
                                   TypeOfRoom = l.RoomType.TypeOfRoom
                               };

                dgv_Info.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_Info.DataSource = roomList.ToList();
                lbl_Info.Text = "All Hotel Rooms";
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void str_menu_item_AllAvailableRooms_Click(object sender, EventArgs e)
        {
            DateForm dateForm = new DateForm();
            dateForm.ShowDialog();

            if (dateForm.DialogResult == DialogResult.OK)
            {
                DateTime date = dateForm.Date;
                try
                {
                    var roomList = _roomRepository.GetAvailableRoomsByDate(date);
                    var resultRoomList = from l in roomList
                                         select new { Number = l.Number, RoomType = l.RoomType.TypeOfRoom, RoomCount = l.RoomType.RoomCount };

                    lbl_Info.Text = string.Format("All available rooms at: {0}", date.ToShortDateString());
                    dgv_Info.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dgv_Info.DataSource = resultRoomList.ToList();
                }
                catch (SqlException exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentNullException exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void str_menu_item_ShowAllOrders_Click(object sender, EventArgs e)
        {
            try
            {
                var list = _bookingRepository.GetAllBookings();
                var resultList = from l in list
                                 select new
                                 {
                                     FirstName = l.Guest.FirstName,
                                     SecondName = l.Guest.SecondName,
                                     Number = l.Room.Number,
                                     DateIn = l.DateIn.ToShortDateString(),
                                     DateOut = l.DateOut.ToShortDateString(),
                                     Cost = l.Cost
                                 };

                dgv_Info.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_Info.DataSource = resultList.ToList();
                lbl_Info.Text = "All Orders";
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void str_menu_item_ExtendOrder_Click(object sender, EventArgs e)
        {
            ExtendOrderForm extendOrderForm = new ExtendOrderForm();
            extendOrderForm.ShowDialog();

            if (extendOrderForm.DialogResult == DialogResult.OK)
            {
                var roomNumber = extendOrderForm.RoomNumber;
                var newDateOut = extendOrderForm.NewDateOut;
                var guestFirstName = extendOrderForm.FirstName;
                var guestSecondName = extendOrderForm.SecondName;

                try
                {
                    _bookingRepository.ExtendOrder(roomNumber, newDateOut, guestFirstName, guestSecondName);
                    str_menu_item_ShowAllOrders_Click(this, e);
                }
                catch (SqlException exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentNullException exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       
        #endregion
    }
}
