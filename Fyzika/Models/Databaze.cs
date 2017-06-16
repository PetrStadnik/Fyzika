using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Fyzika.Models
{
    public class Databaze
    {
        public List<string> Jmena { get; set; } 
        public List<Veliciny> VelicinyList { get; set; }
        public List<Pyramidka> PyramidkyList { get; set; }

        public Databaze()
        {
            Jmena = new List<string>();
        }

        public void Main()
        {
            string connStr = "server=81.2.194.248;user=f91809;database=f91809;port=3306;password=SEB673p24;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string sql = "SELECT jmeno FROM pokus";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                Jmena.Add("Pavel");
                while (rdr.Read())
                {
                    Jmena.Add(rdr[0].ToString());

                    //Console.WriteLine(rdr[0] + " -- " + rdr[1]);
                    Console.WriteLine(rdr[0]);
                    

                }
                rdr.Close();
            }
             
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            Console.WriteLine("Done.");
            Jmena.Add("Míša");
        }

    }
}