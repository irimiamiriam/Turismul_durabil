using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Turismul_durabil.SqlDatabase
{
    class DatabaseHelper
    {
        private static readonly string connectionstring = SqlAccess.GetConnectionPath();
        private static readonly string txtpath = SqlAccess.GetTxtPath();

        public static void Initialisation()
        {

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                int ziua = 0;
                con.Open();
                string cmdDeleteLocalitati = "Delete from Localitati";
                string cmdDeleteImagini = "Delete from Imagini";
                string cmdDeletePlanificari = "Delete from Planificari";
                SqlCommand cmdDeleteLoc = new SqlCommand(cmdDeleteLocalitati, con);
                SqlCommand cmdDeleteImag = new SqlCommand(cmdDeleteImagini, con);
                SqlCommand cmdDeletePlan = new SqlCommand(cmdDeletePlanificari, con);
                SqlCommand IdentityStartL = new SqlCommand("DBCC CHECKIDENT ('Localitati', RESEED, 0)", con);
                SqlCommand IdentityStartI = new SqlCommand("DBCC CHECKIDENT ('Imagini', RESEED, 0)", con);
                SqlCommand IdentityStartP = new SqlCommand("DBCC CHECKIDENT ('Planificari', RESEED, 0)", con);
                IdentityStartI.ExecuteNonQuery();
                IdentityStartL.ExecuteNonQuery();
                IdentityStartP.ExecuteNonQuery();
                cmdDeleteLoc.ExecuteNonQuery();
                cmdDeleteImag.ExecuteNonQuery();
                cmdDeletePlan.ExecuteNonQuery();

                using (StreamReader reader = new StreamReader(txtpath))
                {
                    while (reader.Peek() > 0)
                    {

                        string cmdLocalitatiText = "Insert into Localitati (Nume) values (@localitate)";
                        string cmdImaginiText = "Insert into Imagini (IDLocalitate, CaleFisier) values (@localitate, @calefisier)";
                        string cmdSelectIdLoc = "Select IDLocalitate from Localitati where Nume like @localitate";
                        string cmdPlanificariAnualText = "Insert into Planificari (IDLocalitate, Frecventa, DataStart, DataStop) values (@localitate,@frecv,@datastart, @datastop)";
                        string cmdPlanificariOcazText = "Insert into Planificari (IDLocalitate, Frecventa, Ziua) values (@localitate,@frecv,@ziua)";
                        SqlCommand cmdPlanificariO = new SqlCommand(cmdPlanificariAnualText, con);
                        SqlCommand cmdPlanificariA = new SqlCommand(cmdPlanificariOcazText, con);
                        SqlCommand cmdLocalitati = new SqlCommand(cmdLocalitatiText, con);
                        SqlCommand cmdImagini = new SqlCommand(cmdImaginiText, con);
                        SqlCommand cmdSelectIdLocalitate = new SqlCommand(cmdSelectIdLoc, con);


                        string line1 = reader.ReadLine();
                        string line = line1.Replace(" ", "");
                        var split = line.Split('*');

                        var starttime = new DateTime();
                        DateTime stoptime = new DateTime();
                        if (split[1] == "anual")
                        {

                            ziua = Convert.ToInt32(split[2]);
                        }
                        else if (split[1] == "lunar")
                        {

                            ziua = Convert.ToInt32(split[2]);
                        }

                        if (split[1] == "ocazional")
                        {
                            starttime = DateTime.ParseExact(split[2], "dd'.'MM'.'yyyy", CultureInfo.InvariantCulture);
                            stoptime = DateTime.ParseExact(split[3], "dd'.'MM'.'yyyy", null);


                            cmdLocalitati.Parameters.AddWithValue("@localitate", split[0]);
                            cmdLocalitati.ExecuteNonQuery();
                            cmdSelectIdLocalitate.Parameters.AddWithValue("@localitate", split[0]);
                            int id = (int)cmdSelectIdLocalitate.ExecuteScalar();
                            cmdImagini.Parameters.AddWithValue("@localitate", id);
                            for (int i = 4; i < split.Length - 1; i++)
                            {
                                SqlParameter calef = new SqlParameter("@calefisier", split[i]);
                                cmdImagini.Parameters.Add(calef);
                                cmdImagini.ExecuteNonQuery();
                                cmdImagini.Parameters.Remove(calef);
                            }
                            cmdPlanificariO.Parameters.AddWithValue("@localitate", id);
                            cmdPlanificariO.Parameters.AddWithValue("@frecv", split[1]);

                            cmdPlanificariO.Parameters.AddWithValue("@datastart", starttime);
                            cmdPlanificariO.Parameters.AddWithValue("@datastop", stoptime);

                            cmdPlanificariO.ExecuteNonQuery();

                        }
                        else
                        {

                            cmdLocalitati.Parameters.AddWithValue("@localitate", split[0]);
                            cmdLocalitati.ExecuteNonQuery();
                            cmdSelectIdLocalitate.Parameters.AddWithValue("@localitate", split[0]);
                            int id = (int)cmdSelectIdLocalitate.ExecuteScalar();
                            cmdImagini.Parameters.AddWithValue("@localitate", id);
                            for (int i = 3; i < split.Length - 1; i++)
                            {
                                SqlParameter calef = new SqlParameter("@calefisier", split[i]);
                                cmdImagini.Parameters.Add(calef);
                                cmdImagini.ExecuteNonQuery();
                                cmdImagini.Parameters.Remove(calef);
                            }
                            cmdPlanificariA.Parameters.AddWithValue("@localitate", id);
                            cmdPlanificariA.Parameters.AddWithValue("@frecv", split[1]);
                            cmdPlanificariA.Parameters.AddWithValue("@ziua", ziua);
                            cmdPlanificariA.ExecuteNonQuery();
                        }


                    }
                }
            }

        }
        public static string[] GetLocComboBox()
        {
            string[] localitati = new string[200];
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string cmdText = "Select Nume from Localitati";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    int i = 0;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read() && !(string.IsNullOrWhiteSpace(reader.GetString(0))))
                    {
                        localitati[i] = reader.GetString(0);
                        i++;
                    }
                }

            }
            return localitati;
        }

        public static string[] GetImaginiComboBox(string localitate)
        {
            string[] imagini = new string[200];
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string cmdSelectLocText = "Select IDLocalitate from Localitati where CAST(Nume AS NVARCHAR(MAX))=@localitate";
                string cmdSelectImgText = "Select CaleFisier from Imagini where IDLocalitate=@idlocalitate";
                SqlCommand cmd1 = new SqlCommand(cmdSelectLocText, con);
                cmd1.Parameters.AddWithValue("@localitate", localitate);
                int id = (int)cmd1.ExecuteScalar();
                using (SqlCommand cmd2 = new SqlCommand(cmdSelectImgText, con))
                {
                    int i = 0;
                    cmd2.Parameters.AddWithValue("@idlocalitate", id);
                    SqlDataReader reader = cmd2.ExecuteReader();
                    while (reader.Read() && !(string.IsNullOrWhiteSpace(reader.GetString(0))))
                    {
                        imagini[i] = reader.GetString(0);
                        i++;
                    }
                }

            }
            return imagini;
        }

        public static DataTable Planificari()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Nume");
            dt.Columns.Add("Frecventa");
            dt.Columns.Add("Data Start");
            dt.Columns.Add("Data Stop");
            dt.Columns.Add("Ziua");

            List<int> ids = new List<int>();
            List<string> names = new List<string>();

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string cmdPlanificariText = "Select Frecventa, DataStart, DataStop, Ziua From Planificari Where IDLocalitate=@id";
                string cmdLocalitatiText = "Select  * from Localitati";
                // SqlCommand cmdPlan = new SqlCommand(cmdPlanificariText,con);
                using (SqlCommand cmdLocalitati = new SqlCommand(cmdLocalitatiText, con))
                {
                    using (SqlDataReader reader = cmdLocalitati.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader[0]);
                            string name = reader[1].ToString();
                            ids.Add(id);
                            names.Add(name);
                        }
                    }
                }


                for (int i = 0; i < ids.Count; i++)
                {
                    int id = ids[i];
                    string name = names[i];

                    using (SqlCommand cmdPlan = new SqlCommand(cmdPlanificariText, con))
                    {
                        cmdPlan.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader readerPlan = cmdPlan.ExecuteReader())
                        {
                            while (readerPlan.Read())
                            {
                                string frec = readerPlan["Frecventa"].ToString();
                                string datastart = readerPlan["DataStart"].ToString();


                                string datastop = readerPlan["DataStop"].ToString();
                                string ziua = readerPlan["Ziua"].ToString();
                                dt.Rows.Add(name, frec, datastart, datastop, ziua);
                            }
                        }
                    }
                }

                return dt;
            }



        }

        public static DataTable PlanificariValabile(DateTime start, DateTime stop)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Nume");
            dt.Columns.Add("Frecventa");
            dt.Columns.Add("Data Start");
            dt.Columns.Add("Data Stop");


            List<int> ids = new List<int>();
            List<string> names = new List<string>();

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string cmdPlanificariText = "Select Frecventa, DataStart, DataStop, Ziua From Planificari Where IDLocalitate=@id";
                string cmdLocalitatiText = "Select  * from Localitati";
                // SqlCommand cmdPlan = new SqlCommand(cmdPlanificariText,con);
                using (SqlCommand cmdLocalitati = new SqlCommand(cmdLocalitatiText, con))
                {
                    using (SqlDataReader reader = cmdLocalitati.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader[0]);
                            string name = reader[1].ToString();
                            ids.Add(id);
                            names.Add(name);
                        }
                    }
                }

                string[] formats = { "dd/MM/yyyy", "d/M/yyyy", "dd/M/yyyy", "d/MM/yyyy" };
                for (int i = 0; i < ids.Count; i++)
                {
                    int id = ids[i];
                    string name = names[i];

                    using (SqlCommand cmdPlan = new SqlCommand(cmdPlanificariText, con))
                    {
                        cmdPlan.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader readerPlan = cmdPlan.ExecuteReader())
                        {
                            while (readerPlan.Read())
                            {
                                string frec = readerPlan["Frecventa"].ToString();
                                string datastart = readerPlan["DataStart"].ToString();
                                string datastop = readerPlan["DataStop"].ToString();
                                string[] startdate = datastart.Split(' ');
                                string[] stopdate = datastop.Split(' ');

                                if (frec == "ocazional")
                                {
                                    DateTime dstart = new DateTime();
                                    DateTime dstop = new DateTime();
                                    foreach (string s in formats)
                                    { if (DateTime.TryParseExact(startdate[0], s, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dstart)) { break; } }
                                    foreach (string s in formats)
                                    { if (DateTime.TryParseExact(stopdate[0], s, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dstop)) { break; } }
                                    if (dstart >= start && dstop <= stop)
                                    {
                                        string ziua = readerPlan["Ziua"].ToString();
                                        dt.Rows.Add(name, frec, datastart.ToString(), datastop.ToString());
                                    }

                                }
                                else if (frec == "anual")
                                {
                                    string ziua = readerPlan["Ziua"].ToString();
                                    DateTime date = new DateTime(start.Year, 1, 1).AddDays(Convert.ToInt32(ziua) - 1);
                                    while (date >= start && date <= stop)
                                    {
                                        dt.Rows.Add(name, frec, date.Date.ToString(), date.Date.ToString());
                                        date = date.AddYears(1);

                                    }
                                }
                                else if (frec == "lunar")
                                {
                                    string ziua = readerPlan["Ziua"].ToString();
                                    DateTime date = new DateTime(start.Year, 1, 1).AddDays(Convert.ToInt32(ziua) - 1);
                                    while (date >= start && date <= stop)
                                    {
                                        dt.Rows.Add(name, frec, date.Date.ToString(), date.Date.ToString());
                                        date = date.AddMonths(1);
                                    }
                                }

                            }
                        }
                    }
                }
            }
            return dt;
        }

        public static DataTable Itinerariu(DateTime start, DateTime stop)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Nume");
            dt.Columns.Add("Data");


            List<int> ids = new List<int>();
            List<string> names = new List<string>();
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string cmdPlanificariText = "Select Frecventa, DataStart, DataStop, Ziua From Planificari Where IDLocalitate=@id";
                string cmdLocalitatiText = "Select  * from Localitati";
                // SqlCommand cmdPlan = new SqlCommand(cmdPlanificariText,con);
                using (SqlCommand cmdLocalitati = new SqlCommand(cmdLocalitatiText, con))
                {
                    using (SqlDataReader reader = cmdLocalitati.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader[0]);
                            string name = reader[1].ToString();
                            ids.Add(id);
                            names.Add(name);
                        }
                    }
                }

                string[] formats = { "dd/MM/yyyy", "d/M/yyyy", "dd/M/yyyy", "d/MM/yyyy" };
                for (int i = 0; i < ids.Count; i++)
                {
                    int id = ids[i];
                    string name = names[i];

                    using (SqlCommand cmdPlan = new SqlCommand(cmdPlanificariText, con))
                    {
                        cmdPlan.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader readerPlan = cmdPlan.ExecuteReader())
                        {
                            while (readerPlan.Read())
                            {
                                string frec = readerPlan["Frecventa"].ToString();
                                string datastart = readerPlan["DataStart"].ToString();
                                string datastop = readerPlan["DataStop"].ToString();
                                string[] startdate = datastart.Split(' ');
                                string[] stopdate = datastop.Split(' ');

                                if (frec == "ocazional")
                                {
                                    DateTime dstart = new DateTime();
                                    DateTime dstop = new DateTime();
                                    foreach (string s in formats)
                                    { DateTime.TryParseExact(startdate[0], s, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dstart); }
                                    foreach (string s in formats)
                                    { DateTime.TryParseExact(stopdate[0], s, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dstop); }

                                    while (dstart >= start && dstart <= stop && dstart.AddDays(1) <= DateTime.MaxValue)
                                    {
                                        dt.Rows.Add(name, datastart);
                                        dstart = dstart.AddDays(1);
                                    }

                                }
                                else if (frec == "anual")
                                {
                                    string ziua = readerPlan["Ziua"].ToString();
                                    DateTime date = new DateTime(start.Year, 1, 1).AddDays(Convert.ToInt32(ziua) - 1);
                                    if (date >= start && date <= stop)
                                    {
                                        dt.Rows.Add(name, date.ToString("d"));
                                        date = date.AddYears(1);
                                    }
                                }
                                else if (frec == "lunar")
                                {
                                    string ziua = readerPlan["Ziua"].ToString();
                                    DateTime date = new DateTime(start.Year, 1, 1).AddDays(Convert.ToInt32(ziua) - 1);
                                    while (date >= start && date <= stop)
                                    {
                                        dt.Rows.Add(name, date.ToString("d"));
                                        date = date.AddMonths(1);
                                    }
                                }

                            }
                        }
                    }
                }
            }
            return dt;
        }

        public static string[] ImaginiItinerariu(string[] localitati)
        {
            string[] imagini = new string[localitati.Length];
            int indexloc = 0;
            Dictionary<string, int> imaginecur = new Dictionary<string, int>();
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                foreach(string loc in localitati)
                {   
                    string cmdSelectId = "Select IDLocalitate from Localitati where CAST(Nume AS NVARCHAR(MAX)) = @numeloc";
                    string cmdSelectImg = "Select * from Imagini where IDLocalitate = @idloc";
                    string nrimg = "SELECT COUNT(*) FROM Imagini where IDLocalitate = @idloc";

                    //  SqlCommand SelectId = new SqlCommand(cmdSelectId, con);
                    if (string.IsNullOrEmpty(loc)) { break; }
                    int idloc, nrImg;
                    using (SqlCommand SelectId = new SqlCommand(cmdSelectId, con))
                    {  SelectId.Parameters.AddWithValue("@numeloc", loc);
                        idloc = (int)SelectId.ExecuteScalar(); 
                        
                    }
                    using (SqlCommand NrImg = new SqlCommand(nrimg, con))
                    { NrImg.Parameters.AddWithValue("@idloc", idloc);
                     nrImg= (int)NrImg.ExecuteScalar();
                    }
                    using (SqlCommand SelectImg = new SqlCommand(cmdSelectImg, con))
                    {
                        SelectImg.Parameters.AddWithValue("@idloc", idloc);
                        SqlDataReader reader = SelectImg.ExecuteReader();
                        if (imaginecur.ContainsKey(loc))
                        {
                            if (nrImg < imaginecur[loc]) { imaginecur[loc] = 0; }
                        }
                        else { imaginecur[loc] = 0; }
                        int index = 0;
                        while (reader.Read())
                        {
                            if (index == imaginecur[loc])
                            {
                                imagini[indexloc] = reader[2].ToString();
                                break;
                            }
                            index++;
                        }
                        reader.Close();
                    }
                    indexloc++;
                    imaginecur[loc]++;

                }
            }
            return imagini;
        }



     }
}
