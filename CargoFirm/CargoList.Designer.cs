namespace CargoFirm
{
    partial class CargoList
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
            this.lblMemberName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSenderName = new System.Windows.Forms.TextBox();
            this.txtSenderSurname = new System.Windows.Forms.TextBox();
            this.txtSenderTelephone = new System.Windows.Forms.TextBox();
            this.txtReceiverName = new System.Windows.Forms.TextBox();
            this.txtReceiverSurname = new System.Windows.Forms.TextBox();
            this.txtReceiverTelephone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCBStatus = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgwList2 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SENDERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SENDERSURNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RECIEVERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RECIEVERSURNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISSENDERPAYS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISDELIVERED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwList2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(1417, 13);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(0, 25);
            this.lblMemberName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gönderici Adı ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gönderici Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gönderici Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(790, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Alıcı Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(790, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Alıcı Soyadı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(790, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Alıcı Telefon";
            // 
            // txtSenderName
            // 
            this.txtSenderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenderName.Location = new System.Drawing.Point(346, 115);
            this.txtSenderName.Name = "txtSenderName";
            this.txtSenderName.Size = new System.Drawing.Size(292, 38);
            this.txtSenderName.TabIndex = 7;
            // 
            // txtSenderSurname
            // 
            this.txtSenderSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenderSurname.Location = new System.Drawing.Point(346, 252);
            this.txtSenderSurname.Name = "txtSenderSurname";
            this.txtSenderSurname.Size = new System.Drawing.Size(292, 38);
            this.txtSenderSurname.TabIndex = 8;
            // 
            // txtSenderTelephone
            // 
            this.txtSenderTelephone.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenderTelephone.Location = new System.Drawing.Point(346, 397);
            this.txtSenderTelephone.Name = "txtSenderTelephone";
            this.txtSenderTelephone.Size = new System.Drawing.Size(292, 39);
            this.txtSenderTelephone.TabIndex = 9;
            this.txtSenderTelephone.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtReceiverName
            // 
            this.txtReceiverName.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverName.Location = new System.Drawing.Point(958, 132);
            this.txtReceiverName.Name = "txtReceiverName";
            this.txtReceiverName.Size = new System.Drawing.Size(269, 39);
            this.txtReceiverName.TabIndex = 10;
            // 
            // txtReceiverSurname
            // 
            this.txtReceiverSurname.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverSurname.Location = new System.Drawing.Point(958, 249);
            this.txtReceiverSurname.Name = "txtReceiverSurname";
            this.txtReceiverSurname.Size = new System.Drawing.Size(269, 39);
            this.txtReceiverSurname.TabIndex = 11;
            // 
            // txtReceiverTelephone
            // 
            this.txtReceiverTelephone.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverTelephone.Location = new System.Drawing.Point(958, 378);
            this.txtReceiverTelephone.Name = "txtReceiverTelephone";
            this.txtReceiverTelephone.Size = new System.Drawing.Size(269, 39);
            this.txtReceiverTelephone.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Göndericinin:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(893, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Alıcının:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 490);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Durum";
            // 
            // txtCBStatus
            // 
            this.txtCBStatus.FormattingEnabled = true;
            this.txtCBStatus.Items.AddRange(new object[] {
            "Bekliyor.",
            "Teslim Edildi.",
            "Hepsi"});
            this.txtCBStatus.Location = new System.Drawing.Point(346, 490);
            this.txtCBStatus.Name = "txtCBStatus";
            this.txtCBStatus.Size = new System.Drawing.Size(292, 33);
            this.txtCBStatus.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(700, 490);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(293, 63);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgwList2
            // 
            this.dgwList2.AllowUserToAddRows = false;
            this.dgwList2.AllowUserToDeleteRows = false;
            this.dgwList2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgwList2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwList2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SENDERNAME,
            this.SENDERSURNAME,
            this.RECIEVERNAME,
            this.RECIEVERSURNAME,
            this.PRICE,
            this.ISSENDERPAYS,
            this.ISDELIVERED});
            this.dgwList2.Location = new System.Drawing.Point(39, 676);
            this.dgwList2.Name = "dgwList2";
            this.dgwList2.RowTemplate.Height = 33;
            this.dgwList2.Size = new System.Drawing.Size(1629, 651);
            this.dgwList2.TabIndex = 20;
            this.dgwList2.VirtualMode = true;
            this.dgwList2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwList2_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Gönderi Numarası";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 211;
            // 
            // SENDERNAME
            // 
            this.SENDERNAME.DataPropertyName = "SENDERNAME";
            this.SENDERNAME.HeaderText = "Gön. Ad";
            this.SENDERNAME.Name = "SENDERNAME";
            this.SENDERNAME.ReadOnly = true;
            this.SENDERNAME.Width = 125;
            // 
            // SENDERSURNAME
            // 
            this.SENDERSURNAME.DataPropertyName = "SENDERSURNAME";
            this.SENDERSURNAME.HeaderText = "Gön. Soyad";
            this.SENDERSURNAME.Name = "SENDERSURNAME";
            this.SENDERSURNAME.ReadOnly = true;
            this.SENDERSURNAME.Width = 157;
            // 
            // RECIEVERNAME
            // 
            this.RECIEVERNAME.DataPropertyName = "RECIEVERNAME";
            this.RECIEVERNAME.HeaderText = "Al. Ad";
            this.RECIEVERNAME.Name = "RECIEVERNAME";
            this.RECIEVERNAME.ReadOnly = true;
            this.RECIEVERNAME.Width = 83;
            // 
            // RECIEVERSURNAME
            // 
            this.RECIEVERSURNAME.DataPropertyName = "RECIEVERSURNAME";
            this.RECIEVERSURNAME.HeaderText = "Al.Soyadı";
            this.RECIEVERSURNAME.Name = "RECIEVERSURNAME";
            this.RECIEVERSURNAME.ReadOnly = true;
            this.RECIEVERSURNAME.Width = 148;
            // 
            // PRICE
            // 
            this.PRICE.DataPropertyName = "PRICE";
            this.PRICE.HeaderText = "Fiyat";
            this.PRICE.Name = "PRICE";
            this.PRICE.ReadOnly = true;
            this.PRICE.Width = 104;
            // 
            // ISSENDERPAYS
            // 
            this.ISSENDERPAYS.DataPropertyName = "ISSENDERPAYS";
            this.ISSENDERPAYS.HeaderText = "Ödeme";
            this.ISSENDERPAYS.Name = "ISSENDERPAYS";
            this.ISSENDERPAYS.ReadOnly = true;
            this.ISSENDERPAYS.Width = 126;
            // 
            // ISDELIVERED
            // 
            this.ISDELIVERED.DataPropertyName = "ISDELIVERED";
            this.ISDELIVERED.HeaderText = "Durum";
            this.ISDELIVERED.Name = "ISDELIVERED";
            this.ISDELIVERED.ReadOnly = true;
            this.ISDELIVERED.Width = 120;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(1037, 490);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(233, 69);
            this.btnAddNew.TabIndex = 21;
            this.btnAddNew.Text = "Yeni Ekle";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // CargoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1725, 1396);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dgwList2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCBStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtReceiverTelephone);
            this.Controls.Add(this.txtReceiverSurname);
            this.Controls.Add(this.txtReceiverName);
            this.Controls.Add(this.txtSenderTelephone);
            this.Controls.Add(this.txtSenderSurname);
            this.Controls.Add(this.txtSenderName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMemberName);
            this.Name = "CargoList";
            this.Text = "CargoList";
            this.Load += new System.EventHandler(this.CargoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwList2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSenderName;
        private System.Windows.Forms.TextBox txtSenderSurname;
        private System.Windows.Forms.TextBox txtSenderTelephone;
        private System.Windows.Forms.TextBox txtReceiverName;
        private System.Windows.Forms.TextBox txtReceiverSurname;
        private System.Windows.Forms.TextBox txtReceiverTelephone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtCBStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgwList2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SENDERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SENDERSURNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn RECIEVERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn RECIEVERSURNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISSENDERPAYS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISDELIVERED;
        private System.Windows.Forms.Button btnAddNew;
    }
}