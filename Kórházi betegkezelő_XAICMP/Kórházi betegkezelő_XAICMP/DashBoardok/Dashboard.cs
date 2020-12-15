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
            
            panel4.Visible = false;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;AttachDbFilename=C:\\Temp\\hospital.mdf;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from AddPatient3 inner join PatientMore on AddPatient3.BetegID = PatientMore.betegid";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView2.DataSource = DS.Tables[0];

        }
        private void CSV(List<PáciensFelvétel> páciens, string filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath, false))
                {
                    for (int i = 0; i < páciens.Count; i++)
                    {
                        file.WriteLine(páciens[i].betegid.ToString() + "," + páciens[i].cím.ToString() + "," + páciens[i].kontakt.ToString() + "," + páciens[i].kor.ToString() + "," + páciens[i].korábbibetegség.ToString() + "," + páciens[i].nem.ToString() + "," + páciens[i].név.ToString() + "," + páciens[i].vércsoport.ToString());
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {

            
            try
            {
                CSV(felvétel, "pácienesek.txt");
                MessageBox.Show("Sikeres adatexport. Nézd meg a Bin/Debug mappát és keresd a páciensek.txt nevű file-t.");
            }
            catch (Exception)
            {

                MessageBox.Show("Valami nem oké!");
            }
            


            
            
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
            
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }
        
        
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
                con.ConnectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;AttachDbFilename=C:\\Temp\\hospital.mdf;Integrated Security=True";
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
                con.ConnectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;AttachDbFilename=C:\\Temp\\hospital.mdf;Integrated Security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from AddPatient3 where BetegID = " + betegid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                
            }
        }
        private List<PáciensMore> pácimore = new List<PáciensMore>();
        private void btnTovábbiinfómentés_Click(object sender, EventArgs e)
        {
            try
            {
                PáciensMore more = new PáciensMore(Convert.ToInt32(textBox1.Text), txtjelenség.Text, txtdiagnózis.Text, txtgyógyszer.Text, combokellmutet.Text, combomutettipus.Text);
                pácimore.Add(more);

                

                
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;AttachDbFilename=C:\\Temp\\hospital.mdf;Integrated Security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into PatientMore (betegid, jelenségek, diagnózis, gyógyszer, kellműtét, műtéttípus) values (" + more.betegid + ", '" + more.jelenség + "', '" + more.diagnózis + "', '" + more.gyógyszer + "', '" + more.kellműtét + "', '" + more.műtéttípus + "')";
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
            

            Random rnd = new Random();
            vicc = rnd.Next(1,8);

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
                    pictureBox2.ImageLocation = "C:\\Users\\Bence-Mr.Chatbee\\source\\repos\\IRF_PROJECT\\Kórházi betegkezelő_XAICMP\\Kórházi betegkezelő_XAICMP\\bin\\Debug\\Tipp\\6.jpg";
                    break;
                case 6:
                    pictureBox2.ImageLocation = "C:\\Users\\Bence-Mr.Chatbee\\source\\repos\\IRF_PROJECT\\Kórházi betegkezelő_XAICMP\\Kórházi betegkezelő_XAICMP\\bin\\Debug\\Tipp\\8.jpg";
                    break;
                case 7:
                    pictureBox2.ImageLocation = "C:\\Users\\Bence-Mr.Chatbee\\source\\repos\\IRF_PROJECT\\Kórházi betegkezelő_XAICMP\\Kórházi betegkezelő_XAICMP\\bin\\Debug\\Tipp\\9.jpg";
                    break;
                
            }
        
        }

        
    }
}
