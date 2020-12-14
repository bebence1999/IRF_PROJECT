using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kórházi_betegkezelő_XAICMP
{
    class AdatbázisExport
    {

        //public  string  GetCSV()
        //{
        //    using (SqlConnection con = new SqlConnection(ConnectionString()))
        //    {
        //        con.Open();
        //        return CreateCSV(new SqlCommand("select * from AddPatient3 inner join PatientMore on AddPatient3.BetegID = PatientMore.betegid", con).ExecuteReader());
        //    }
        //}

        //public string CreateCSV(SqlDataReader reader)
        //{
        //    string fájl = @"C:\\Users\\Bence-Mr.Chatbee\\AdatbazisExport.csv";
        //    List<string> lines = new List<string>();

        //    string fejléc = "";
        //    if (reader.Read())
        //    {
        //        string[] columnns = new string[reader.FieldCount];
        //        for (int i = 0; i < reader.FieldCount; i++)
        //        {
        //            columnns[i] = reader.GetName(i);
        //        }
        //        fejléc = string.Join(",", columnns);
        //        lines.Add(fejléc);

        //    }

        //    while (reader.Read())
        //    {
        //        object[] values = new object[reader.FieldCount];
        //        reader.GetValue(values);
        //        lines.Add(string.Join(",", values));
        //    }

        //    System.IO.File.WriteAllLines(fájl, lines);

        //    return fájl;
        //}

        //public string ConnectionString()
        //{
        //    return @"Data Source=(LocalDb)\\MSSQLLocalDB;database=hospital;Integrated Security=True";
        //    //SqlConnection con = new SqlConnection();
        //    //con.ConnectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;database=hospital;Integrated Security=True";

        //    //SqlCommand cmd = new SqlCommand();
        //    //cmd.Connection = con;
        //    //cmd.CommandText = "select * from AddPatient3 inner join PatientMore on AddPatient3.BetegID = PatientMore.betegid";
        //    //SqlDataAdapter DA = new SqlDataAdapter(cmd);
        //    //DataSet DS = new DataSet();
        //    //DA.Fill(DS);
        //}






    }
}
