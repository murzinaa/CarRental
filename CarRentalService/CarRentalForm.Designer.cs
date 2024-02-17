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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.reservationTabPage = new System.Windows.Forms.TabPage();
            this.saveReservationButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTabPage = new System.Windows.Forms.TabPage();
            this.saveButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientsTabPage = new System.Windows.Forms.TabPage();
            this.saveClientButton = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.reservationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRegularClientDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfSeatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfEngineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.carDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedReturnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualReturnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.reservationTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            this.carTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.clientsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource1)).BeginInit();
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
            this.tabControl.Size = new System.Drawing.Size(837, 426);
            this.tabControl.TabIndex = 0;
            // 
            // reservationTabPage
            // 
            this.reservationTabPage.Controls.Add(this.saveReservationButton);
            this.reservationTabPage.Controls.Add(this.dataGridView2);
            this.reservationTabPage.Location = new System.Drawing.Point(4, 29);
            this.reservationTabPage.Name = "reservationTabPage";
            this.reservationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reservationTabPage.Size = new System.Drawing.Size(829, 393);
            this.reservationTabPage.TabIndex = 0;
            this.reservationTabPage.Text = "Бронювання";
            this.reservationTabPage.UseVisualStyleBackColor = true;
            this.reservationTabPage.UseWaitCursor = true;
            // 
            // saveReservationButton
            // 
            this.saveReservationButton.Location = new System.Drawing.Point(18, 305);
            this.saveReservationButton.Name = "saveReservationButton";
            this.saveReservationButton.Size = new System.Drawing.Size(94, 29);
            this.saveReservationButton.TabIndex = 1;
            this.saveReservationButton.Text = "Save";
            this.saveReservationButton.UseVisualStyleBackColor = true;
            this.saveReservationButton.UseWaitCursor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.clientDataGridViewTextBoxColumn,
            this.carDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.expectedReturnDateDataGridViewTextBoxColumn,
            this.actualReturnDateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.reservationBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(805, 273);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.UseWaitCursor = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(CarRentalService.DataAccess.Entities.Client);
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(CarRentalService.DataAccess.Entities.Car);
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(CarRentalService.DataAccess.Entities.Reservation);
            // 
            // carTabPage
            // 
            this.carTabPage.Controls.Add(this.saveButton);
            this.carTabPage.Controls.Add(this.dataGridView1);
            this.carTabPage.Location = new System.Drawing.Point(4, 29);
            this.carTabPage.Name = "carTabPage";
            this.carTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.carTabPage.Size = new System.Drawing.Size(829, 393);
            this.carTabPage.TabIndex = 1;
            this.carTabPage.Text = "Авто";
            this.carTabPage.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(16, 242);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 29);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.numberOfSeatsDataGridViewTextBoxColumn,
            this.typeOfEngineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(679, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // clientsTabPage
            // 
            this.clientsTabPage.Controls.Add(this.saveClientButton);
            this.clientsTabPage.Controls.Add(this.dataGridView3);
            this.clientsTabPage.Location = new System.Drawing.Point(4, 29);
            this.clientsTabPage.Name = "clientsTabPage";
            this.clientsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.clientsTabPage.Size = new System.Drawing.Size(829, 393);
            this.clientsTabPage.TabIndex = 2;
            this.clientsTabPage.Text = "Клієнти";
            this.clientsTabPage.UseVisualStyleBackColor = true;
            // 
            // saveClientButton
            // 
            this.saveClientButton.Location = new System.Drawing.Point(28, 262);
            this.saveClientButton.Name = "saveClientButton";
            this.saveClientButton.Size = new System.Drawing.Size(94, 29);
            this.saveClientButton.TabIndex = 1;
            this.saveClientButton.Text = "Save";
            this.saveClientButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.isRegularClientDataGridViewCheckBoxColumn});
            this.dataGridView3.DataSource = this.clientBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 14);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 29;
            this.dataGridView3.Size = new System.Drawing.Size(799, 213);
            this.dataGridView3.TabIndex = 0;
            // 
            // reservationBindingSource1
            // 
            this.reservationBindingSource1.DataSource = typeof(CarRentalService.DataAccess.Entities.Reservation);
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.Visible = false;
            this.idDataGridViewTextBoxColumn2.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Номер Телефону";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "Пошта";
            this.emailAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // isRegularClientDataGridViewCheckBoxColumn
            // 
            this.isRegularClientDataGridViewCheckBoxColumn.DataPropertyName = "IsRegularClient";
            this.isRegularClientDataGridViewCheckBoxColumn.HeaderText = "Постійний клієнт";
            this.isRegularClientDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isRegularClientDataGridViewCheckBoxColumn.Name = "isRegularClientDataGridViewCheckBoxColumn";
            this.isRegularClientDataGridViewCheckBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Модель авто";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Рік випуску";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberOfSeatsDataGridViewTextBoxColumn
            // 
            this.numberOfSeatsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfSeats";
            this.numberOfSeatsDataGridViewTextBoxColumn.HeaderText = "Кількість сидінь";
            this.numberOfSeatsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfSeatsDataGridViewTextBoxColumn.Name = "numberOfSeatsDataGridViewTextBoxColumn";
            this.numberOfSeatsDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeOfEngineDataGridViewTextBoxColumn
            // 
            this.typeOfEngineDataGridViewTextBoxColumn.DataPropertyName = "TypeOfEngine";
            this.typeOfEngineDataGridViewTextBoxColumn.HeaderText = "Тип коробки передач";
            this.typeOfEngineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeOfEngineDataGridViewTextBoxColumn.Name = "typeOfEngineDataGridViewTextBoxColumn";
            this.typeOfEngineDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Visible = false;
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.DataSource = this.clientBindingSource;
            this.clientDataGridViewTextBoxColumn.DisplayMember = "EmailAddress";
            this.clientDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.clientDataGridViewTextBoxColumn.HeaderText = "Клієнт";
            this.clientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clientDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clientDataGridViewTextBoxColumn.ValueMember = "Id";
            this.clientDataGridViewTextBoxColumn.Width = 125;
            // 
            // carDataGridViewTextBoxColumn
            // 
            this.carDataGridViewTextBoxColumn.DataPropertyName = "Car";
            this.carDataGridViewTextBoxColumn.DataSource = this.carBindingSource;
            this.carDataGridViewTextBoxColumn.DisplayMember = "Model";
            this.carDataGridViewTextBoxColumn.HeaderText = "Авто";
            this.carDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carDataGridViewTextBoxColumn.Name = "carDataGridViewTextBoxColumn";
            this.carDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.carDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.carDataGridViewTextBoxColumn.ValueMember = "Id";
            this.carDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Дата бронування";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // expectedReturnDateDataGridViewTextBoxColumn
            // 
            this.expectedReturnDateDataGridViewTextBoxColumn.DataPropertyName = "ExpectedReturnDate";
            this.expectedReturnDateDataGridViewTextBoxColumn.HeaderText = "Очікувана дата повернення";
            this.expectedReturnDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expectedReturnDateDataGridViewTextBoxColumn.Name = "expectedReturnDateDataGridViewTextBoxColumn";
            this.expectedReturnDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // actualReturnDateDataGridViewTextBoxColumn
            // 
            this.actualReturnDateDataGridViewTextBoxColumn.DataPropertyName = "ActualReturnDate";
            this.actualReturnDateDataGridViewTextBoxColumn.HeaderText = "Дата повернення";
            this.actualReturnDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.actualReturnDateDataGridViewTextBoxColumn.Name = "actualReturnDateDataGridViewTextBoxColumn";
            this.actualReturnDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // CarRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 444);
            this.Controls.Add(this.tabControl);
            this.Name = "CarRentalForm";
            this.Text = "Сервіс бронювання авто";
            this.Load += new System.EventHandler(this.CarRentalForm_Load_1);
            this.tabControl.ResumeLayout(false);
            this.reservationTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            this.carTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.clientsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage reservationTabPage;
        private TabPage carTabPage;
        private TabPage clientsTabPage;
        private DataGridView dataGridView1;
        private BindingSource carBindingSource;
        private Button saveButton;
        private Button saveReservationButton;
        private DataGridView dataGridView2;
        private BindingSource reservationBindingSource;
        private Button saveClientButton;
        private DataGridView dataGridView3;
        private BindingSource clientBindingSource;
        private BindingSource reservationBindingSource1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberOfSeatsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeOfEngineDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isRegularClientDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewComboBoxColumn clientDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn carDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expectedReturnDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn actualReturnDateDataGridViewTextBoxColumn;
    }
}