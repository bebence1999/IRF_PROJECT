using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kórházi_betegkezelő_XAICMP
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
        }
        private void btnPáciens_Click(object sender, EventArgs e)
        {
            lbl1nyil.ForeColor = System.Drawing.Color.Red;
            lbl2nyil.ForeColor = System.Drawing.Color.Black;
            lbl3nyil.ForeColor = System.Drawing.Color.Black;
            lbl4nyil.ForeColor = System.Drawing.Color.Black;

            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl1nyil.ForeColor = System.Drawing.Color.Black;
            lbl2nyil.ForeColor = System.Drawing.Color.Red;
            lbl3nyil.ForeColor = System.Drawing.Color.Black;
            lbl4nyil.ForeColor = System.Drawing.Color.Black;

            //panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            
        }

        

        private void btnÖsszesPáciens_Click(object sender, EventArgs e)
        {
            lbl1nyil.ForeColor = System.Drawing.Color.Black;
            lbl2nyil.ForeColor = System.Drawing.Color.Black;
            lbl3nyil.ForeColor = System.Drawing.Color.Red;
            lbl4nyil.ForeColor = System.Drawing.Color.Black;

            panel3.Visible = true;
            //panel1.Visible = false
            //panel2.Visible = false;
            panel4.Visible = false;

            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;database=hospital;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from AddPatient3 inner join PatientMore on AddPatient3.BetegID = PatientMore.betegid";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView2.DataSource = DS.Tables[0];

        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;database=hospital;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from AddPatient3 inner join PatientMore on AddPatient3.BetegID = PatientMore.betegid";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            
            
        }

        private void btnRandomTipp_Click(object sender, EventArgs e)
        {
            lbl1nyil.ForeColor = System.Drawing.Color.Black;
            lbl2nyil.ForeColor = System.Drawing.Color.Black;
            lbl3nyil.ForeColor = System.Drawing.Color.Black;
            lbl4nyil.ForeColor = System.Drawing.Color.Red;

            panel4.Visible = true;
            
        }

        private void btnKilépés_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.AddPatient' table. You can move, or remove it, as needed.
            //this.addPatientTableAdapter.Fill(this.hospitalDataSet.AddPatient);
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }
        
        //private List<PáciensFelvétel> lista = new List<PáciensFelvétel>();
        private void label18_Click(object sender, EventArgs e)
        {
            
        }
        private List<PáciensFelvétel> felvétel = new List<PáciensFelvétel>();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PáciensFelvétel páciens = new PáciensFelvétel(txtNév.Text, txtCím.Text, txtSzám.Text, txtKor.Text, comboboxNem.Text, txtVércsoport.Text, txtBetegség.Text, Convert.ToInt32(txtbetegid.Text));

                felvétel.Add(páciens);



                


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;database=hospital;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into AddPatient3 (BetegID, Név, Cím, Telefonszám, Kor, Nem, Vércsoport, KorábbiBetegség) values ("+páciens.betegid+",'" + páciens.név + "', '" + páciens.cím + "', '" + páciens.kontakt + "','" + páciens.kor + "', '" + páciens.nem + "', '" + páciens.vércsoport + "', '" + páciens.korábbibetegség + "')";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                MessageBox.Show("Új páciens felvéve!");
            }
            catch (Exception)
            {
                MessageBox.Show("Nem ment valami.");
            }
            txtNév.Clear();
            txtbetegid.Clear();
            txtSzám.Clear();
            txtCím.Clear();
            txtKor.Clear();
            comboboxNem.ResetText();
            txtVércsoport.Clear();
            txtBetegség.Clear();

        }

        private void addPatientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.addPatientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            { 

                int betegid = Convert.ToInt32(textBox1.Text);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;database=hospital;Integrated Security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from AddPatient3 where BetegID = " + betegid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                
            }
        }

        private void btnTovábbiinfómentés_Click(object sender, EventArgs e)
        {
            try
            {
                int betegid = Convert.ToInt32(textBox1.Text);
                string jelenség = txtjelenség.Text;
                string diagnózis = txtdiagnózis.Text;
                string gyógyszer = txtgyógyszer.Text;
                string kellmutet = combokellmutet.Text;
                string mutettipus = combomutettipus.Text;

                
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;database=hospital;Integrated Security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into PatientMore (betegid, jelenségek, diagnózis, gyógyszer, kellműtét, műtéttípus) values (" + betegid + ", '" + jelenség + "', '" + diagnózis + "', '" + gyógyszer + "', '" + kellmutet + "', '" + mutettipus + "')";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                MessageBox.Show("Sikeres adatfelvétel!");

            }
            catch (Exception)
            {
                MessageBox.Show("Valami nem oké...üres mező vagy rossz formátum.");
            }

            textBox1.Clear();
            txtjelenség.Clear();
            txtgyógyszer.Clear();
            txtdiagnózis.Clear();
            combokellmutet.ResetText();
            combomutettipus.ResetText();


        }
        

        int vicc;
        private void button1_Click_1(object sender, EventArgs e)
        {
            //pictureBox2.ImageLocation = "C:\\Users\\Bence-Mr.Chatbee\\source\\repos\\IRF_PROJECT\\Kórházi betegkezelő_XAICMP\\Kórházi betegkezelő_XAICMP\\bin\\Debug\\Tipp";

            Random rnd = new Random();
            vicc = rnd.Next(1,10);

            switch (vicc)
            {
                case 1:
                    pictureBox2.ImageLocation = "C:\\Users\\Bence-Mr.Chatbee\\source\\repos\\IRF_PROJECT\\Kórházi betegkezelő_XAICMP\\Kórházi betegkezelő_XAICMP\\bin\\Debug\\Tipp\\1.jpg";
                break;
                case 2:
                    pictureBox2.ImageLocation = "C:\\Users\\Bence-Mr.Chatbee\\source\\repos\\IRF_PROJECT\\Kórházi betegkezelő_XAICMP\\Kórházi betegkezelő_XAICMP\\bin\\Debug\\Tipp\\2.jpg";
                    break;
                case 3:
                    pictureBox2.ImageLocation = "C:\\Users\\Bence-Mr.Chatbee\\source\\repos\\IRF_PROJECT\\Kórházi betegkezelő_XAICMP\\Kórházi betegkezelő_XAICMP\\bin\\Debug\\Tipp\\3.jpg";
                    break;
                case 4:
                    pictureBox2.ImageLocation = "C:\\Users\\Bence-Mr.Chatbee\\source\\repos\\IRF_PROJECT\\Kórházi betegkezelő_XAICMP\\Kórházi betegkezelő_XAICMP\\bin\\Debug\\Tipp\\4.jpg";
                    break;
                case 5:
                    pictureBox2.ImageLocation = "C:\\Users\\Bence-Mr.Chatbee\\source\\repos\\IRF_PROJECT\\Kórházi betegkezelő_XAICMP\\Kórházi betegkezelő_XAICMP\\bin\\Debug\\Tipp\\5.jpg";
                    break;
                case 6:
                    pictureBox2.ImageLocation = "C:\\Users\\Bence-Mr.Chatbee\\source\\repos\\IRF_PROJECT\\Kórházi betegkezelő_XAICMP\\Kórházi betegkezelő_XAICMP\\bin\\Debug\\Tipp\\6.jpg";
                    break;
                case 7:
                    pictureBox2.ImageLocation = "C:\\Users\\Bence-Mr.Chatbee\\source\\repos\\IRF_PROJECT\\Kórházi betegkezelő_XAICMP\\Kórházi betegkezelő_XAICMP\\bin\\Debug\\Tipp\\7.jpg";
                    break;
                case 8:
                    pictureBox2.ImageLocation = "C:\\Users\\Bence-Mr.Chatbee\\source\\repos\\IRF_PROJECT\\Kórházi betegkezelő_XAICMP\\Kórházi betegkezelő_XAICMP\\bin\\Debug\\Tipp\\8.jpg";
                    break;
                case 9:
                    pictureBox2.ImageLocation = "C:\\Users\\Bence-Mr.Chatbee\\source\\repos\\IRF_PROJECT\\Kórházi betegkezelő_XAICMP\\Kórházi betegkezelő_XAICMP\\bin\\Debug\\Tipp\\9.jpg";
                    break;
            }
        
        }

        
    }
}
