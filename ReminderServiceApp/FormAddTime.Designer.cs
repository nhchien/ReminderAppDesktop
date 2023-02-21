namespace ReminderServiceApp
{
    partial class FormAddTime
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmAddOneTime = new System.Windows.Forms.Button();
            this.cbTypes = new System.Windows.Forms.ComboBox();
            this.lblDateTimes = new System.Windows.Forms.Label();
            this.lblTypes = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = " dd,MM, yyyy HH:mm tt";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(83, 11);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(158, 20);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.Value = new System.DateTime(2022, 11, 2, 0, 0, 0, 0);
            // 
            // btnConfirmAddOneTime
            // 
            this.btnConfirmAddOneTime.Location = new System.Drawing.Point(247, 12);
            this.btnConfirmAddOneTime.Name = "btnConfirmAddOneTime";
            this.btnConfirmAddOneTime.Size = new System.Drawing.Size(84, 73);
            this.btnConfirmAddOneTime.TabIndex = 1;
            this.btnConfirmAddOneTime.Text = "OK";
            this.btnConfirmAddOneTime.UseVisualStyleBackColor = true;
            this.btnConfirmAddOneTime.Click += new System.EventHandler(this.btnConfirmAddOneTime_Click);
            // 
            // cbTypes
            // 
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Location = new System.Drawing.Point(83, 38);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(158, 21);
            this.cbTypes.TabIndex = 2;
            // 
            // lblDateTimes
            // 
            this.lblDateTimes.AutoSize = true;
            this.lblDateTimes.Location = new System.Drawing.Point(12, 18);
            this.lblDateTimes.Name = "lblDateTimes";
            this.lblDateTimes.Size = new System.Drawing.Size(65, 13);
            this.lblDateTimes.TabIndex = 3;
            this.lblDateTimes.Text = "Date && Time";
            // 
            // lblTypes
            // 
            this.lblTypes.AutoSize = true;
            this.lblTypes.Location = new System.Drawing.Point(12, 41);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(31, 13);
            this.lblTypes.TabIndex = 4;
            this.lblTypes.Text = "Type";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 68);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "Message";
            // 
            // txtMessages
            // 
            this.txtMessages.Location = new System.Drawing.Point(83, 65);
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(158, 20);
            this.txtMessages.TabIndex = 6;
            // 
            // FormAddTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 95);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTypes);
            this.Controls.Add(this.lblDateTimes);
            this.Controls.Add(this.cbTypes);
            this.Controls.Add(this.btnConfirmAddOneTime);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "FormAddTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Time";
            this.Enter += new System.EventHandler(this.FormAddTime_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnConfirmAddOneTime;
        private System.Windows.Forms.ComboBox cbTypes;
        private System.Windows.Forms.Label lblDateTimes;
        private System.Windows.Forms.Label lblTypes;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtMessages;
    }
}