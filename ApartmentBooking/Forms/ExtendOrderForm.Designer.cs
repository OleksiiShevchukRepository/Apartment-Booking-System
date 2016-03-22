namespace ApartmentBooking.UI.Forms
{
    partial class ExtendOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtendOrderForm));
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_SecondName = new System.Windows.Forms.Label();
            this.lbl_RoomNumber = new System.Windows.Forms.Label();
            this.lbl_NewDateOut = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.txt_SecondName = new System.Windows.Forms.TextBox();
            this.txt_RoomNumber = new System.Windows.Forms.TextBox();
            this.dtp_NewDateOut = new System.Windows.Forms.DateTimePicker();
            this.gbx_ExtendOrder = new System.Windows.Forms.GroupBox();
            this.gbx_ExtendOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(3, 9);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(57, 13);
            this.lbl_FirstName.TabIndex = 0;
            this.lbl_FirstName.Text = "First Name";
            // 
            // lbl_SecondName
            // 
            this.lbl_SecondName.AutoSize = true;
            this.lbl_SecondName.Location = new System.Drawing.Point(127, 9);
            this.lbl_SecondName.Name = "lbl_SecondName";
            this.lbl_SecondName.Size = new System.Drawing.Size(75, 13);
            this.lbl_SecondName.TabIndex = 1;
            this.lbl_SecondName.Text = "Second Name";
            // 
            // lbl_RoomNumber
            // 
            this.lbl_RoomNumber.AutoSize = true;
            this.lbl_RoomNumber.Location = new System.Drawing.Point(3, 54);
            this.lbl_RoomNumber.Name = "lbl_RoomNumber";
            this.lbl_RoomNumber.Size = new System.Drawing.Size(75, 13);
            this.lbl_RoomNumber.TabIndex = 2;
            this.lbl_RoomNumber.Text = "Room Number";
            // 
            // lbl_NewDateOut
            // 
            this.lbl_NewDateOut.AutoSize = true;
            this.lbl_NewDateOut.Location = new System.Drawing.Point(127, 54);
            this.lbl_NewDateOut.Name = "lbl_NewDateOut";
            this.lbl_NewDateOut.Size = new System.Drawing.Size(75, 13);
            this.lbl_NewDateOut.TabIndex = 3;
            this.lbl_NewDateOut.Text = "New Date Out";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(99, 113);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(180, 113);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(6, 25);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(100, 20);
            this.txt_FirstName.TabIndex = 6;
            // 
            // txt_SecondName
            // 
            this.txt_SecondName.Location = new System.Drawing.Point(130, 25);
            this.txt_SecondName.Name = "txt_SecondName";
            this.txt_SecondName.Size = new System.Drawing.Size(100, 20);
            this.txt_SecondName.TabIndex = 7;
            // 
            // txt_RoomNumber
            // 
            this.txt_RoomNumber.Location = new System.Drawing.Point(6, 70);
            this.txt_RoomNumber.Name = "txt_RoomNumber";
            this.txt_RoomNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_RoomNumber.TabIndex = 8;
            // 
            // dtp_NewDateOut
            // 
            this.dtp_NewDateOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NewDateOut.Location = new System.Drawing.Point(130, 70);
            this.dtp_NewDateOut.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.dtp_NewDateOut.MinDate = new System.DateTime(2016, 3, 1, 0, 0, 0, 0);
            this.dtp_NewDateOut.Name = "dtp_NewDateOut";
            this.dtp_NewDateOut.Size = new System.Drawing.Size(100, 20);
            this.dtp_NewDateOut.TabIndex = 9;
            // 
            // gbx_ExtendOrder
            // 
            this.gbx_ExtendOrder.Controls.Add(this.txt_RoomNumber);
            this.gbx_ExtendOrder.Controls.Add(this.dtp_NewDateOut);
            this.gbx_ExtendOrder.Controls.Add(this.lbl_FirstName);
            this.gbx_ExtendOrder.Controls.Add(this.lbl_SecondName);
            this.gbx_ExtendOrder.Controls.Add(this.txt_SecondName);
            this.gbx_ExtendOrder.Controls.Add(this.lbl_RoomNumber);
            this.gbx_ExtendOrder.Controls.Add(this.txt_FirstName);
            this.gbx_ExtendOrder.Controls.Add(this.lbl_NewDateOut);
            this.gbx_ExtendOrder.Location = new System.Drawing.Point(12, 2);
            this.gbx_ExtendOrder.Name = "gbx_ExtendOrder";
            this.gbx_ExtendOrder.Size = new System.Drawing.Size(243, 105);
            this.gbx_ExtendOrder.TabIndex = 10;
            this.gbx_ExtendOrder.TabStop = false;
            // 
            // ExtendOrderForm
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(263, 143);
            this.Controls.Add(this.gbx_ExtendOrder);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExtendOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExtendOrderForm";
            this.gbx_ExtendOrder.ResumeLayout(false);
            this.gbx_ExtendOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_SecondName;
        private System.Windows.Forms.Label lbl_RoomNumber;
        private System.Windows.Forms.Label lbl_NewDateOut;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_SecondName;
        private System.Windows.Forms.TextBox txt_RoomNumber;
        private System.Windows.Forms.DateTimePicker dtp_NewDateOut;
        private System.Windows.Forms.GroupBox gbx_ExtendOrder;
    }
}