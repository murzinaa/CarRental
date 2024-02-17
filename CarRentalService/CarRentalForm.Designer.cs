namespace CarRentalService
{
    partial class CarRentalForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.reservationTabPage = new System.Windows.Forms.TabPage();
            this.carTabPage = new System.Windows.Forms.TabPage();
            this.clientsTabPage = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.reservationTabPage);
            this.tabControl.Controls.Add(this.carTabPage);
            this.tabControl.Controls.Add(this.clientsTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(791, 426);
            this.tabControl.TabIndex = 0;
            // 
            // reservationTabPage
            // 
            this.reservationTabPage.Location = new System.Drawing.Point(4, 29);
            this.reservationTabPage.Name = "reservationTabPage";
            this.reservationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reservationTabPage.Size = new System.Drawing.Size(783, 393);
            this.reservationTabPage.TabIndex = 0;
            this.reservationTabPage.Text = "Бронювання";
            this.reservationTabPage.UseVisualStyleBackColor = true;
            this.reservationTabPage.UseWaitCursor = true;
            // 
            // carTabPage
            // 
            this.carTabPage.Location = new System.Drawing.Point(4, 29);
            this.carTabPage.Name = "carTabPage";
            this.carTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.carTabPage.Size = new System.Drawing.Size(783, 393);
            this.carTabPage.TabIndex = 1;
            this.carTabPage.Text = "Авто";
            this.carTabPage.UseVisualStyleBackColor = true;
            // 
            // clientsTabPage
            // 
            this.clientsTabPage.Location = new System.Drawing.Point(4, 29);
            this.clientsTabPage.Name = "clientsTabPage";
            this.clientsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.clientsTabPage.Size = new System.Drawing.Size(783, 393);
            this.clientsTabPage.TabIndex = 2;
            this.clientsTabPage.Text = "Клієнти";
            this.clientsTabPage.UseVisualStyleBackColor = true;
            // 
            // CarRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "CarRentalForm";
            this.Text = "Сервіс бронювання авто";
            this.Load += new System.EventHandler(this.CarRentalForm_Load_1);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage reservationTabPage;
        private TabPage carTabPage;
        private TabPage clientsTabPage;
    }
}