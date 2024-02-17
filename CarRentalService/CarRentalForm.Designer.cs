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
            components = new System.ComponentModel.Container();
            tabControl = new TabControl();
            reservationTabPage = new TabPage();
            saveReservationButton = new Button();
            dataGridView2 = new DataGridView();
            clientBindingSource = new BindingSource(components);
            carBindingSource = new BindingSource(components);
            reservationBindingSource = new BindingSource(components);
            carTabPage = new TabPage();
            saveButton = new Button();
            dataGridView1 = new DataGridView();
            clientsTabPage = new TabPage();
            saveClientButton = new Button();
            dataGridView3 = new DataGridView();
            fineTabPage = new TabPage();
            button1 = new Button();
            dataGridView4 = new DataGridView();
            fineBindingSource = new BindingSource(components);
            reservationBindingSource1 = new BindingSource(components);
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailAddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isRegularClientDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            modelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numberOfSeatsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeOfEngineDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            carDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expectedReturnDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            actualReturnDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tabControl.SuspendLayout();
            reservationTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource).BeginInit();
            carTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            clientsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            fineTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fineBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(reservationTabPage);
            tabControl.Controls.Add(carTabPage);
            tabControl.Controls.Add(clientsTabPage);
            tabControl.Controls.Add(fineTabPage);
            tabControl.Location = new Point(15, 15);
            tabControl.Margin = new Padding(4);
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1046, 532);
            tabControl.TabIndex = 0;
            // 
            // reservationTabPage
            // 
            reservationTabPage.Controls.Add(saveReservationButton);
            reservationTabPage.Controls.Add(dataGridView2);
            reservationTabPage.Location = new Point(4, 34);
            reservationTabPage.Margin = new Padding(4);
            reservationTabPage.Name = "reservationTabPage";
            reservationTabPage.Padding = new Padding(4);
            reservationTabPage.Size = new Size(1038, 494);
            reservationTabPage.TabIndex = 0;
            reservationTabPage.Text = "Бронювання";
            reservationTabPage.UseVisualStyleBackColor = true;
            reservationTabPage.UseWaitCursor = true;
            // 
            // saveReservationButton
            // 
            saveReservationButton.Location = new Point(22, 381);
            saveReservationButton.Margin = new Padding(4);
            saveReservationButton.Name = "saveReservationButton";
            saveReservationButton.Size = new Size(118, 36);
            saveReservationButton.TabIndex = 1;
            saveReservationButton.Text = "Зберегти";
            saveReservationButton.UseVisualStyleBackColor = true;
            saveReservationButton.UseWaitCursor = true;
            saveReservationButton.Click += saveReservationButton_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { clientDataGridViewTextBoxColumn, carDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, expectedReturnDateDataGridViewTextBoxColumn, actualReturnDateDataGridViewTextBoxColumn });
            dataGridView2.DataSource = reservationBindingSource;
            dataGridView2.Location = new Point(8, 8);
            dataGridView2.Margin = new Padding(4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(1006, 341);
            dataGridView2.TabIndex = 0;
            dataGridView2.UseWaitCursor = true;
            // 
            // clientBindingSource
            // 
            clientBindingSource.DataSource = typeof(DataAccess.Entities.Client);
            // 
            // carBindingSource
            // 
            carBindingSource.DataSource = typeof(DataAccess.Entities.Car);
            // 
            // reservationBindingSource
            // 
            reservationBindingSource.DataSource = typeof(DataAccess.Entities.Reservation);
            // 
            // carTabPage
            // 
            carTabPage.Controls.Add(saveButton);
            carTabPage.Controls.Add(dataGridView1);
            carTabPage.Location = new Point(4, 34);
            carTabPage.Margin = new Padding(4);
            carTabPage.Name = "carTabPage";
            carTabPage.Padding = new Padding(4);
            carTabPage.Size = new Size(1038, 494);
            carTabPage.TabIndex = 1;
            carTabPage.Text = "Авто";
            carTabPage.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(20, 302);
            saveButton.Margin = new Padding(4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(118, 36);
            saveButton.TabIndex = 1;
            saveButton.Text = "Зберегти";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { modelDataGridViewTextBoxColumn, yearDataGridViewTextBoxColumn, numberOfSeatsDataGridViewTextBoxColumn, typeOfEngineDataGridViewTextBoxColumn });
            dataGridView1.DataSource = carBindingSource;
            dataGridView1.Location = new Point(20, 31);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(849, 235);
            dataGridView1.TabIndex = 0;
            // 
            // clientsTabPage
            // 
            clientsTabPage.Controls.Add(saveClientButton);
            clientsTabPage.Controls.Add(dataGridView3);
            clientsTabPage.Location = new Point(4, 34);
            clientsTabPage.Margin = new Padding(4);
            clientsTabPage.Name = "clientsTabPage";
            clientsTabPage.Padding = new Padding(4);
            clientsTabPage.Size = new Size(1038, 494);
            clientsTabPage.TabIndex = 2;
            clientsTabPage.Text = "Клієнти";
            clientsTabPage.UseVisualStyleBackColor = true;
            // 
            // saveClientButton
            // 
            saveClientButton.Location = new Point(35, 328);
            saveClientButton.Margin = new Padding(4);
            saveClientButton.Name = "saveClientButton";
            saveClientButton.Size = new Size(118, 36);
            saveClientButton.TabIndex = 1;
            saveClientButton.Text = "Зберегти";
            saveClientButton.UseVisualStyleBackColor = true;
            saveClientButton.Click += saveClientButton_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, emailAddressDataGridViewTextBoxColumn, isRegularClientDataGridViewCheckBoxColumn });
            dataGridView3.DataSource = clientBindingSource;
            dataGridView3.Location = new Point(15, 18);
            dataGridView3.Margin = new Padding(4);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(999, 266);
            dataGridView3.TabIndex = 0;
            // 
            // fineTabPage
            // 
            fineTabPage.Controls.Add(button1);
            fineTabPage.Controls.Add(dataGridView4);
            fineTabPage.Location = new Point(4, 34);
            fineTabPage.Name = "fineTabPage";
            fineTabPage.Padding = new Padding(3);
            fineTabPage.Size = new Size(1038, 494);
            fineTabPage.TabIndex = 3;
            fineTabPage.Text = "Штрафи";
            fineTabPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(40, 350);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Зберегти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.AutoGenerateColumns = false;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { titleDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            dataGridView4.DataSource = fineBindingSource;
            dataGridView4.Location = new Point(40, 54);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 62;
            dataGridView4.RowTemplate.Height = 33;
            dataGridView4.Size = new Size(711, 188);
            dataGridView4.TabIndex = 0;
            // 
            // fineBindingSource
            // 
            fineBindingSource.DataSource = typeof(DataAccess.Entities.Fine);
            // 
            // reservationBindingSource1
            // 
            reservationBindingSource1.DataSource = typeof(DataAccess.Entities.Reservation);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Опис штрафу";
            titleDataGridViewTextBoxColumn.MinimumWidth = 8;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Вартість";
            priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "Ім'я";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "Номер Телефону";
            phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            emailAddressDataGridViewTextBoxColumn.HeaderText = "Пошта";
            emailAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            emailAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // isRegularClientDataGridViewCheckBoxColumn
            // 
            isRegularClientDataGridViewCheckBoxColumn.DataPropertyName = "IsRegularClient";
            isRegularClientDataGridViewCheckBoxColumn.HeaderText = "Постійний клієнт";
            isRegularClientDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isRegularClientDataGridViewCheckBoxColumn.Name = "isRegularClientDataGridViewCheckBoxColumn";
            isRegularClientDataGridViewCheckBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            modelDataGridViewTextBoxColumn.HeaderText = "Модель авто";
            modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            yearDataGridViewTextBoxColumn.HeaderText = "Рік випуску";
            yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            yearDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberOfSeatsDataGridViewTextBoxColumn
            // 
            numberOfSeatsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfSeats";
            numberOfSeatsDataGridViewTextBoxColumn.HeaderText = "Кількість сидінь";
            numberOfSeatsDataGridViewTextBoxColumn.MinimumWidth = 6;
            numberOfSeatsDataGridViewTextBoxColumn.Name = "numberOfSeatsDataGridViewTextBoxColumn";
            numberOfSeatsDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeOfEngineDataGridViewTextBoxColumn
            // 
            typeOfEngineDataGridViewTextBoxColumn.DataPropertyName = "TypeOfEngine";
            typeOfEngineDataGridViewTextBoxColumn.HeaderText = "Тип коробки передач";
            typeOfEngineDataGridViewTextBoxColumn.MinimumWidth = 6;
            typeOfEngineDataGridViewTextBoxColumn.Name = "typeOfEngineDataGridViewTextBoxColumn";
            typeOfEngineDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            clientDataGridViewTextBoxColumn.DataSource = clientBindingSource;
            clientDataGridViewTextBoxColumn.DisplayMember = "EmailAddress";
            clientDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            clientDataGridViewTextBoxColumn.HeaderText = "Клієнт";
            clientDataGridViewTextBoxColumn.MinimumWidth = 6;
            clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            clientDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            clientDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            clientDataGridViewTextBoxColumn.ValueMember = "Id";
            clientDataGridViewTextBoxColumn.Width = 125;
            // 
            // carDataGridViewTextBoxColumn
            // 
            carDataGridViewTextBoxColumn.DataPropertyName = "Car";
            carDataGridViewTextBoxColumn.DataSource = carBindingSource;
            carDataGridViewTextBoxColumn.DisplayMember = "Model";
            carDataGridViewTextBoxColumn.HeaderText = "Авто";
            carDataGridViewTextBoxColumn.MinimumWidth = 6;
            carDataGridViewTextBoxColumn.Name = "carDataGridViewTextBoxColumn";
            carDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            carDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            carDataGridViewTextBoxColumn.ValueMember = "Id";
            carDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            startDateDataGridViewTextBoxColumn.HeaderText = "Дата бронування";
            startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            startDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // expectedReturnDateDataGridViewTextBoxColumn
            // 
            expectedReturnDateDataGridViewTextBoxColumn.DataPropertyName = "ExpectedReturnDate";
            expectedReturnDateDataGridViewTextBoxColumn.HeaderText = "Очікувана дата повернення";
            expectedReturnDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            expectedReturnDateDataGridViewTextBoxColumn.Name = "expectedReturnDateDataGridViewTextBoxColumn";
            expectedReturnDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // actualReturnDateDataGridViewTextBoxColumn
            // 
            actualReturnDateDataGridViewTextBoxColumn.DataPropertyName = "ActualReturnDate";
            actualReturnDateDataGridViewTextBoxColumn.HeaderText = "Дата повернення";
            actualReturnDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            actualReturnDateDataGridViewTextBoxColumn.Name = "actualReturnDateDataGridViewTextBoxColumn";
            actualReturnDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // CarRentalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 555);
            Controls.Add(tabControl);
            Margin = new Padding(4);
            Name = "CarRentalForm";
            Text = "Сервіс бронювання авто";
            Load += CarRentalForm_Load_1;
            tabControl.ResumeLayout(false);
            reservationTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource).EndInit();
            carTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            clientsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            fineTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)fineBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource1).EndInit();
            ResumeLayout(false);
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
        private TabPage fineTabPage;
        private DataGridView dataGridView4;
        private BindingSource fineBindingSource;
        private Button button1;
        private DataGridViewComboBoxColumn clientDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn carDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expectedReturnDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn actualReturnDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberOfSeatsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeOfEngineDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isRegularClientDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}