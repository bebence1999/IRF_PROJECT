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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
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
            this.label10 = new System.Windows.Forms.Label();
            this.btnMentés = new System.Windows.Forms.Button();
            this.txtPáciensID = new System.Windows.Forms.TextBox();
            this.txtBetegség = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.hospitalDataSet = new Kórházi_betegkezelő_XAICMP.hospitalDataSet();
            this.addPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addPatientTableAdapter = new Kórházi_betegkezelő_XAICMP.hospitalDataSetTableAdapters.AddPatientTableAdapter();
            this.tableAdapterManager = new Kórházi_betegkezelő_XAICMP.hospitalDataSetTableAdapters.TableAdapterManager();
            this.addPatientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.addPatientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPatientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPatientBindingNavigator)).BeginInit();
            this.addPatientBindingNavigator.SuspendLayout();
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
            this.btnRandomTipp.Text = "Orvosi gyorstipp";
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
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnMentés);
            this.panel1.Controls.Add(this.txtPáciensID);
            this.panel1.Controls.Add(this.txtBetegség);
            this.panel1.Controls.Add(this.label9);
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
            this.btnMentés.Location = new System.Drawing.Point(520, 314);
            this.btnMentés.Name = "btnMentés";
            this.btnMentés.Size = new System.Drawing.Size(75, 23);
            this.btnMentés.TabIndex = 25;
            this.btnMentés.Text = "Mentés";
            this.btnMentés.UseVisualStyleBackColor = true;
            this.btnMentés.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPáciensID
            // 
            this.txtPáciensID.Location = new System.Drawing.Point(53, 314);
            this.txtPáciensID.Name = "txtPáciensID";
            this.txtPáciensID.Size = new System.Drawing.Size(443, 20);
            this.txtPáciensID.TabIndex = 24;
            // 
            // txtBetegség
            // 
            this.txtBetegség.Location = new System.Drawing.Point(53, 257);
            this.txtBetegség.Name = "txtBetegség";
            this.txtBetegség.Size = new System.Drawing.Size(542, 20);
            this.txtBetegség.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Páciens ID:";
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
            // addPatientBindingNavigator
            // 
            this.addPatientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.addPatientBindingNavigator.BindingSource = this.addPatientBindingSource;
            this.addPatientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.addPatientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.addPatientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.addPatientBindingNavigatorSaveItem});
            this.addPatientBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.addPatientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.addPatientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.addPatientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.addPatientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.addPatientBindingNavigator.Name = "addPatientBindingNavigator";
            this.addPatientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.addPatientBindingNavigator.Size = new System.Drawing.Size(826, 25);
            this.addPatientBindingNavigator.TabIndex = 16;
            this.addPatientBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // addPatientBindingNavigatorSaveItem
            // 
            this.addPatientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addPatientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("addPatientBindingNavigatorSaveItem.Image")));
            this.addPatientBindingNavigatorSaveItem.Name = "addPatientBindingNavigatorSaveItem";
            this.addPatientBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.addPatientBindingNavigatorSaveItem.Text = "Save Data";
            this.addPatientBindingNavigatorSaveItem.Click += new System.EventHandler(this.addPatientBindingNavigatorSaveItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(826, 647);
            this.Controls.Add(this.addPatientBindingNavigator);
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
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPatientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPatientBindingNavigator)).EndInit();
            this.addPatientBindingNavigator.ResumeLayout(false);
            this.addPatientBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox txtPáciensID;
        private System.Windows.Forms.TextBox txtBetegség;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.BindingNavigator addPatientBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton addPatientBindingNavigatorSaveItem;
    }
}