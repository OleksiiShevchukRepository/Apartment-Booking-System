namespace ApartmentBooking.UI.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbl_PriceList = new System.Windows.Forms.Label();
            this.dgv_PriceList = new System.Windows.Forms.DataGridView();
            this.dgv_Info = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.str_menu_button_Order = new System.Windows.Forms.ToolStripDropDownButton();
            this.str_menu_item_NewOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.str_menu_item_ExtendOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.str_menu_item_ShowAllOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.str_menu_button_Rooms = new System.Windows.Forms.ToolStripDropDownButton();
            this.str_menu_item_AllHotelRooms = new System.Windows.Forms.ToolStripMenuItem();
            this.str_menu_item_AllAvailableRooms = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.str_menu_item_RoomInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PriceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Info)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_PriceList
            // 
            this.lbl_PriceList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PriceList.AutoSize = true;
            this.lbl_PriceList.Location = new System.Drawing.Point(721, 33);
            this.lbl_PriceList.Name = "lbl_PriceList";
            this.lbl_PriceList.Size = new System.Drawing.Size(50, 13);
            this.lbl_PriceList.TabIndex = 0;
            this.lbl_PriceList.Text = "Price List";
            // 
            // dgv_PriceList
            // 
            this.dgv_PriceList.AllowUserToAddRows = false;
            this.dgv_PriceList.AllowUserToDeleteRows = false;
            this.dgv_PriceList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_PriceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PriceList.Location = new System.Drawing.Point(724, 49);
            this.dgv_PriceList.Name = "dgv_PriceList";
            this.dgv_PriceList.ReadOnly = true;
            this.dgv_PriceList.RowHeadersVisible = false;
            this.dgv_PriceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PriceList.Size = new System.Drawing.Size(229, 292);
            this.dgv_PriceList.TabIndex = 1;
            // 
            // dgv_Info
            // 
            this.dgv_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Info.Location = new System.Drawing.Point(5, 49);
            this.dgv_Info.Name = "dgv_Info";
            this.dgv_Info.RowHeadersVisible = false;
            this.dgv_Info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Info.Size = new System.Drawing.Size(707, 359);
            this.dgv_Info.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.str_menu_button_Order,
            this.str_menu_button_Rooms});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(958, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // str_menu_button_Order
            // 
            this.str_menu_button_Order.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.str_menu_button_Order.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.str_menu_item_NewOrder,
            this.str_menu_item_ExtendOrder,
            this.toolStripSeparator1,
            this.str_menu_item_ShowAllOrders});
            this.str_menu_button_Order.Image = ((System.Drawing.Image)(resources.GetObject("str_menu_button_Order.Image")));
            this.str_menu_button_Order.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.str_menu_button_Order.Name = "str_menu_button_Order";
            this.str_menu_button_Order.Size = new System.Drawing.Size(50, 22);
            this.str_menu_button_Order.Text = "Order";
            // 
            // str_menu_item_NewOrder
            // 
            this.str_menu_item_NewOrder.Name = "str_menu_item_NewOrder";
            this.str_menu_item_NewOrder.Size = new System.Drawing.Size(158, 22);
            this.str_menu_item_NewOrder.Text = "New Order";
            this.str_menu_item_NewOrder.Click += new System.EventHandler(this.str_menu_item_NewOrder_Click);
            // 
            // str_menu_item_ExtendOrder
            // 
            this.str_menu_item_ExtendOrder.Name = "str_menu_item_ExtendOrder";
            this.str_menu_item_ExtendOrder.Size = new System.Drawing.Size(158, 22);
            this.str_menu_item_ExtendOrder.Text = "Extend Order";
            this.str_menu_item_ExtendOrder.Click += new System.EventHandler(this.str_menu_item_ExtendOrder_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // str_menu_item_ShowAllOrders
            // 
            this.str_menu_item_ShowAllOrders.Name = "str_menu_item_ShowAllOrders";
            this.str_menu_item_ShowAllOrders.Size = new System.Drawing.Size(158, 22);
            this.str_menu_item_ShowAllOrders.Text = "Show All Orders";
            this.str_menu_item_ShowAllOrders.Click += new System.EventHandler(this.str_menu_item_ShowAllOrders_Click);
            // 
            // str_menu_button_Rooms
            // 
            this.str_menu_button_Rooms.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.str_menu_button_Rooms.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.str_menu_item_AllHotelRooms,
            this.str_menu_item_AllAvailableRooms,
            this.toolStripSeparator2,
            this.str_menu_item_RoomInfo});
            this.str_menu_button_Rooms.Image = ((System.Drawing.Image)(resources.GetObject("str_menu_button_Rooms.Image")));
            this.str_menu_button_Rooms.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.str_menu_button_Rooms.Name = "str_menu_button_Rooms";
            this.str_menu_button_Rooms.Size = new System.Drawing.Size(57, 22);
            this.str_menu_button_Rooms.Text = "Rooms";
            // 
            // str_menu_item_AllHotelRooms
            // 
            this.str_menu_item_AllHotelRooms.Name = "str_menu_item_AllHotelRooms";
            this.str_menu_item_AllHotelRooms.Size = new System.Drawing.Size(179, 22);
            this.str_menu_item_AllHotelRooms.Text = "All Hotel Rooms";
            this.str_menu_item_AllHotelRooms.Click += new System.EventHandler(this.str_menu_item_AllHotelRooms_Click);
            // 
            // str_menu_item_AllAvailableRooms
            // 
            this.str_menu_item_AllAvailableRooms.Name = "str_menu_item_AllAvailableRooms";
            this.str_menu_item_AllAvailableRooms.Size = new System.Drawing.Size(179, 22);
            this.str_menu_item_AllAvailableRooms.Text = "All Available Rooms";
            this.str_menu_item_AllAvailableRooms.Click += new System.EventHandler(this.str_menu_item_AllAvailableRooms_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(176, 6);
            // 
            // str_menu_item_RoomInfo
            // 
            this.str_menu_item_RoomInfo.Name = "str_menu_item_RoomInfo";
            this.str_menu_item_RoomInfo.Size = new System.Drawing.Size(179, 22);
            this.str_menu_item_RoomInfo.Text = "Room Information";
            this.str_menu_item_RoomInfo.Click += new System.EventHandler(this.str_menu_item_RoomInfo_Click);
            // 
            // lbl_Info
            // 
            this.lbl_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Location = new System.Drawing.Point(2, 33);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(40, 13);
            this.lbl_Info.TabIndex = 5;
            this.lbl_Info.Text = "Rooms";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 422);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_Info);
            this.Controls.Add(this.dgv_PriceList);
            this.Controls.Add(this.lbl_PriceList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 320);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApartmentBooking";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PriceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Info)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PriceList;
        private System.Windows.Forms.DataGridView dgv_PriceList;
        private System.Windows.Forms.DataGridView dgv_Info;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton str_menu_button_Order;
        private System.Windows.Forms.ToolStripMenuItem str_menu_item_NewOrder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem str_menu_item_ShowAllOrders;
        private System.Windows.Forms.ToolStripDropDownButton str_menu_button_Rooms;
        private System.Windows.Forms.ToolStripMenuItem str_menu_item_AllHotelRooms;
        private System.Windows.Forms.ToolStripMenuItem str_menu_item_AllAvailableRooms;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem str_menu_item_RoomInfo;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.ToolStripMenuItem str_menu_item_ExtendOrder;
    }
}

