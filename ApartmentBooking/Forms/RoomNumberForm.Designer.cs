namespace ApartmentBooking.UI.Forms
{
    partial class RoomNumberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomNumberForm));
            this.lbl_RoomNumber = new System.Windows.Forms.Label();
            this.txt_RoomNumber = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.gbx_RoomNumber = new System.Windows.Forms.GroupBox();
            this.gbx_RoomNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_RoomNumber
            // 
            this.lbl_RoomNumber.AutoSize = true;
            this.lbl_RoomNumber.Location = new System.Drawing.Point(3, 7);
            this.lbl_RoomNumber.Name = "lbl_RoomNumber";
            this.lbl_RoomNumber.Size = new System.Drawing.Size(75, 13);
            this.lbl_RoomNumber.TabIndex = 0;
            this.lbl_RoomNumber.Text = "Room Number";
            // 
            // txt_RoomNumber
            // 
            this.txt_RoomNumber.Location = new System.Drawing.Point(6, 23);
            this.txt_RoomNumber.Name = "txt_RoomNumber";
            this.txt_RoomNumber.Size = new System.Drawing.Size(143, 20);
            this.txt_RoomNumber.TabIndex = 1;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(12, 74);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 2;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(93, 74);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // gbx_RoomNumber
            // 
            this.gbx_RoomNumber.Controls.Add(this.txt_RoomNumber);
            this.gbx_RoomNumber.Controls.Add(this.lbl_RoomNumber);
            this.gbx_RoomNumber.Location = new System.Drawing.Point(12, 6);
            this.gbx_RoomNumber.Name = "gbx_RoomNumber";
            this.gbx_RoomNumber.Size = new System.Drawing.Size(156, 58);
            this.gbx_RoomNumber.TabIndex = 4;
            this.gbx_RoomNumber.TabStop = false;
            // 
            // RoomNumberForm
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(178, 109);
            this.Controls.Add(this.gbx_RoomNumber);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoomNumberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Number";
            this.gbx_RoomNumber.ResumeLayout(false);
            this.gbx_RoomNumber.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_RoomNumber;
        private System.Windows.Forms.TextBox txt_RoomNumber;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.GroupBox gbx_RoomNumber;
    }
}