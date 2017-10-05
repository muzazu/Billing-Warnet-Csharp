using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Koneksi
{
    class Model
    {
        private string connectionString = Aplikasi_Billing_Warnet___Server.Properties.Settings.Default.DatabaseConnectionString;
        
        //gridview refresh data
        public void refresh(DataTable table, string target, DataGridView _datagridview = null)
        {
            using (SqlConnection conn  = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM "+target, conn);
                    DataTable datatable = table;
                    using (SqlDataAdapter ra = new SqlDataAdapter(cmd))
                    {
                        ra.Fill(datatable);
                    }
                    if(_datagridview != null)
                        _datagridview.DataSource = datatable;
                }
                catch (Exception exeption)
                {
                    MessageBox.Show(exeption.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        //Get, Update dan Insert Query
        public void query(string command)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(command, conn);
                }
                catch (Exception exeption)
                {
                    MessageBox.Show(exeption.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
