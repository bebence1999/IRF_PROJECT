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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl1nyil.ForeColor = System.Drawing.Color.Black;
            lbl2nyil.ForeColor = System.Drawing.Color.Red;
            lbl3nyil.ForeColor = System.Drawing.Color.Black;
            lbl4nyil.ForeColor = System.Drawing.Color.Black;

            //panel1.Visible = false;
            panel2.Visible = true;
            
        }

        

        private void btnÖsszesPáciens_Click(object sender, EventArgs e)
        {
            lbl1nyil.ForeColor = System.Drawing.Color.Black;
            lbl2nyil.ForeColor = System.Drawing.Color.Black;
            lbl3nyil.ForeColor = System.Drawing.Color.Red;
            lbl4nyil.ForeColor = System.Drawing.Color.Black;
        }

        private void btnRandomTipp_Click(object sender, EventArgs e)
        {
            lbl1nyil.ForeColor = System.Drawing.Color.Black;
            lbl2nyil.ForeColor = System.Drawing.Color.Black;
            lbl3nyil.ForeColor = System.Drawing.Color.Black;
            lbl4nyil.ForeColor = System.Drawing.Color.Red;
        }

        private void btnKilépés_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.AddPatient' table. You can move, or remove it, as needed.
            this.addPatientTableAdapter.Fill(this.hospitalDataSet.AddPatient);
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                string név = txtNév.Text;
                string cím = txtCím.Text;
                string kontakt = txtSzám.Text;
                string kor = txtKor.Text;
                string nem = comboboxNem.Text;
                string vércsoport = txtVércsoport.Text;
                string korábbibetegség = txtBetegség.Text;
                int BetegID = Convert.ToInt32(txtbetegid.Text);


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;database=hospital;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into AddPatient3 (BetegID, Név, Cím, Telefonszám, Kor, Nem, Vércsoport, KorábbiBetegség) values ("+BetegID+",'" + név + "', '" + cím + "', '" + kontakt + "','" + kor + "', '" + nem + "', '" + vércsoport + "', '" + korábbibetegség + "')";

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



        }
    }
}
