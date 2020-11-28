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
using System.Configuration;

namespace SunStoreDisconnectedMode
{
    public partial class SunStoreDisconnectedModefrm : Form
    {
        public SunStoreDisconnectedModefrm()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet dset = new DataSet();
        DataTable dt = new DataTable();
        DataRow dr;

        private void LoadIDs()
        {
            dset.Tables.Clear();
            dt.Rows.Clear();
            ProductIDcbx.Items.Clear();

            sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["SunStoreConnectionString"].ConnectionString;
            try
            {
                cmd.CommandText = "select ProductID from Products";
                cmd.Connection = sqlcon;
                adapter.SelectCommand = cmd;
                dt = new DataTable("Products");
                dset.Tables.Add(dt);
                adapter.Fill(dset.Tables["Products"]);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ProductIDcbx.Items.Add(dt.Rows[i][0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void LoadData()
        {
            sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["SunStoreConnectionString"].ConnectionString;
            try
            {
                dset.Tables.Clear();
                dt.Rows.Clear();

                cmd.CommandText = "select * from Products";
                cmd.Connection = sqlcon;
                adapter.SelectCommand = cmd;
                dt.TableName = "Products";
                dset.Tables.Add(dt);
                adapter.Fill(dset.Tables["Products"]);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void Loadbtn_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SunStoreDisconnectedModefrm_Load_1(object sender, EventArgs e)
        {
            LoadIDs();
            LoadData();
            ProductIDcbx.Hide();
            ProductsIDlbl.Hide();
            ProductNametxt.Hide();
            ProductNamelbl.Hide();
            Pricetxt.Hide();
            Pricelbl.Hide();
            btn.Hide();
            btn.Text = "";

        }

        private void INSradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (INSradiobtn.Checked == true)
            {
                ProductIDcbx.Hide();
                ProductsIDlbl.Hide();
                ProductNametxt.Show();
                ProductNamelbl.Show();
                Pricetxt.Show();
                Pricelbl.Show();
                btn.Show();
                btn.Text = "ADD";
            }
        }

        private void UPDradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (UPDradiobtn.Checked == true)
            {
                ProductIDcbx.Show();
                ProductsIDlbl.Show();
                ProductNametxt.Show();
                ProductNamelbl.Show();
                Pricetxt.Show();
                Pricelbl.Show();
                btn.Show();
                btn.Text = "Edit";
            }
        }

        private void DELradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (DELradiobtn.Checked == true)
            {
                ProductIDcbx.Show();
                ProductsIDlbl.Show();
                ProductNametxt.Hide();
                ProductNamelbl.Hide();
                Pricetxt.Hide();
                Pricelbl.Hide();
                btn.Show();
                btn.Text = "Delete";
            }
        }

        private void Searchbtn_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Searchbtn.Checked == true)
            {
                ProductIDcbx.Hide();
                ProductsIDlbl.Hide();
                ProductNametxt.Show();
                ProductNamelbl.Show();
                Pricetxt.Show();
                Pricelbl.Show();
                btn.Show();
                btn.Text = "Search";
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Parameters.Clear();
                sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["SunStoreConnectionString"].ConnectionString;
                if (INSradiobtn.Checked == true)
                {
                    cmd.CommandText = "insert into Products(ProductName,Price) values(@ProductName,@Price)";
                    cmd.Connection = sqlcon;
                    adapter.InsertCommand = cmd;
                    cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar, 50).Value = ProductNametxt.Text;
                    cmd.Parameters.Add("@Price", SqlDbType.Money).Value = Pricetxt.Text;
                    dr = dset.Tables["Products"].NewRow();
                    dr["ProductName"] = ProductNametxt.Text;
                    dr["Price"] = Pricetxt.Text;
                    dset.Tables["Products"].Rows.Add(dr);
                    adapter.Update(dset.Tables["Products"]);
                    LoadIDs();
                    LoadData();
                    cmd.Parameters.Clear();
                }
                else if (UPDradiobtn.Checked == true)
                {
                    if (ProductNametxt.Text != "" && Pricetxt.Text == "")
                    {
                        cmd.CommandText = "update Products set ProductName = @ProductName  where ProductID = @ProductID";
                        cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar, 50).Value = ProductNametxt.Text;
                        cmd.Parameters.Add("@ProductID", SqlDbType.BigInt).Value = ProductIDcbx.SelectedItem;
                        cmd.Connection = sqlcon;
                        adapter.UpdateCommand = cmd;
                        dr = dset.Tables["Products"].Rows[ProductIDcbx.SelectedIndex];
                        dr["ProductName"] = ProductNametxt.Text;
                        adapter.Update(dset.Tables["Products"]);
                    }
                    else if (ProductNametxt.Text == "" && Pricetxt.Text != "")
                    {
                        cmd.CommandText = "update Products set Price = @Price where ProductID = @ProductID";
                        cmd.Connection = sqlcon;
                        adapter.UpdateCommand = cmd;
                        cmd.Parameters.Add("@ProductID", SqlDbType.BigInt).Value = ProductIDcbx.SelectedItem;
                        cmd.Parameters.Add("@Price", SqlDbType.Money).Value = Pricetxt.Text;
                        dr = dset.Tables["Products"].Rows[ProductIDcbx.SelectedIndex];
                        dr["Price"] = Pricetxt.Text;
                        adapter.Update(dset.Tables["Products"]);
                    }
                    else if (ProductNametxt.Text != "" && Pricetxt.Text != "")
                    {
                        cmd.CommandText = "update Products set ProductName = @ProductName,Price = @Price  where ProductID = @ProductID";
                        cmd.Connection = sqlcon;
                        adapter.UpdateCommand = cmd;
                        cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar, 50).Value = ProductNametxt.Text;
                        cmd.Parameters.Add("@Price", SqlDbType.Money).Value = Pricetxt.Text;
                        cmd.Parameters.Add("@ProductID", SqlDbType.BigInt).Value = ProductIDcbx.SelectedItem;
                        dr = dset.Tables["Products"].Rows[ProductIDcbx.SelectedIndex];
                        dr["ProductName"] = ProductNametxt.Text;
                        dr["Price"] = Pricetxt.Text;
                        adapter.Update(dset.Tables["Products"]);
                    }
                    LoadData();
                    cmd.Parameters.Clear();
                }
                else if (DELradiobtn.Checked == true)
                {
                    cmd.CommandText = "delete from Products where ProductID = @ProductID";
                    cmd.Parameters.Add("@ProductID", SqlDbType.BigInt).Value = ProductIDcbx.SelectedItem;
                    cmd.Connection = sqlcon;
                    adapter.DeleteCommand = cmd;
                    dr = dset.Tables["Products"].Rows[ProductIDcbx.SelectedIndex];
                    dr.Delete();
                    adapter.Update(dset.Tables["Products"]);
                    LoadIDs();
                    LoadData();
                    cmd.Parameters.Clear();
                }
                else if (Searchbtn.Checked == true)
                {
                    DataTable dts = new DataTable();
                    dts.TableName = "SearchResult";
                    dset.Tables.Add(dts);
                    dts.Rows.Clear();
                    if (ProductNametxt.Text != "" && Pricetxt.Text == "")
                    {
                        cmd.CommandText = "Select * from Products where ProductName = @ProductName";
                        cmd.Connection = sqlcon;
                        cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar, 50).Value = ProductNametxt.Text;
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dset.Tables["SearchResult"]);
                        dataGridView1.DataSource = dts;
                    }
                    else if (ProductNametxt.Text == "" && Pricetxt.Text != "")
                    {
                        cmd.CommandText = "Select * from Products where Price " + comboBox1.SelectedItem + " @Price";
                        cmd.Connection = sqlcon;
                        cmd.Parameters.Add("@Price", SqlDbType.Money).Value = Pricetxt.Text;
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dset.Tables["SearchResult"]);
                        dataGridView1.DataSource = dts;
                    }
                    else if (ProductNametxt.Text != "" && Pricetxt.Text != "")
                    {
                        cmd.CommandText = "Select * from Products  where ProductName = @ProductName and Price " + comboBox1.SelectedItem + " @Price";
                        cmd.Connection = sqlcon;
                        cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar, 50).Value = ProductNametxt.Text; ;
                        cmd.Parameters.Add("@Price", SqlDbType.Money).Value = Pricetxt.Text;
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dset.Tables["SearchResult"]);
                        dataGridView1.DataSource = dts;
                    }
                    cmd.Parameters.Clear();
                    dset.Tables.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                sqlcon.Close();
            }
        }
    }
}