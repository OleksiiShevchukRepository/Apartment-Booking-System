namespace ApartmentBooking.UI.Forms
{
    partial class DateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateForm));
            this.lbl_EnterDate = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.dtp_CheckingDate = new System.Windows.Forms.DateTimePicker();
            this.gbx_EnterDate = new System.Windows.Forms.GroupBox();
            this.gbx_EnterDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_EnterDate
            // 
            this.lbl_EnterDate.AutoSize = true;
            this.lbl_EnterDate.Location = new System.Drawing.Point(6, 16);
            this.lbl_EnterDate.Name = "lbl_EnterDate";
            this.lbl_EnterDate.Size = new System.Drawing.Size(58, 13);
            this.lbl_EnterDate.TabIndex = 0;
            this.lbl_EnterDate.Text = "Enter Date";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(9, 66);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(99, 66);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // dtp_CheckingDate
            // 
            this.dtp_CheckingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_CheckingDate.Location = new System.Drawing.Point(9, 32);
            this.dtp_CheckingDate.Name = "dtp_CheckingDate";
            this.dtp_CheckingDate.Size = new System.Drawing.Size(75, 20);
            this.dtp_CheckingDate.TabIndex = 3;
            // 
            // gbx_EnterDate
            // 
            this.gbx_EnterDate.Controls.Add(this.lbl_EnterDate);
            this.gbx_EnterDate.Controls.Add(this.dtp_CheckingDate);
            this.gbx_EnterDate.Controls.Add(this.btn_OK);
            this.gbx_EnterDate.Controls.Add(this.btn_Cancel);
            this.gbx_EnterDate.Location = new System.Drawing.Point(12, 2);
            this.gbx_EnterDate.Name = "gbx_EnterDate";
            this.gbx_EnterDate.Size = new System.Drawing.Size(200, 100);
            this.gbx_EnterDate.TabIndex = 4;
            this.gbx_EnterDate.TabStop = false;
            // 
            // DateForm
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(222, 110);
            this.Controls.Add(this.gbx_EnterDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Date";
            this.gbx_EnterDate.ResumeLayout(false);
            this.gbx_EnterDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_EnterDate;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.DateTimePicker dtp_CheckingDate;
        private System.Windows.Forms.GroupBox gbx_EnterDate;
    }
}