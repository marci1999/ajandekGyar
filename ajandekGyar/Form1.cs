using ajandekGyar;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AjandekListaApp
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=ajandek; Uid=root; Pwd=;");
            conn.Open();

            this.FormClosed += (sender, args) => {
                if (conn != null)
                {
                    conn.Close();
                }
            };

            AdatBetoltes();
        }

        void AdatBetoltes()
        {
            string sql = @"
SELECT id, nev, uzlet
FROM ajandek
ORDER BY nev
";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nev = reader.GetString("nev");

                    string uzlet;
                    try
                    {
                        uzlet = reader.GetString("uzlet");
                    }
                    catch (SqlNullValueException ex)
                    {
                        uzlet = null;
                    }
                    var ajandek = new Ajandek(id, nev, uzlet);
                    ajandekListBox.Items.Add(ajandek);


                    /*Lehessen:
- Adjándékot törölni
* A lista kiválasztás alapján

- Ajándék részletes adatainak megjelenítése
* ID, név, üzlet
* Ha nincs üzlet (== null), akkor "Saját készítésű"

 - Létező ajándék szerkesztése
* Önálló tervezési feladat!

Irányelvek:
* Paraméteres lekérdezés, ahol lehet!
* Hibás inputokat kezeljük!*/
                }
            }
        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            if (cBSajat.Checked)
            {
                string sql = @"
INSERT INTO `ajandek`(`nev`, `uzlet`) 
VALUES (@nev, @uzlet)
";

                var comm = this.conn.CreateCommand();
                comm.CommandText = sql;
                comm.Parameters.AddWithValue("@nev", tBNev.Text);
                comm.Parameters.AddWithValue("@uzlet", null);
                comm.ExecuteNonQuery();
            }
            else
            {
                string sql = @"
INSERT INTO `ajandek`(`nev`, `uzlet`) 
VALUES (@nev, @uzlet)
";
                var comm = this.conn.CreateCommand();
                comm.CommandText = sql;
                comm.Parameters.AddWithValue("@nev", tBNev.Text);
                comm.Parameters.AddWithValue("@uzlet", tBUzlet.Text);
                comm.ExecuteNonQuery();
            }

            ajandekListBox.Items.Clear();
            AdatBetoltes();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            string sql = @"
DELETE 
FROM `ajandek` 
WHERE `id` = @id
";

            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            var ajandek = (Ajandek)ajandekListBox.SelectedItem;
            comm.Parameters.AddWithValue("@id", ajandek.Id);
            comm.ExecuteNonQuery();

            ajandekListBox.SelectedIndex = -1;
            bDelete.Visible = false;

            ajandekListBox.Items.Clear();
            AdatBetoltes();
        }

        private void ajandekListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bDelete.Visible = true;
        }
    }
}