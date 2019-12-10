namespace Harman_Video_Rental_Store
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCustomerPanel = new System.Windows.Forms.Button();
            this.btnVideoPanel = new System.Windows.Forms.Button();
            this.btnRentalPanel = new System.Windows.Forms.Button();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRatting = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.btnVideoADd = new System.Windows.Forms.Button();
            this.btnVideoDelete = new System.Windows.Forms.Button();
            this.btnVideoUpdate = new System.Windows.Forms.Button();
            this.btnBestVideo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblVideoID = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BookingDate = new System.Windows.Forms.DateTimePicker();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.btnVideoIssue = new System.Windows.Forms.Button();
            this.btnVideoReturn = new System.Windows.Forms.Button();
            this.btnVideoDel = new System.Windows.Forms.Button();
            this.Database = new System.Windows.Forms.DataGridView();
            this.lblRentalID = new System.Windows.Forms.Label();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.rbVideo = new System.Windows.Forms.RadioButton();
            this.rbRent = new System.Windows.Forms.RadioButton();
            this.btnBestCustomer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Database)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.rbRent);
            this.groupBox1.Controls.Add(this.rbVideo);
            this.groupBox1.Controls.Add(this.rbCustomer);
            this.groupBox1.Controls.Add(this.btnRentalPanel);
            this.groupBox1.Controls.Add(this.btnVideoPanel);
            this.groupBox1.Controls.Add(this.btnCustomerPanel);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 446);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin Area";
            // 
            // btnCustomerPanel
            // 
            this.btnCustomerPanel.BackColor = System.Drawing.Color.Teal;
            this.btnCustomerPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerPanel.ForeColor = System.Drawing.Color.White;
            this.btnCustomerPanel.Location = new System.Drawing.Point(10, 36);
            this.btnCustomerPanel.Name = "btnCustomerPanel";
            this.btnCustomerPanel.Size = new System.Drawing.Size(171, 30);
            this.btnCustomerPanel.TabIndex = 1;
            this.btnCustomerPanel.Text = "Customer Panel";
            this.btnCustomerPanel.UseVisualStyleBackColor = false;
            this.btnCustomerPanel.Click += new System.EventHandler(this.btnCustomerPanel_Click);
            // 
            // btnVideoPanel
            // 
            this.btnVideoPanel.BackColor = System.Drawing.Color.Teal;
            this.btnVideoPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoPanel.ForeColor = System.Drawing.Color.White;
            this.btnVideoPanel.Location = new System.Drawing.Point(10, 87);
            this.btnVideoPanel.Name = "btnVideoPanel";
            this.btnVideoPanel.Size = new System.Drawing.Size(171, 30);
            this.btnVideoPanel.TabIndex = 2;
            this.btnVideoPanel.Text = "Video Panel";
            this.btnVideoPanel.UseVisualStyleBackColor = false;
            this.btnVideoPanel.Click += new System.EventHandler(this.btnVideoPanel_Click);
            // 
            // btnRentalPanel
            // 
            this.btnRentalPanel.BackColor = System.Drawing.Color.Teal;
            this.btnRentalPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentalPanel.ForeColor = System.Drawing.Color.White;
            this.btnRentalPanel.Location = new System.Drawing.Point(10, 143);
            this.btnRentalPanel.Name = "btnRentalPanel";
            this.btnRentalPanel.Size = new System.Drawing.Size(171, 30);
            this.btnRentalPanel.TabIndex = 3;
            this.btnRentalPanel.Text = "Rental Panel";
            this.btnRentalPanel.UseVisualStyleBackColor = false;
            this.btnRentalPanel.Click += new System.EventHandler(this.btnRentalPanel_Click);
            // 
            // grpCustomer
            // 
            this.grpCustomer.BackColor = System.Drawing.Color.Teal;
            this.grpCustomer.Controls.Add(this.btnBestCustomer);
            this.grpCustomer.Controls.Add(this.btnCustomerUpdate);
            this.grpCustomer.Controls.Add(this.btnCustomerDelete);
            this.grpCustomer.Controls.Add(this.btnCustomerAdd);
            this.grpCustomer.Controls.Add(this.label3);
            this.grpCustomer.Controls.Add(this.label2);
            this.grpCustomer.Controls.Add(this.label1);
            this.grpCustomer.Controls.Add(this.txtContact);
            this.grpCustomer.Controls.Add(this.txtAddress);
            this.grpCustomer.Controls.Add(this.txtName);
            this.grpCustomer.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomer.ForeColor = System.Drawing.Color.Yellow;
            this.grpCustomer.Location = new System.Drawing.Point(201, 12);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(215, 289);
            this.grpCustomer.TabIndex = 1;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(18, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(18, 85);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(155, 22);
            this.txtAddress.TabIndex = 1;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(18, 133);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(155, 22);
            this.txtContact.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contact";
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.BackColor = System.Drawing.Color.Teal;
            this.btnCustomerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerAdd.ForeColor = System.Drawing.Color.White;
            this.btnCustomerAdd.Location = new System.Drawing.Point(18, 165);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(171, 30);
            this.btnCustomerAdd.TabIndex = 4;
            this.btnCustomerAdd.Text = "Customer Add";
            this.btnCustomerAdd.UseVisualStyleBackColor = false;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.BackColor = System.Drawing.Color.Teal;
            this.btnCustomerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDelete.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDelete.Location = new System.Drawing.Point(19, 197);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(171, 30);
            this.btnCustomerDelete.TabIndex = 6;
            this.btnCustomerDelete.Text = "Customer Delete";
            this.btnCustomerDelete.UseVisualStyleBackColor = false;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnCustomerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerUpdate.ForeColor = System.Drawing.Color.White;
            this.btnCustomerUpdate.Location = new System.Drawing.Point(19, 229);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(171, 30);
            this.btnCustomerUpdate.TabIndex = 7;
            this.btnCustomerUpdate.Text = "Customer Update";
            this.btnCustomerUpdate.UseVisualStyleBackColor = false;
            this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Controls.Add(this.btnBestVideo);
            this.groupBox2.Controls.Add(this.btnVideoUpdate);
            this.groupBox2.Controls.Add(this.btnVideoDelete);
            this.groupBox2.Controls.Add(this.btnVideoADd);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtGenre);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCopies);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCost);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtYear);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtRatting);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox2.Location = new System.Drawing.Point(423, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 264);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Video";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(9, 42);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(155, 22);
            this.txtTitle.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ratting";
            // 
            // txtRatting
            // 
            this.txtRatting.Location = new System.Drawing.Point(11, 93);
            this.txtRatting.Name = "txtRatting";
            this.txtRatting.Size = new System.Drawing.Size(155, 22);
            this.txtRatting.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(11, 140);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(155, 22);
            this.txtYear.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(174, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cost";
            // 
            // txtCost
            // 
            this.txtCost.Enabled = false;
            this.txtCost.Location = new System.Drawing.Point(177, 39);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(155, 22);
            this.txtCost.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(174, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Copies";
            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(177, 93);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(155, 22);
            this.txtCopies.TabIndex = 12;
            this.txtCopies.TextChanged += new System.EventHandler(this.txtCopies_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(174, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Genre";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(177, 140);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(155, 22);
            this.txtGenre.TabIndex = 14;
            // 
            // btnVideoADd
            // 
            this.btnVideoADd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVideoADd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoADd.ForeColor = System.Drawing.Color.White;
            this.btnVideoADd.Location = new System.Drawing.Point(6, 168);
            this.btnVideoADd.Name = "btnVideoADd";
            this.btnVideoADd.Size = new System.Drawing.Size(158, 36);
            this.btnVideoADd.TabIndex = 8;
            this.btnVideoADd.Text = "Video Add";
            this.btnVideoADd.UseVisualStyleBackColor = false;
            this.btnVideoADd.Click += new System.EventHandler(this.btnVideoADd_Click);
            // 
            // btnVideoDelete
            // 
            this.btnVideoDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVideoDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoDelete.ForeColor = System.Drawing.Color.White;
            this.btnVideoDelete.Location = new System.Drawing.Point(174, 168);
            this.btnVideoDelete.Name = "btnVideoDelete";
            this.btnVideoDelete.Size = new System.Drawing.Size(158, 36);
            this.btnVideoDelete.TabIndex = 16;
            this.btnVideoDelete.Text = "Video Delete";
            this.btnVideoDelete.UseVisualStyleBackColor = false;
            this.btnVideoDelete.Click += new System.EventHandler(this.btnVideoDelete_Click);
            // 
            // btnVideoUpdate
            // 
            this.btnVideoUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVideoUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoUpdate.ForeColor = System.Drawing.Color.White;
            this.btnVideoUpdate.Location = new System.Drawing.Point(6, 210);
            this.btnVideoUpdate.Name = "btnVideoUpdate";
            this.btnVideoUpdate.Size = new System.Drawing.Size(158, 36);
            this.btnVideoUpdate.TabIndex = 18;
            this.btnVideoUpdate.Text = "Video Update";
            this.btnVideoUpdate.UseVisualStyleBackColor = false;
            this.btnVideoUpdate.Click += new System.EventHandler(this.btnVideoUpdate_Click);
            // 
            // btnBestVideo
            // 
            this.btnBestVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBestVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestVideo.ForeColor = System.Drawing.Color.White;
            this.btnBestVideo.Location = new System.Drawing.Point(174, 210);
            this.btnBestVideo.Name = "btnBestVideo";
            this.btnBestVideo.Size = new System.Drawing.Size(158, 36);
            this.btnBestVideo.TabIndex = 19;
            this.btnBestVideo.Text = "Best Video";
            this.btnBestVideo.UseVisualStyleBackColor = false;
            this.btnBestVideo.Click += new System.EventHandler(this.btnBestVideo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox3.Controls.Add(this.btnVideoDel);
            this.groupBox3.Controls.Add(this.btnVideoReturn);
            this.groupBox3.Controls.Add(this.btnVideoIssue);
            this.groupBox3.Controls.Add(this.ReturnDate);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.BookingDate);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblCustomerID);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lblVideoID);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox3.Location = new System.Drawing.Point(793, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 264);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rental";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Video ID";
            // 
            // lblVideoID
            // 
            this.lblVideoID.AutoSize = true;
            this.lblVideoID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVideoID.Location = new System.Drawing.Point(108, 24);
            this.lblVideoID.Name = "lblVideoID";
            this.lblVideoID.Size = new System.Drawing.Size(0, 20);
            this.lblVideoID.TabIndex = 1;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomerID.Location = new System.Drawing.Point(111, 58);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(0, 20);
            this.lblCustomerID.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Customer ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Booking Date";
            // 
            // BookingDate
            // 
            this.BookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BookingDate.Location = new System.Drawing.Point(112, 84);
            this.BookingDate.Name = "BookingDate";
            this.BookingDate.Size = new System.Drawing.Size(102, 26);
            this.BookingDate.TabIndex = 5;
            // 
            // ReturnDate
            // 
            this.ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnDate.Location = new System.Drawing.Point(112, 118);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(102, 26);
            this.ReturnDate.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Return Date";
            // 
            // btnVideoIssue
            // 
            this.btnVideoIssue.BackColor = System.Drawing.Color.Teal;
            this.btnVideoIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoIssue.ForeColor = System.Drawing.Color.White;
            this.btnVideoIssue.Location = new System.Drawing.Point(11, 150);
            this.btnVideoIssue.Name = "btnVideoIssue";
            this.btnVideoIssue.Size = new System.Drawing.Size(179, 30);
            this.btnVideoIssue.TabIndex = 20;
            this.btnVideoIssue.Text = "Issue";
            this.btnVideoIssue.UseVisualStyleBackColor = false;
            this.btnVideoIssue.Click += new System.EventHandler(this.btnVideoIssue_Click);
            // 
            // btnVideoReturn
            // 
            this.btnVideoReturn.BackColor = System.Drawing.Color.Teal;
            this.btnVideoReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoReturn.ForeColor = System.Drawing.Color.White;
            this.btnVideoReturn.Location = new System.Drawing.Point(11, 186);
            this.btnVideoReturn.Name = "btnVideoReturn";
            this.btnVideoReturn.Size = new System.Drawing.Size(179, 30);
            this.btnVideoReturn.TabIndex = 21;
            this.btnVideoReturn.Text = "Return";
            this.btnVideoReturn.UseVisualStyleBackColor = false;
            this.btnVideoReturn.Click += new System.EventHandler(this.btnVideoReturn_Click);
            // 
            // btnVideoDel
            // 
            this.btnVideoDel.BackColor = System.Drawing.Color.Teal;
            this.btnVideoDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoDel.ForeColor = System.Drawing.Color.White;
            this.btnVideoDel.Location = new System.Drawing.Point(11, 222);
            this.btnVideoDel.Name = "btnVideoDel";
            this.btnVideoDel.Size = new System.Drawing.Size(179, 30);
            this.btnVideoDel.TabIndex = 22;
            this.btnVideoDel.Text = "Delete";
            this.btnVideoDel.UseVisualStyleBackColor = false;
            this.btnVideoDel.Click += new System.EventHandler(this.btnVideoDel_Click);
            // 
            // Database
            // 
            this.Database.BackgroundColor = System.Drawing.Color.Olive;
            this.Database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Database.Location = new System.Drawing.Point(201, 307);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(806, 134);
            this.Database.TabIndex = 4;
            this.Database.DoubleClick += new System.EventHandler(this.Database_DoubleClick);
            // 
            // lblRentalID
            // 
            this.lblRentalID.AutoSize = true;
            this.lblRentalID.Location = new System.Drawing.Point(868, 280);
            this.lblRentalID.Name = "lblRentalID";
            this.lblRentalID.Size = new System.Drawing.Size(0, 13);
            this.lblRentalID.TabIndex = 23;
            // 
            // rbCustomer
            // 
            this.rbCustomer.AutoSize = true;
            this.rbCustomer.BackColor = System.Drawing.Color.Teal;
            this.rbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCustomer.ForeColor = System.Drawing.Color.White;
            this.rbCustomer.Location = new System.Drawing.Point(13, 19);
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Size = new System.Drawing.Size(83, 20);
            this.rbCustomer.TabIndex = 24;
            this.rbCustomer.TabStop = true;
            this.rbCustomer.Text = "Customer";
            this.rbCustomer.UseVisualStyleBackColor = false;
            // 
            // rbVideo
            // 
            this.rbVideo.AutoSize = true;
            this.rbVideo.BackColor = System.Drawing.Color.Teal;
            this.rbVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVideo.ForeColor = System.Drawing.Color.White;
            this.rbVideo.Location = new System.Drawing.Point(13, 70);
            this.rbVideo.Name = "rbVideo";
            this.rbVideo.Size = new System.Drawing.Size(62, 20);
            this.rbVideo.TabIndex = 25;
            this.rbVideo.TabStop = true;
            this.rbVideo.Text = "Video";
            this.rbVideo.UseVisualStyleBackColor = false;
            // 
            // rbRent
            // 
            this.rbRent.AutoSize = true;
            this.rbRent.BackColor = System.Drawing.Color.Teal;
            this.rbRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRent.ForeColor = System.Drawing.Color.White;
            this.rbRent.Location = new System.Drawing.Point(13, 124);
            this.rbRent.Name = "rbRent";
            this.rbRent.Size = new System.Drawing.Size(65, 20);
            this.rbRent.TabIndex = 26;
            this.rbRent.TabStop = true;
            this.rbRent.Text = "Rental";
            this.rbRent.UseVisualStyleBackColor = false;
            // 
            // btnBestCustomer
            // 
            this.btnBestCustomer.BackColor = System.Drawing.Color.Teal;
            this.btnBestCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestCustomer.ForeColor = System.Drawing.Color.White;
            this.btnBestCustomer.Location = new System.Drawing.Point(20, 260);
            this.btnBestCustomer.Name = "btnBestCustomer";
            this.btnBestCustomer.Size = new System.Drawing.Size(171, 30);
            this.btnBestCustomer.TabIndex = 8;
            this.btnBestCustomer.Text = "Best Customer";
            this.btnBestCustomer.UseVisualStyleBackColor = false;
            this.btnBestCustomer.Click += new System.EventHandler(this.btnBestCustomer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1022, 445);
            this.Controls.Add(this.lblRentalID);
            this.Controls.Add(this.Database);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Database)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCustomerPanel;
        private System.Windows.Forms.Button btnVideoPanel;
        private System.Windows.Forms.Button btnRentalPanel;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.Button btnCustomerUpdate;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRatting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Button btnVideoADd;
        private System.Windows.Forms.Button btnVideoDelete;
        private System.Windows.Forms.Button btnVideoUpdate;
        private System.Windows.Forms.Button btnBestVideo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblVideoID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker BookingDate;
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnVideoIssue;
        private System.Windows.Forms.Button btnVideoDel;
        private System.Windows.Forms.Button btnVideoReturn;
        private System.Windows.Forms.DataGridView Database;
        private System.Windows.Forms.Label lblRentalID;
        private System.Windows.Forms.RadioButton rbCustomer;
        private System.Windows.Forms.RadioButton rbVideo;
        private System.Windows.Forms.RadioButton rbRent;
        private System.Windows.Forms.Button btnBestCustomer;
    }
}

