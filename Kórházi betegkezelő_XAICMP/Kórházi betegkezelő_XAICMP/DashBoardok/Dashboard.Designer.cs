namespace Kórházi_betegkezelő_XAICMP
{
    partial class Dashboard
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
            this.btnPáciens = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDiagnózis = new System.Windows.Forms.Button();
            this.btnÖsszesPáciens = new System.Windows.Forms.Button();
            this.btnRandomTipp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKilépés = new System.Windows.Forms.Button();
            this.lbl1nyil = new System.Windows.Forms.Label();
            this.lbl2nyil = new System.Windows.Forms.Label();
            this.lbl3nyil = new System.Windows.Forms.Label();
            this.lbl4nyil = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbetegid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnMentés = new System.Windows.Forms.Button();
            this.txtBetegség = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Név = new System.Windows.Forms.Label();
            this.comboboxNem = new System.Windows.Forms.ComboBox();
            this.txtCím = new System.Windows.Forms.TextBox();
            this.txtSzám = new System.Windows.Forms.TextBox();
            this.txtKor = new System.Windows.Forms.TextBox();
            this.txtVércsoport = new System.Windows.Forms.TextBox();
            this.txtNév = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnVicc = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnTovábbiinfómentés = new System.Windows.Forms.Button();
            this.combomutettipus = new System.Windows.Forms.ComboBox();
            this.combokellmutet = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtgyógyszer = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtdiagnózis = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtjelenség = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.hospitalDataSet = new Kórházi_betegkezelő_XAICMP.hospitalDataSet();
            this.addPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addPatientTableAdapter = new Kórházi_betegkezelő_XAICMP.hospitalDataSetTableAdapters.AddPatientTableAdapter();
            this.tableAdapterManager = new Kórházi_betegkezelő_XAICMP.hospitalDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPatientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPáciens
            // 
            this.btnPáciens.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPáciens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPáciens.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPáciens.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPáciens.Location = new System.Drawing.Point(27, 59);
            this.btnPáciens.Margin = new System.Windows.Forms.Padding(10);
            this.btnPáciens.Name = "btnPáciens";
            this.btnPáciens.Size = new System.Drawing.Size(136, 44);
            this.btnPáciens.TabIndex = 0;
            this.btnPáciens.Text = "+ Új páciens";
            this.btnPáciens.UseVisualStyleBackColor = false;
            this.btnPáciens.Click += new System.EventHandler(this.btnPáciens_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "FUNKCIÓK";
            // 
            // btnDiagnózis
            // 
            this.btnDiagnózis.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDiagnózis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagnózis.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDiagnózis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDiagnózis.Location = new System.Drawing.Point(27, 117);
            this.btnDiagnózis.Margin = new System.Windows.Forms.Padding(10);
            this.btnDiagnózis.Name = "btnDiagnózis";
            this.btnDiagnózis.Size = new System.Drawing.Size(136, 44);
            this.btnDiagnózis.TabIndex = 5;
            this.btnDiagnózis.Text = "+ Diagnózis infó";
            this.btnDiagnózis.UseVisualStyleBackColor = false;
            this.btnDiagnózis.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnÖsszesPáciens
            // 
            this.btnÖsszesPáciens.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnÖsszesPáciens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÖsszesPáciens.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnÖsszesPáciens.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnÖsszesPáciens.Location = new System.Drawing.Point(27, 173);
            this.btnÖsszesPáciens.Margin = new System.Windows.Forms.Padding(10);
            this.btnÖsszesPáciens.Name = "btnÖsszesPáciens";
            this.btnÖsszesPáciens.Size = new System.Drawing.Size(136, 44);
            this.btnÖsszesPáciens.TabIndex = 6;
            this.btnÖsszesPáciens.Text = "Összes páciens";
            this.btnÖsszesPáciens.UseVisualStyleBackColor = false;
            this.btnÖsszesPáciens.Click += new System.EventHandler(this.btnÖsszesPáciens_Click);
            // 
            // btnRandomTipp
            // 
            this.btnRandomTipp.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRandomTipp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomTipp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRandomTipp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRandomTipp.Location = new System.Drawing.Point(27, 231);
            this.btnRandomTipp.Margin = new System.Windows.Forms.Padding(10);
            this.btnRandomTipp.Name = "btnRandomTipp";
            this.btnRandomTipp.Size = new System.Drawing.Size(136, 44);
            this.btnRandomTipp.TabIndex = 7;
            this.btnRandomTipp.Text = "Orvosi random viccek";
            this.btnRandomTipp.UseVisualStyleBackColor = false;
            this.btnRandomTipp.Click += new System.EventHandler(this.btnRandomTipp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kórházi_betegkezelő_XAICMP.Properties.Resources.patient_lying_bed_during_intensive_therapy_74855_7774;
            this.pictureBox1.Location = new System.Drawing.Point(181, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 346);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(300, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "KÓRHÁZI PÁCIENS KEZELŐ";
            // 
            // btnKilépés
            // 
            this.btnKilépés.Location = new System.Drawing.Point(56, 288);
            this.btnKilépés.Name = "btnKilépés";
            this.btnKilépés.Size = new System.Drawing.Size(75, 23);
            this.btnKilépés.TabIndex = 10;
            this.btnKilépés.Text = "Kilépés";
            this.btnKilépés.UseVisualStyleBackColor = true;
            this.btnKilépés.Click += new System.EventHandler(this.btnKilépés_Click);
            // 
            // lbl1nyil
            // 
            this.lbl1nyil.AutoSize = true;
            this.lbl1nyil.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1nyil.Location = new System.Drawing.Point(4, 70);
            this.lbl1nyil.Name = "lbl1nyil";
            this.lbl1nyil.Size = new System.Drawing.Size(19, 19);
            this.lbl1nyil.TabIndex = 11;
            this.lbl1nyil.Text = ">";
            // 
            // lbl2nyil
            // 
            this.lbl2nyil.AutoSize = true;
            this.lbl2nyil.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2nyil.Location = new System.Drawing.Point(4, 128);
            this.lbl2nyil.Name = "lbl2nyil";
            this.lbl2nyil.Size = new System.Drawing.Size(19, 19);
            this.lbl2nyil.TabIndex = 12;
            this.lbl2nyil.Text = ">";
            // 
            // lbl3nyil
            // 
            this.lbl3nyil.AutoSize = true;
            this.lbl3nyil.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3nyil.Location = new System.Drawing.Point(4, 184);
            this.lbl3nyil.Name = "lbl3nyil";
            this.lbl3nyil.Size = new System.Drawing.Size(19, 19);
            this.lbl3nyil.TabIndex = 13;
            this.lbl3nyil.Text = ">";
            // 
            // lbl4nyil
            // 
            this.lbl4nyil.AutoSize = true;
            this.lbl4nyil.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4nyil.Location = new System.Drawing.Point(4, 242);
            this.lbl4nyil.Name = "lbl4nyil";
            this.lbl4nyil.Size = new System.Drawing.Size(19, 19);
            this.lbl4nyil.TabIndex = 14;
            this.lbl4nyil.Text = ">";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtbetegid);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnMentés);
            this.panel1.Controls.Add(this.txtBetegség);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Név);
            this.panel1.Controls.Add(this.comboboxNem);
            this.panel1.Controls.Add(this.txtCím);
            this.panel1.Controls.Add(this.txtSzám);
            this.panel1.Controls.Add(this.txtKor);
            this.panel1.Controls.Add(this.txtVércsoport);
            this.panel1.Controls.Add(this.txtNév);
            this.panel1.Location = new System.Drawing.Point(181, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 346);
            this.panel1.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "BetegID";
            // 
            // txtbetegid
            // 
            this.txtbetegid.Location = new System.Drawing.Point(53, 306);
            this.txtbetegid.Name = "txtbetegid";
            this.txtbetegid.Size = new System.Drawing.Size(449, 20);
            this.txtbetegid.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(189, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(297, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "1. Lépés: Adj hozzá egy új pácienst!";
            // 
            // btnMentés
            // 
            this.btnMentés.Location = new System.Drawing.Point(508, 303);
            this.btnMentés.Name = "btnMentés";
            this.btnMentés.Size = new System.Drawing.Size(75, 23);
            this.btnMentés.TabIndex = 25;
            this.btnMentés.Text = "Mentés";
            this.btnMentés.UseVisualStyleBackColor = true;
            this.btnMentés.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBetegség
            // 
            this.txtBetegség.Location = new System.Drawing.Point(53, 257);
            this.txtBetegség.Name = "txtBetegség";
            this.txtBetegség.Size = new System.Drawing.Size(530, 20);
            this.txtBetegség.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Korábbi súlyos betegség:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Cím:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Kontakt szám:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Kor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Vércsoport:";
            // 
            // Név
            // 
            this.Név.AutoSize = true;
            this.Név.Location = new System.Drawing.Point(142, 43);
            this.Név.Name = "Név";
            this.Név.Size = new System.Drawing.Size(30, 13);
            this.Név.TabIndex = 17;
            this.Név.Text = "Név:";
            // 
            // comboboxNem
            // 
            this.comboboxNem.FormattingEnabled = true;
            this.comboboxNem.Items.AddRange(new object[] {
            "Férfi",
            "Nő",
            "Egyéb"});
            this.comboboxNem.Location = new System.Drawing.Point(178, 161);
            this.comboboxNem.Name = "comboboxNem";
            this.comboboxNem.Size = new System.Drawing.Size(417, 21);
            this.comboboxNem.TabIndex = 16;
            // 
            // txtCím
            // 
            this.txtCím.Location = new System.Drawing.Point(178, 72);
            this.txtCím.Name = "txtCím";
            this.txtCím.Size = new System.Drawing.Size(417, 20);
            this.txtCím.TabIndex = 4;
            // 
            // txtSzám
            // 
            this.txtSzám.Location = new System.Drawing.Point(178, 105);
            this.txtSzám.Name = "txtSzám";
            this.txtSzám.Size = new System.Drawing.Size(417, 20);
            this.txtSzám.TabIndex = 3;
            // 
            // txtKor
            // 
            this.txtKor.Location = new System.Drawing.Point(178, 134);
            this.txtKor.Name = "txtKor";
            this.txtKor.Size = new System.Drawing.Size(417, 20);
            this.txtKor.TabIndex = 2;
            // 
            // txtVércsoport
            // 
            this.txtVércsoport.Location = new System.Drawing.Point(178, 188);
            this.txtVércsoport.Name = "txtVércsoport";
            this.txtVércsoport.Size = new System.Drawing.Size(417, 20);
            this.txtVércsoport.TabIndex = 1;
            // 
            // txtNév
            // 
            this.txtNév.Location = new System.Drawing.Point(178, 40);
            this.txtNév.Name = "txtNév";
            this.txtNév.Size = new System.Drawing.Size(417, 20);
            this.txtNév.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnTovábbiinfómentés);
            this.panel2.Controls.Add(this.combomutettipus);
            this.panel2.Controls.Add(this.combokellmutet);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txtgyógyszer);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtdiagnózis);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtjelenség);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(181, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 346);
            this.panel2.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnExport);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 346);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.btnVicc);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(625, 346);
            this.panel4.TabIndex = 19;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(503, 346);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // btnVicc
            // 
            this.btnVicc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVicc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVicc.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVicc.Location = new System.Drawing.Point(531, 123);
            this.btnVicc.Name = "btnVicc";
            this.btnVicc.Size = new System.Drawing.Size(75, 99);
            this.btnVicc.TabIndex = 30;
            this.btnVicc.Text = "Mutasd a viccet";
            this.btnVicc.UseVisualStyleBackColor = false;
            this.btnVicc.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(505, 159);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(116, 21);
            this.btnExport.TabIndex = 19;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(238, 5);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(141, 20);
            this.label19.TabIndex = 18;
            this.label19.Text = "Páciens történet";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 29);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(497, 261);
            this.dataGridView2.TabIndex = 17;
            // 
            // btnTovábbiinfómentés
            // 
            this.btnTovábbiinfómentés.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTovábbiinfómentés.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTovábbiinfómentés.Location = new System.Drawing.Point(423, 293);
            this.btnTovábbiinfómentés.Name = "btnTovábbiinfómentés";
            this.btnTovábbiinfómentés.Size = new System.Drawing.Size(121, 33);
            this.btnTovábbiinfómentés.TabIndex = 16;
            this.btnTovábbiinfómentés.Text = "Mentés";
            this.btnTovábbiinfómentés.UseVisualStyleBackColor = false;
            this.btnTovábbiinfómentés.Click += new System.EventHandler(this.btnTovábbiinfómentés_Click);
            // 
            // combomutettipus
            // 
            this.combomutettipus.FormattingEnabled = true;
            this.combomutettipus.Items.AddRange(new object[] {
            "Sima",
            "Bonyolult",
            "Nincs"});
            this.combomutettipus.Location = new System.Drawing.Point(423, 257);
            this.combomutettipus.Name = "combomutettipus";
            this.combomutettipus.Size = new System.Drawing.Size(121, 21);
            this.combomutettipus.TabIndex = 29;
            // 
            // combokellmutet
            // 
            this.combokellmutet.FormattingEnabled = true;
            this.combokellmutet.Items.AddRange(new object[] {
            "Igen",
            "Nem"});
            this.combokellmutet.Location = new System.Drawing.Point(423, 218);
            this.combokellmutet.Name = "combokellmutet";
            this.combokellmutet.Size = new System.Drawing.Size(121, 21);
            this.combokellmutet.TabIndex = 28;
            this.combokellmutet.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(361, 260);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "Műtét típus";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(361, 221);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Kell műtét?";
            // 
            // txtgyógyszer
            // 
            this.txtgyógyszer.Location = new System.Drawing.Point(117, 290);
            this.txtgyógyszer.Name = "txtgyógyszer";
            this.txtgyógyszer.Size = new System.Drawing.Size(100, 20);
            this.txtgyógyszer.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(55, 293);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Gyógyszer";
            // 
            // txtdiagnózis
            // 
            this.txtdiagnózis.Location = new System.Drawing.Point(117, 257);
            this.txtdiagnózis.Name = "txtdiagnózis";
            this.txtdiagnózis.Size = new System.Drawing.Size(100, 20);
            this.txtdiagnózis.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Diagnózis";
            // 
            // txtjelenség
            // 
            this.txtjelenség.Location = new System.Drawing.Point(117, 222);
            this.txtjelenség.Name = "txtjelenség";
            this.txtjelenség.Size = new System.Drawing.Size(100, 20);
            this.txtjelenség.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(55, 225);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Jelenségek";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 107);
            this.dataGridView1.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(215, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "PáciensID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(214, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(261, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "További információ a páciensről";
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "hospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addPatientBindingSource
            // 
            this.addPatientBindingSource.DataMember = "AddPatient";
            this.addPatientBindingSource.DataSource = this.hospitalDataSet;
            // 
            // addPatientTableAdapter
            // 
            this.addPatientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddPatientTableAdapter = this.addPatientTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Kórházi_betegkezelő_XAICMP.hospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(826, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl4nyil);
            this.Controls.Add(this.lbl3nyil);
            this.Controls.Add(this.lbl2nyil);
            this.Controls.Add(this.lbl1nyil);
            this.Controls.Add(this.btnKilépés);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRandomTipp);
            this.Controls.Add(this.btnÖsszesPáciens);
            this.Controls.Add(this.btnDiagnózis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPáciens);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPatientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPáciens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDiagnózis;
        private System.Windows.Forms.Button btnÖsszesPáciens;
        private System.Windows.Forms.Button btnRandomTipp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKilépés;
        private System.Windows.Forms.Label lbl1nyil;
        private System.Windows.Forms.Label lbl2nyil;
        private System.Windows.Forms.Label lbl3nyil;
        private System.Windows.Forms.Label lbl4nyil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnMentés;
        private System.Windows.Forms.TextBox txtBetegség;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Név;
        private System.Windows.Forms.ComboBox comboboxNem;
        private System.Windows.Forms.TextBox txtCím;
        private System.Windows.Forms.TextBox txtSzám;
        private System.Windows.Forms.TextBox txtKor;
        private System.Windows.Forms.TextBox txtVércsoport;
        private System.Windows.Forms.TextBox txtNév;
        private hospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource addPatientBindingSource;
        private hospitalDataSetTableAdapters.AddPatientTableAdapter addPatientTableAdapter;
        private hospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbetegid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTovábbiinfómentés;
        private System.Windows.Forms.ComboBox combomutettipus;
        private System.Windows.Forms.ComboBox combokellmutet;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtgyógyszer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtdiagnózis;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtjelenség;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnVicc;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnExport;
    }
}