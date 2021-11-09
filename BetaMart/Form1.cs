using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace BetaMart
{
    public partial class Form1 : Form
    {
        OleDbConnection oleDbConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Shefira Harani\Documents\BetaMart.accdb");
        int id_edit_item;
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void save_add_Click(object sender, EventArgs e)
        {
            string name_barang = textBox2.Text;
            int price_barang = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            int stock_barang = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));

            try
            {
                oleDbConnection.Open();
                string query = "INSERT INTO barang (name_barang, price_barang, stock_barang) VALUES ('" + name_barang + "'," + price_barang + "," + stock_barang + ")";
                OleDbCommand command = new OleDbCommand(query, oleDbConnection);
                command.ExecuteNonQuery();

                MessageBox.Show("Yeay! Barang Berhasil Ditambahkan!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Maaf, Terjadi Kesalahan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                oleDbConnection.Close();

                panel2.Visible = false;
                panel1.Visible = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void betamart_visible_changed(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                try
                {
                    oleDbConnection.Open();
                    string query = "SELECT * FROM barang";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, oleDbConnection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Maaf, Terjadi Kesalahan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    oleDbConnection.Close();
                }
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void editt_Click(object sender, EventArgs e)
        {
            int id_edit = Convert.ToInt32(Math.Round(numericUpDown5.Value, 0));

            try
            {
                oleDbConnection.Open();
                string query = "SELECT * FROM barang WHERE (ID_Barang = " + id_edit + ")";
                OleDbCommand command = new OleDbCommand(query, oleDbConnection);
                using(OleDbDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        panel1.Visible = false;
                        panel3.Visible = true;

                        id_edit_item = int.Parse(String.Format("{0}", reader["ID_Barang"]));
                        textBox3.Text = String.Format("{0}", reader["name_barang"]);
                        numericUpDown4.Value = int.Parse(String.Format("{0}", reader["price_barang"]));
                        numericUpDown3.Value = int.Parse(String.Format("{0}", reader["stock_barang"]));
                    }
                    else
                    {
                        MessageBox.Show("Maaf, Data Tidak Ditemukan!", "Info");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Maaf, Terjadi Kesalahan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                oleDbConnection.Close();
            }
        }

        private void cancel_edit_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel1.Visible = true;
        }

        private void save_edit_Click(object sender, EventArgs e)
        {
            string name_barang = textBox3.Text;
            int price_barang = Convert.ToInt32(Math.Round(numericUpDown4.Value, 0));
            int stock_barang = Convert.ToInt32(Math.Round(numericUpDown3.Value, 0));

            try
            {
                oleDbConnection.Open();
                string query = "UPDATE barang SET name_barang = '" + name_barang + "', price_barang=" + price_barang + ", stock_barang = " + stock_barang + " WHERE ID_Barang = " + id_edit_item + "";


                OleDbCommand command = new OleDbCommand(query, oleDbConnection);
                command.ExecuteNonQuery();

                MessageBox.Show("Yeay! Barang Berhasil Diubah!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Maaf, Terjadi Kesalahan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                oleDbConnection.Close();

                panel3.Visible = false;
                panel1.Visible = true;
            }
        }

        private void cancel_add_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id_delete = Convert.ToInt32(Math.Round(numericUpDown6.Value, 0));

            DialogResult dialogresult = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data Dengan ID " + id_delete + "", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(dialogresult == DialogResult.Yes)
            {
                try
                {
                    oleDbConnection.Open();
                    string query = "DELETE FROM barang WHERE ID_Barang = " + id_delete;
                    OleDbCommand command = new OleDbCommand(query, oleDbConnection);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Yeay! Barang Berhasil Dihapus!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Maaf, Terjadi Kesalahan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    oleDbConnection.Close();

                    panel1.Visible = false;
                    panel1.Visible = true;
                }
            }
        }
    }
}
