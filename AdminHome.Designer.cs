
namespace NoahHoMau
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.label16 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.btn_CustomerManager = new System.Windows.Forms.Button();
            this.btn_OrderManager = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.Control;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(66, -4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(733, 41);
            this.label16.TabIndex = 116;
            this.label16.Text = "ADMIN HOME";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Black;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ForeColor = System.Drawing.SystemColors.Control;
            this.button14.Location = new System.Drawing.Point(-2, -4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(68, 41);
            this.button14.TabIndex = 115;
            this.button14.Text = "LOGOUT";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(-1, -4);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(800, 471);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox14.TabIndex = 114;
            this.pictureBox14.TabStop = false;
            // 
            // btn_CustomerManager
            // 
            this.btn_CustomerManager.BackColor = System.Drawing.Color.Black;
            this.btn_CustomerManager.FlatAppearance.BorderSize = 0;
            this.btn_CustomerManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CustomerManager.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_CustomerManager.Location = new System.Drawing.Point(403, 112);
            this.btn_CustomerManager.Name = "btn_CustomerManager";
            this.btn_CustomerManager.Size = new System.Drawing.Size(278, 230);
            this.btn_CustomerManager.TabIndex = 128;
            this.btn_CustomerManager.Text = "CUSTOMER MANAGER";
            this.btn_CustomerManager.UseVisualStyleBackColor = false;
            this.btn_CustomerManager.Click += new System.EventHandler(this.btn_CustomerManager_Click);
            // 
            // btn_OrderManager
            // 
            this.btn_OrderManager.BackColor = System.Drawing.SystemColors.Control;
            this.btn_OrderManager.FlatAppearance.BorderSize = 0;
            this.btn_OrderManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OrderManager.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_OrderManager.Location = new System.Drawing.Point(109, 112);
            this.btn_OrderManager.Name = "btn_OrderManager";
            this.btn_OrderManager.Size = new System.Drawing.Size(278, 230);
            this.btn_OrderManager.TabIndex = 129;
            this.btn_OrderManager.Text = "ORDER MANAGER";
            this.btn_OrderManager.UseVisualStyleBackColor = false;
            this.btn_OrderManager.Click += new System.EventHandler(this.btn_OrderManager_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CustomerManager);
            this.Controls.Add(this.btn_OrderManager);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.pictureBox14);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.Button btn_CustomerManager;
        private System.Windows.Forms.Button btn_OrderManager;
    }
}