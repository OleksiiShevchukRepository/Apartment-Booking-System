namespace ApartmentBooking.UI.Forms
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_RoomNumber = new System.Windows.Forms.Label();
            this.lbl_DateIn = new System.Windows.Forms.Label();
            this.lbl_DateOut = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.dtp_DateIn = new System.Windows.Forms.DateTimePicker();
            this.dtp_DateOut = new System.Windows.Forms.DateTimePicker();
            this.txt_RoomNumber = new System.Windows.Forms.TextBox();
            this.btn_MakeOrder = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.gbx_MakeOrder = new System.Windows.Forms.GroupBox();
            this.gbx_MakeOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(6, 15);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(57, 13);
            this.lbl_FirstName.TabIndex = 0;
            this.lbl_FirstName.Text = "First Name";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(129, 15);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(58, 13);
            this.lbl_LastName.TabIndex = 1;
            this.lbl_LastName.Text = "Last Name";
            // 
            // lbl_RoomNumber
            // 
            this.lbl_RoomNumber.AutoSize = true;
            this.lbl_RoomNumber.Location = new System.Drawing.Point(252, 16);
            this.lbl_RoomNumber.Name = "lbl_RoomNumber";
            this.lbl_RoomNumber.Size = new System.Drawing.Size(75, 13);
            this.lbl_RoomNumber.TabIndex = 3;
            this.lbl_RoomNumber.Text = "Room Number";
            // 
            // lbl_DateIn
            // 
            this.lbl_DateIn.AutoSize = true;
            this.lbl_DateIn.Location = new System.Drawing.Point(6, 66);
            this.lbl_DateIn.Name = "lbl_DateIn";
            this.lbl_DateIn.Size = new System.Drawing.Size(42, 13);
            this.lbl_DateIn.TabIndex = 4;
            this.lbl_DateIn.Text = "Date In";
            // 
            // lbl_DateOut
            // 
            this.lbl_DateOut.AutoSize = true;
            this.lbl_DateOut.Location = new System.Drawing.Point(128, 65);
            this.lbl_DateOut.Name = "lbl_DateOut";
            this.lbl_DateOut.Size = new System.Drawing.Size(50, 13);
            this.lbl_DateOut.TabIndex = 5;
            this.lbl_DateOut.Text = "Date Out";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(9, 32);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(101, 20);
            this.txt_FirstName.TabIndex = 0;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(132, 32);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(101, 20);
            this.txt_LastName.TabIndex = 1;
            // 
            // dtp_DateIn
            // 
            this.dtp_DateIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateIn.Location = new System.Drawing.Point(9, 82);
            this.dtp_DateIn.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.dtp_DateIn.MinDate = new System.DateTime(2016, 3, 1, 0, 0, 0, 0);
            this.dtp_DateIn.Name = "dtp_DateIn";
            this.dtp_DateIn.Size = new System.Drawing.Size(102, 20);
            this.dtp_DateIn.TabIndex = 4;
            // 
            // dtp_DateOut
            // 
            this.dtp_DateOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateOut.Location = new System.Drawing.Point(132, 82);
            this.dtp_DateOut.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.dtp_DateOut.MinDate = new System.DateTime(2016, 3, 1, 0, 0, 0, 0);
            this.dtp_DateOut.Name = "dtp_DateOut";
            this.dtp_DateOut.Size = new System.Drawing.Size(101, 20);
            this.dtp_DateOut.TabIndex = 5;
            // 
            // txt_RoomNumber
            // 
            this.txt_RoomNumber.Location = new System.Drawing.Point(254, 32);
            this.txt_RoomNumber.Name = "txt_RoomNumber";
            this.txt_RoomNumber.Size = new System.Drawing.Size(102, 20);
            this.txt_RoomNumber.TabIndex = 3;
            // 
            // btn_MakeOrder
            // 
            this.btn_MakeOrder.Location = new System.Drawing.Point(222, 134);
            this.btn_MakeOrder.Name = "btn_MakeOrder";
            this.btn_MakeOrder.Size = new System.Drawing.Size(75, 23);
            this.btn_MakeOrder.TabIndex = 6;
            this.btn_MakeOrder.Text = "Make Order";
            this.btn_MakeOrder.UseVisualStyleBackColor = true;
            this.btn_MakeOrder.Click += new System.EventHandler(this.btn_MakeOrder_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(303, 134);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // gbx_MakeOrder
            // 
            this.gbx_MakeOrder.Controls.Add(this.txt_LastName);
            this.gbx_MakeOrder.Controls.Add(this.lbl_FirstName);
            this.gbx_MakeOrder.Controls.Add(this.lbl_LastName);
            this.gbx_MakeOrder.Controls.Add(this.txt_RoomNumber);
            this.gbx_MakeOrder.Controls.Add(this.lbl_RoomNumber);
            this.gbx_MakeOrder.Controls.Add(this.dtp_DateOut);
            this.gbx_MakeOrder.Controls.Add(this.lbl_DateIn);
            this.gbx_MakeOrder.Controls.Add(this.dtp_DateIn);
            this.gbx_MakeOrder.Controls.Add(this.lbl_DateOut);
            this.gbx_MakeOrder.Controls.Add(this.txt_FirstName);
            this.gbx_MakeOrder.Location = new System.Drawing.Point(12, 12);
            this.gbx_MakeOrder.Name = "gbx_MakeOrder";
            this.gbx_MakeOrder.Size = new System.Drawing.Size(366, 116);
            this.gbx_MakeOrder.TabIndex = 8;
            this.gbx_MakeOrder.TabStop = false;
            // 
            // OrderForm
            // 
            this.AcceptButton = this.btn_MakeOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(394, 164);
            this.Controls.Add(this.gbx_MakeOrder);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_MakeOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apartment Booking: Make Order";
            this.gbx_MakeOrder.ResumeLayout(false);
            this.gbx_MakeOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_RoomNumber;
        private System.Windows.Forms.Label lbl_DateIn;
        private System.Windows.Forms.Label lbl_DateOut;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_LastName;
        public System.Windows.Forms.DateTimePicker dtp_DateIn;
        public System.Windows.Forms.DateTimePicker dtp_DateOut;
        private System.Windows.Forms.TextBox txt_RoomNumber;
        private System.Windows.Forms.Button btn_MakeOrder;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.GroupBox gbx_MakeOrder;
    }
}