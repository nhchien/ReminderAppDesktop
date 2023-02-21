namespace ReminderServiceApp
{
    partial class FormDisplayTime
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

        #region #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDisplayTime));
            this.notifyIconRemind = new System.Windows.Forms.NotifyIcon(this.components);
            this.dgvDisplayTime = new System.Windows.Forms.DataGridView();
            this.btnAddTime = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayTime)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIconRemind
            // 
            this.notifyIconRemind.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconRemind.Icon")));
            this.notifyIconRemind.Text = "Reminder";
            this.notifyIconRemind.Visible = true;
            this.notifyIconRemind.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIconRemind.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            this.notifyIconRemind.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // dgvDisplayTime
            // 
            this.dgvDisplayTime.AllowUserToAddRows = false;
            this.dgvDisplayTime.AllowUserToDeleteRows = false;
            this.dgvDisplayTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisplayTime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplayTime.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvDisplayTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayTime.Location = new System.Drawing.Point(12, 64);
            this.dgvDisplayTime.MultiSelect = false;
            this.dgvDisplayTime.Name = "dgvDisplayTime";
            this.dgvDisplayTime.ReadOnly = true;
            this.dgvDisplayTime.RowHeadersWidth = 40;
            this.dgvDisplayTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisplayTime.Size = new System.Drawing.Size(433, 210);
            this.dgvDisplayTime.TabIndex = 1;
            this.dgvDisplayTime.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayDaily_CellClick);
            // 
            // btnAddTime
            // 
            this.btnAddTime.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddTime.Location = new System.Drawing.Point(12, 12);
            this.btnAddTime.Name = "btnAddTime";
            this.btnAddTime.Size = new System.Drawing.Size(80, 45);
            this.btnAddTime.TabIndex = 0;
            this.btnAddTime.Text = "Add time";
            this.btnAddTime.UseVisualStyleBackColor = false;
            this.btnAddTime.Click += new System.EventHandler(this.btnAddTime_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemove.Location = new System.Drawing.Point(365, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(80, 45);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // FormDisplayTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 285);
            this.Controls.Add(this.btnAddTime);
            this.Controls.Add(this.dgvDisplayTime);
            this.Controls.Add(this.btnRemove);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDisplayTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayTimeScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDisplayTime_FormClosing);
            this.Resize += new System.EventHandler(this.DisplayTimeScreen_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.NotifyIcon notifyIconRemind;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.DataGridView dgvDisplayTime;
        private System.Windows.Forms.Button btnRemove;
    }
}