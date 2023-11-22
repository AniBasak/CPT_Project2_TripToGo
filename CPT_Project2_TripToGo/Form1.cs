using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CPT_Project2_TripToGo
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=ANI-NITRO5\\SQLEXPRESS;Initial Catalog=ANI_DB;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            fillbox1();
            fillbox2();
            fillbox3();
            fillbox4();
            show();
        }

        public void fillbox1()
        {
            string sql = "select distinct scity from CPT_TripToGo_DB4";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(0);
                    cbox_city.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Occurred\n" + ex.Message);
            }
            con.Close();
        }

        public void fillbox2()
        {
            string sql = "select distinct stype from CPT_TripToGo_DB4";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(0);
                    cbox_type.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Occurred\n" + ex.Message);
            }
            con.Close();
        }

        public void fillbox3()
        {
            string sql = "select distinct stime from CPT_TripToGo_DB4";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(0);
                    cbox_time.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Occurred\n" + ex.Message);
            }
            con.Close();
        }

        public void fillbox4()
        {
            string sql = "select distinct scost from CPT_TripToGo_DB4";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(0);
                    cbox_cost.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Occurred\n" + ex.Message);
            }
            con.Close();
        }
        
        public void show()
        {
            string sql = "SELECT * FROM CPT_TripToGo_DB4";
            //SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                SqlDataAdapter sqladp = new SqlDataAdapter(sql, con);
                DataTable dtb1 = new DataTable();
                sqladp.Fill(dtb1);
                datagrid1.DataSource = dtb1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Occurred\n" + ex.Message);
            }
            con.Close();
        }  

        public void filtershow()
        {
            string sql = "SELECT * FROM CPT_TripToGo_DB4 WHERE sname = '" + t_sname.Text + "';";
            //SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                SqlDataAdapter sqladp = new SqlDataAdapter(sql, con);
                DataTable dtb1 = new DataTable();
                sqladp.Fill(dtb1);
                datagrid1.DataSource = dtb1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Occurred\n" + ex.Message);
            }
            con.Close();
        }

        public void combosilter()
        {
            string sql = "SELECT * FROM CPT_TripToGo_DB4 WHERE scity = '"+cbox_city.Text+"' AND stype = '"+cbox_type.Text+"' AND stime = '"+cbox_time.Text+"' AND scost = '"+cbox_cost.Text+"';";
            //SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                SqlDataAdapter sqladp = new SqlDataAdapter(sql, con);
                DataTable dtb1 = new DataTable();
                sqladp.Fill(dtb1);
                datagrid1.DataSource = dtb1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Occurred\n" + ex.Message);
            }
            con.Close();
        }

        private void cbox_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void b_search_Click(object sender, EventArgs e)
        {
            filtershow();
        }

        private void b_filter_Click(object sender, EventArgs e)
        {
            combosilter();
        }

        private void b_refresh_Click(object sender, EventArgs e)
        {
            cbox_city.Text = "";
            cbox_type.Text = "";
            cbox_time.Text = "";
            cbox_cost.Text = "";
            t_sname.Text = "";
            show();
        }

        static List<int> list = new List<int>();

        private void datagrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string temp;
            DataGridViewRow row = datagrid1.Rows[e.RowIndex];
            //list.Add(row.Cells["id"].Value);
            temp = row.Cells[0].Value.ToString();
            MessageBox.Show(temp);
            list.Add(Int32.Parse(temp));
        }
        static int[] arraynums = list.ToArray();
       
        private void b_show_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In Show"+list);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
                MessageBox.Show(list[i].ToString());
            }
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void t_sname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
