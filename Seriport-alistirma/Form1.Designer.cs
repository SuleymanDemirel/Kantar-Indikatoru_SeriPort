namespace Seriport_alistirma
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sp = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblBaglanti = new System.Windows.Forms.Label();
            this.tbxFirma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.report1 = new FastReport.Report();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxIplikCinsi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxNetKG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnManuelYazdir = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.dgwTablo = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxBobinAdet = new System.Windows.Forms.TextBox();
            this.tbxYazdirAdet = new System.Windows.Forms.TextBox();
            this.tbxIplikKodu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxDara = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbxGelenVeri = new System.Windows.Forms.TextBox();
            this.dgwFirmalar = new System.Windows.Forms.DataGridView();
            this.btnFirmaSil = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tbxFirmaAra = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxFirmaEkle = new System.Windows.Forms.TextBox();
            this.btnFirmaEkle = new System.Windows.Forms.Button();
            this.tbxToplamKg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTablo)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFirmalar)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // sp
            // 
            this.sp.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.sp_DataReceived_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblBaglanti);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(6, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(122, 63);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bağlantı Durumu";
            // 
            // lblBaglanti
            // 
            this.lblBaglanti.AutoSize = true;
            this.lblBaglanti.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaglanti.Location = new System.Drawing.Point(6, 32);
            this.lblBaglanti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBaglanti.Name = "lblBaglanti";
            this.lblBaglanti.Size = new System.Drawing.Size(19, 13);
            this.lblBaglanti.TabIndex = 8;
            this.lblBaglanti.Text = "....";
            // 
            // tbxFirma
            // 
            this.tbxFirma.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxFirma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxFirma.Enabled = false;
            this.tbxFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxFirma.Location = new System.Drawing.Point(106, 355);
            this.tbxFirma.Margin = new System.Windows.Forms.Padding(2);
            this.tbxFirma.Multiline = true;
            this.tbxFirma.Name = "tbxFirma";
            this.tbxFirma.Size = new System.Drawing.Size(271, 27);
            this.tbxFirma.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(38, 361);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "FİRMA :\r\n";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 329);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 23);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(32, 334);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "TARİH : ";
            // 
            // report1
            // 
            this.report1.NeedRefresh = false;
            this.report1.ReportResourceString = resources.GetString("report1.ReportResourceString");
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 389);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "İPLİK CİNSİ :\r\n";
            // 
            // tbxIplikCinsi
            // 
            this.tbxIplikCinsi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxIplikCinsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxIplikCinsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxIplikCinsi.Location = new System.Drawing.Point(106, 385);
            this.tbxIplikCinsi.Margin = new System.Windows.Forms.Padding(2);
            this.tbxIplikCinsi.Multiline = true;
            this.tbxIplikCinsi.Name = "tbxIplikCinsi";
            this.tbxIplikCinsi.Size = new System.Drawing.Size(271, 27);
            this.tbxIplikCinsi.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(846, 292);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "NET KG";
            // 
            // tbxNetKG
            // 
            this.tbxNetKG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNetKG.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxNetKG.Enabled = false;
            this.tbxNetKG.Font = new System.Drawing.Font("Tahoma", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxNetKG.ForeColor = System.Drawing.Color.Red;
            this.tbxNetKG.Location = new System.Drawing.Point(842, 315);
            this.tbxNetKG.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNetKG.Multiline = true;
            this.tbxNetKG.Name = "tbxNetKG";
            this.tbxNetKG.Size = new System.Drawing.Size(319, 98);
            this.tbxNetKG.TabIndex = 17;
            this.tbxNetKG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(637, 357);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 14);
            this.label5.TabIndex = 28;
            this.label5.Text = "YAZDIRILACAK MİKTAR\r\n";
            // 
            // btnManuelYazdir
            // 
            this.btnManuelYazdir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnManuelYazdir.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnManuelYazdir.Image = ((System.Drawing.Image)(resources.GetObject("btnManuelYazdir.Image")));
            this.btnManuelYazdir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManuelYazdir.Location = new System.Drawing.Point(9, 610);
            this.btnManuelYazdir.Margin = new System.Windows.Forms.Padding(2);
            this.btnManuelYazdir.Name = "btnManuelYazdir";
            this.btnManuelYazdir.Size = new System.Drawing.Size(368, 40);
            this.btnManuelYazdir.TabIndex = 34;
            this.btnManuelYazdir.Text = "SEÇİLİ OLANI YAZDIR";
            this.btnManuelYazdir.UseVisualStyleBackColor = true;
            this.btnManuelYazdir.Click += new System.EventHandler(this.btnManuelYazdir_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUrunSil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUrunSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunSil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunSil.ForeColor = System.Drawing.Color.DarkRed;
            this.btnUrunSil.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunSil.Image")));
            this.btnUrunSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunSil.Location = new System.Drawing.Point(1175, 612);
            this.btnUrunSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(193, 41);
            this.btnUrunSil.TabIndex = 21;
            this.btnUrunSil.Text = "SEÇİLİ ETİKETİ SİL\r\n";
            this.btnUrunSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunSil.UseVisualStyleBackColor = false;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // dgwTablo
            // 
            this.dgwTablo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwTablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTablo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTablo.Location = new System.Drawing.Point(6, 426);
            this.dgwTablo.Margin = new System.Windows.Forms.Padding(2);
            this.dgwTablo.Name = "dgwTablo";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwTablo.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgwTablo.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgwTablo.RowTemplate.Height = 24;
            this.dgwTablo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwTablo.Size = new System.Drawing.Size(1362, 180);
            this.dgwTablo.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(388, 358);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 14);
            this.label3.TabIndex = 24;
            this.label3.Text = "BOBİN ADET :\r\n";
            // 
            // tbxBobinAdet
            // 
            this.tbxBobinAdet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxBobinAdet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxBobinAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBobinAdet.Location = new System.Drawing.Point(484, 355);
            this.tbxBobinAdet.Margin = new System.Windows.Forms.Padding(2);
            this.tbxBobinAdet.Multiline = true;
            this.tbxBobinAdet.Name = "tbxBobinAdet";
            this.tbxBobinAdet.Size = new System.Drawing.Size(65, 27);
            this.tbxBobinAdet.TabIndex = 25;
            // 
            // tbxYazdirAdet
            // 
            this.tbxYazdirAdet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxYazdirAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxYazdirAdet.Location = new System.Drawing.Point(793, 355);
            this.tbxYazdirAdet.Margin = new System.Windows.Forms.Padding(2);
            this.tbxYazdirAdet.Multiline = true;
            this.tbxYazdirAdet.Name = "tbxYazdirAdet";
            this.tbxYazdirAdet.Size = new System.Drawing.Size(45, 27);
            this.tbxYazdirAdet.TabIndex = 27;
            this.tbxYazdirAdet.Text = "1";
            this.tbxYazdirAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxIplikKodu
            // 
            this.tbxIplikKodu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxIplikKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxIplikKodu.Location = new System.Drawing.Point(485, 385);
            this.tbxIplikKodu.Margin = new System.Windows.Forms.Padding(2);
            this.tbxIplikKodu.Multiline = true;
            this.tbxIplikKodu.Name = "tbxIplikKodu";
            this.tbxIplikKodu.Size = new System.Drawing.Size(353, 27);
            this.tbxIplikKodu.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(389, 388);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 14);
            this.label2.TabIndex = 22;
            this.label2.Text = "İPLİK KODU :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(78, 81);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Dara : ";
            this.label9.Visible = false;
            // 
            // tbxDara
            // 
            this.tbxDara.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxDara.Font = new System.Drawing.Font("Tahoma", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxDara.ForeColor = System.Drawing.Color.Yellow;
            this.tbxDara.Location = new System.Drawing.Point(81, 101);
            this.tbxDara.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDara.Multiline = true;
            this.tbxDara.Name = "tbxDara";
            this.tbxDara.Size = new System.Drawing.Size(42, 30);
            this.tbxDara.TabIndex = 26;
            this.tbxDara.Text = "0";
            this.tbxDara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxDara.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 138);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 24);
            this.button1.TabIndex = 26;
            this.button1.Text = "Rapor Design";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbxGelenVeri);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(10, 84);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(63, 52);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gelen Veriler";
            this.groupBox4.Visible = false;
            // 
            // tbxGelenVeri
            // 
            this.tbxGelenVeri.Enabled = false;
            this.tbxGelenVeri.Location = new System.Drawing.Point(7, 16);
            this.tbxGelenVeri.Margin = new System.Windows.Forms.Padding(2);
            this.tbxGelenVeri.Multiline = true;
            this.tbxGelenVeri.Name = "tbxGelenVeri";
            this.tbxGelenVeri.Size = new System.Drawing.Size(48, 29);
            this.tbxGelenVeri.TabIndex = 33;
            // 
            // dgwFirmalar
            // 
            this.dgwFirmalar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwFirmalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwFirmalar.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwFirmalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFirmalar.Location = new System.Drawing.Point(6, 77);
            this.dgwFirmalar.Margin = new System.Windows.Forms.Padding(2);
            this.dgwFirmalar.Name = "dgwFirmalar";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwFirmalar.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgwFirmalar.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgwFirmalar.RowTemplate.Height = 24;
            this.dgwFirmalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwFirmalar.Size = new System.Drawing.Size(1362, 186);
            this.dgwFirmalar.TabIndex = 22;
            this.dgwFirmalar.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwFirmalar_CellEnter);
            // 
            // btnFirmaSil
            // 
            this.btnFirmaSil.BackColor = System.Drawing.SystemColors.Control;
            this.btnFirmaSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFirmaSil.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaSil.ForeColor = System.Drawing.Color.Black;
            this.btnFirmaSil.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmaSil.Image")));
            this.btnFirmaSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirmaSil.Location = new System.Drawing.Point(11, 273);
            this.btnFirmaSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirmaSil.Name = "btnFirmaSil";
            this.btnFirmaSil.Size = new System.Drawing.Size(144, 40);
            this.btnFirmaSil.TabIndex = 39;
            this.btnFirmaSil.Text = "FİRMA VE ETİKET BİLGİLERİNİ SİL";
            this.btnFirmaSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFirmaSil.UseVisualStyleBackColor = false;
            this.btnFirmaSil.Click += new System.EventHandler(this.btnFirmaSil_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tbxFirmaAra);
            this.groupBox8.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupBox8.Location = new System.Drawing.Point(889, 6);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox8.Size = new System.Drawing.Size(323, 67);
            this.groupBox8.TabIndex = 36;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "ARAMA YAP";
            // 
            // tbxFirmaAra
            // 
            this.tbxFirmaAra.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxFirmaAra.Location = new System.Drawing.Point(10, 26);
            this.tbxFirmaAra.Margin = new System.Windows.Forms.Padding(2);
            this.tbxFirmaAra.Multiline = true;
            this.tbxFirmaAra.Name = "tbxFirmaAra";
            this.tbxFirmaAra.Size = new System.Drawing.Size(309, 27);
            this.tbxFirmaAra.TabIndex = 25;
            this.tbxFirmaAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.tbxFirmaEkle);
            this.groupBox7.Controls.Add(this.btnFirmaEkle);
            this.groupBox7.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox7.Location = new System.Drawing.Point(242, 3);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(588, 70);
            this.groupBox7.TabIndex = 32;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "FİRMA EKLE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(16, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "FİRMA İSMİ : ";
            // 
            // tbxFirmaEkle
            // 
            this.tbxFirmaEkle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxFirmaEkle.Location = new System.Drawing.Point(143, 26);
            this.tbxFirmaEkle.Margin = new System.Windows.Forms.Padding(2);
            this.tbxFirmaEkle.Multiline = true;
            this.tbxFirmaEkle.Name = "tbxFirmaEkle";
            this.tbxFirmaEkle.Size = new System.Drawing.Size(308, 27);
            this.tbxFirmaEkle.TabIndex = 31;
            // 
            // btnFirmaEkle
            // 
            this.btnFirmaEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnFirmaEkle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnFirmaEkle.ForeColor = System.Drawing.Color.Black;
            this.btnFirmaEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmaEkle.Image")));
            this.btnFirmaEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirmaEkle.Location = new System.Drawing.Point(454, 26);
            this.btnFirmaEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirmaEkle.Name = "btnFirmaEkle";
            this.btnFirmaEkle.Size = new System.Drawing.Size(126, 27);
            this.btnFirmaEkle.TabIndex = 30;
            this.btnFirmaEkle.Text = "Ekle";
            this.btnFirmaEkle.UseVisualStyleBackColor = false;
            this.btnFirmaEkle.Click += new System.EventHandler(this.btnFirmaEkle_Click);
            // 
            // tbxToplamKg
            // 
            this.tbxToplamKg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxToplamKg.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxToplamKg.Enabled = false;
            this.tbxToplamKg.Font = new System.Drawing.Font("Tahoma", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxToplamKg.ForeColor = System.Drawing.Color.LimeGreen;
            this.tbxToplamKg.Location = new System.Drawing.Point(1164, 329);
            this.tbxToplamKg.Margin = new System.Windows.Forms.Padding(2);
            this.tbxToplamKg.Multiline = true;
            this.tbxToplamKg.Name = "tbxToplamKg";
            this.tbxToplamKg.Size = new System.Drawing.Size(203, 69);
            this.tbxToplamKg.TabIndex = 41;
            this.tbxToplamKg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1208, 301);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "TOPLAM KG";
            // 
            // btnYeni
            // 
            this.btnYeni.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnYeni.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYeni.Location = new System.Drawing.Point(544, 613);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(2);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(368, 40);
            this.btnYeni.TabIndex = 43;
            this.btnYeni.Text = "SIFIRLA";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 661);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxToplamKg);
            this.Controls.Add(this.dgwFirmalar);
            this.Controls.Add(this.btnFirmaSil);
            this.Controls.Add(this.btnManuelYazdir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgwTablo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.tbxDara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxBobinAdet);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.tbxYazdirAdet);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.tbxIplikKodu);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxFirma);
            this.Controls.Add(this.tbxNetKG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbxIplikCinsi);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Baskül - Etiket Uygulama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTablo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFirmalar)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort sp;
        private System.Windows.Forms.Label lblBaglanti;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxFirma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxIplikCinsi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxNetKG;
        private System.Windows.Forms.DataGridView dgwTablo;
        public FastReport.Report report1;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgwFirmalar;
        private System.Windows.Forms.TextBox tbxFirmaAra;
        private System.Windows.Forms.Button btnFirmaEkle;
        private System.Windows.Forms.TextBox tbxFirmaEkle;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnFirmaSil;
        public System.Windows.Forms.TextBox tbxGelenVeri;
        private System.Windows.Forms.TextBox tbxIplikKodu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxBobinAdet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxYazdirAdet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxDara;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnManuelYazdir;
        private System.Windows.Forms.TextBox tbxToplamKg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYeni;
    }
}

