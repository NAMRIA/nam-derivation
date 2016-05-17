using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Data;
using System.Data.SqlClient;
using SharpMap.Data;
using System.Text.RegularExpressions;

namespace Derivation
{
    static class GheloBytes
    {
        public static int Execute(string sql)
        {
            SqlConnection conn = new SqlConnection(ConnectionString());
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            return cmd.ExecuteNonQuery();
        }

        public static DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionString());
            da.Fill(dt);
            return dt;
        }
        public static FeatureDataTable GetFeatureDataTable(string sql)
        {
            FeatureDataTable dt = new FeatureDataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionString());
            da.Fill(dt);
            return dt;
        }

        public static bool IsConnectionOk()
        {
            using(SqlConnection conn = new SqlConnection(ConnectionString()))
            {
                try
                {
                    conn.Open();
                }
                catch (SqlException ex) { 
                    string msg = ex.Message;
                    return false; 
                }
            }
            return true;
        }

        public static object GetData(string sql)
        {
            SqlConnection conn = new SqlConnection(ConnectionString());
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            return cmd.ExecuteScalar();
        }

        public static double Val(string value)
        {
            string temp = "";
            for (int i = 0; i < value.Length; i++)
            {
                string s = value.Substring(i,1);
                if (IsNumeric(s) || s == ".")
                    temp += s;
            }
            return Convert.ToDouble(temp);
        }

        public static double DMStoDD(string dms)
        {
            double deg = GheloBytes.Val(dms.Substring(0, dms.IndexOf("°")));
            double min = GheloBytes.Val(dms.Substring(dms.IndexOf("°"), dms.IndexOf("'") - dms.IndexOf("°")));
            double sec = GheloBytes.Val(dms.Substring(dms.IndexOf("'"), ((dms.Length - dms.IndexOf("'"))-1)));
            return (deg + (min/60) + (sec/3600));
        }


        //Function Convert_Decimal(Degree_Deg As String) As Double
        //' Declare the variables to be double precision floating-point.
        //Dim degrees As Double
        //Dim minutes As Double
        //Dim seconds As Double
        //' Set degree to value before "°" of Argument Passed.
        //degrees = Val(Left(Degree_Deg, InStr(1, Degree_Deg, "°") - 1))
        //' Set minutes to the value between the "°" and the "'"
        //' of the text string for the variable Degree_Deg divided by
        //' 60. The Val function converts the text string to a number.
        //minutes = Val(Mid(Degree_Deg, InStr(1, Degree_Deg, "°") + 2, _
        //     InStr(1, Degree_Deg, "'") - InStr(1, Degree_Deg, _
        //     "°") - 2)) / 60
        //' Set seconds to the number to the right of "'" that is
        //' converted to a value and then divided by 3600.
        //seconds = Val(Mid(Degree_Deg, InStr(1, Degree_Deg, "'") + _
        //    2, Len(Degree_Deg) - InStr(1, Degree_Deg, "'") - 2)) _
        //    / 3600
        //Convert_Decimal = degrees + minutes + seconds
        //End Function

        //Function Convert_Degree(Decimal_Deg) As Variant
        //With Application
        //'Set degree to Integer of Argument Passed
        //Degrees = Int(Decimal_Deg)
        //'Set minutes to 60 times the number to the right
        //'of the decimal for the variable Decimal_Deg
        //Minutes = (Decimal_Deg - Degrees) * 60
        //'Set seconds to 60 times the number to the right of the
        //'decimal for the variable Minute
        //Seconds = Format(((Minutes - Int(Minutes)) * 60), "0")
        //'Returns the Result of degree conversion
        //'(for example, 10.46 = 10~ 27  ' 36")
        //Convert_Degree = " " & Degrees & "° " & Int(Minutes) & "' " _
        //    & Seconds + Chr(34)
        //End With
        //End Function


        public static bool IsNumeric(object Expression)
        {
            double retNum;
            return Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
        }



        public static string ConnectionString()
        {
            string dbName = GetSetting("datasource", "database", "name");
            string serverName = GetSetting("datasource", "server", "name");
            string login = "prs92";
            string password = "prs92";

            string connString = String.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", serverName, dbName, login, password);
            return connString;
        }
        public static string GetSetting(string section, string setting, string attribute)
        {
            string configFile = Application.StartupPath + @"\config.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(configFile);

            XmlNode node = doc.SelectSingleNode("config/" + section + "/" + setting);
            return node.Attributes[attribute].Value;
        }
        public static void SaveSetting(string section, string setting, string attribute, string value)
        {
            string configFile = Application.StartupPath + @"\config.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(configFile);

            XmlNode node = doc.SelectSingleNode("config/" + section + "/" + setting);

            node.Attributes[attribute].Value = value;
            doc.Save(configFile);
        }
        public static string EncryptDecrypt(string textToEncrypt, int key)
        {
            StringBuilder inSb = new StringBuilder(textToEncrypt);
            StringBuilder outSb = new StringBuilder(textToEncrypt.Length);
            char c;
            for (int i = 0; i < textToEncrypt.Length; i++)
            {
                c = inSb[i];
                c = (char)(c ^ key);
                outSb.Append(c);
            }
            return outSb.ToString();
        }


        public static string Salt = "NAMRIA";



    }
}
