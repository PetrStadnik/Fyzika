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
        MySqlConnection conn;
        public List<string> Jmena { get; set; } 
        public List<Veliciny> VelicinyList { get; set; }
        public List<Pyramidka> PyramidkyList { get; set; }

        public Databaze()
        {
            Jmena = new List<string>();
            string connStr = "server=81.2.194.248;user=f91809;database=f91809;port=3306;password=SEB673p24;";
             conn = new MySqlConnection(connStr);
        }

        public void Main()
        {
            
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

        public string AddVelicina(string jmeno, string jednotky, string znacka)
        {
            string stav = "";          
            try
            {
                conn.Open();
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "INSERT into veliciny(jmeno, jednotky, znacka) values('" + jmeno + "','" + jednotky + "','" + znacka + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
               
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);
                MySqlDataReader MyReader2;
               
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                stav = "Výborně data se uložila";
                while (MyReader2.Read()) { }
            }
            catch (Exception ex)
            {
                stav = ex.Message.ToString();
            }
                conn.Close();
        return stav;
        }

        public string AddPyramidka(string V1, string V2, string V3, string pozn)
        {
            string stav = "";
            try
            {
                conn.Open();               
                string Query = "INSERT into pyramidky(V1, V2, V3, pozn) values('" + V1 + "','" + V2 + "','" + V3 + "','" + pozn + "');";               
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                stav = "Výborně data se uložila";
                while (MyReader2.Read()) { }            
            }
            catch (Exception ex) { stav = ex.Message.ToString(); }
            conn.Close();
            return stav;
        }

   

        public string VypisVeliciny(VelicinyManager velicinyManager)
        {
           
            velicinyManager.VelicinyList.Add(new Veliciny(10, "pepicek", "jde do", "Vpředminulém čase"));
            
            string stav = "";
            try
            {
                conn.Open();
                string sql = "SELECT id, jmeno, znacka, jednotky FROM veliciny";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                velicinyManager.VelicinyList.Add(new Veliciny(10, "pepicek", "jde do", "lesa"));
                while (rdr.Read())
                {
                    velicinyManager.VelicinyList.Add(new Veliciny((int)rdr[0], rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString()));
                  
                    //Console.WriteLine(rdr[0] + " -- " + rdr[1]);
                    //Console.WriteLine(rdr[0]);


                }
                rdr.Close();
                stav = "Veličiny načteny do listu";
            }
            catch (Exception ex) { stav = ex.Message.ToString(); }
            conn.Close();
            velicinyManager.VelicinyList.Add(new Veliciny(10, "pepicek", "jde do", "Podruhé do lesa"));
            return stav;
        }
    }
}
