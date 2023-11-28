using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using BusinessLogic;
using BusinessObject;
using System.IO;

namespace Training_POS
{
    public partial class AdminPage : MaterialForm
    {
        AdminBL adminBL = new AdminBL();
        bool editMode = false;
        public AdminPage()
        {
            InitializeComponent();
            materialTabControl1.SelectedIndexChanged += materialTabControl1_SelectedIndexChanged;
            UpdateDataGridView();


            AdminBL adminBL = new AdminBL();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            // Set up the DataGridView
            dataGridView1.AutoGenerateColumns = false;

            //ID column details
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.Name = "employee_id";
            col1.DataPropertyName = "employee_id";
            col1.HeaderText = "Employee ID";

            //Username column Details
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.Name = "username";
            col2.DataPropertyName = "username";
            col2.HeaderText = "Username";

            //Phone column details
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.Name = "phone";
            col3.DataPropertyName = "phone"; // 
            col3.HeaderText = "Phone";

            //Email column details.
            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.Name = "email";
            col5.DataPropertyName = "email"; // 
            col5.HeaderText = "Email";

            //Edit Button details in the grid view table
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            editButtonColumn.Name = "EditButton";

            //Delete Button details in the grid view table
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.Name = "DeleteButton";

            // Adds the column to the grid view
            dataGridView1.Columns.Add(col1);
            dataGridView1.Columns.Add(col2);
            dataGridView1.Columns.Add(col3);
            dataGridView1.Columns.Add(col5);
            dataGridView1.Columns.Add(editButtonColumn);
            dataGridView1.Columns.Add(deleteButtonColumn);

            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1107, 259);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            LoadData();

        }

        private void LoadData() //Gets all the data and displays them on grid view upon initialization of Admin Page form.
        {

            using (MySqlDataReader drUser = adminBL.GetAllEmployee())
            {
                if (drUser.HasRows)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(drUser);
                    this.dataGridView1.DataSource = dataTable;
                    this.dataGridView1.Visible = true;
                }

            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text;
            GridView(searchQuery);
        }

        void GridView(string searchQuery) //Sends a SQL Command requesting for a specific username based on user input 
        {

            using (MySqlDataReader drUser = adminBL.GetEmployeeByUsername(searchQuery))
            {
                if (drUser.HasRows)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(drUser);
                    this.dataGridView1.DataSource = dataTable;
                    this.dataGridView1.Visible = true;
                }

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["EditButton"].Index && e.RowIndex >= 0) //Click edit button so you can edit the data
            {
                if (!editMode)
                {
                    // Enable editing for the selected row
                    foreach (DataGridViewCell cell in dataGridView1.Rows[e.RowIndex].Cells)
                    {
                        if (cell.OwningColumn.Name != "EditButton" && cell.OwningColumn.Name != "DeleteButton")
                        {
                            cell.ReadOnly = false;
                        }
                    }

                    editMode = true;
                }
                else
                {
                    DataRow row = ((DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem).Row;
                    Employee editedUser = new Employee(
                    Convert.ToInt32(row["employee_id"]),
                    row["username"].ToString(),
                    row["phone"].ToString(),
                    row["email"].ToString()
                     );

                    int rowsAffected = AdminBL.UpdateEmployeeByID(editedUser);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Changes saved successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to save changes.");
                    }
                    foreach (DataGridViewCell cell in dataGridView1.Rows[e.RowIndex].Cells)
                    {
                        if (cell.OwningColumn.Name != "EditButton" && cell.OwningColumn.Name != "DeleteButton")
                        {
                            cell.ReadOnly = true;
                        }
                    }
                    editMode = false;
                }
            }
            else if (e.ColumnIndex == dataGridView1.Columns["DeleteButton"].Index && e.RowIndex >= 0) //DELETE button logic
            {
                if (MessageBox.Show("Are you sure you want to delete this row?", "Delete Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Get the ID of the record to be deleted
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["employee_id"].Value);

                    int drUser = adminBL.DeleteUserById(id);
                    {
                        if (drUser > 0)
                        {
                            MessageBox.Show("Record deleted successfully.");

                            // Get the data source from DataGridView (assuming it's a DataTable)
                            DataTable dataSource = (DataTable)dataGridView1.DataSource;

                            // Remove the row at the specified index
                            dataSource.Rows.RemoveAt(e.RowIndex);

                            // Reset the data source of DataGridView to reflect the changes
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = dataSource;
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the record.");
                        }

                    }

                }

            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Put user inputs here
            string username = txtUsername.Text;
            string hashedPassword = Encrypt.EncryptPassword(this.txtPassword.Text); //Encrypt the password
            string phone = txtPhone.Text;
            string email = txtEmail.Text;

            // Check if txt boxes have inputs
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(hashedPassword) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            try
            {
                //Inserts new data into the new stored procedure command.
                Employee user = new Employee(username, hashedPassword, phone, email);
                int rowsAffected = adminBL.InsertUser(user);

                if (rowsAffected > 0) //Checks if any rows were changed or added.
                {
                    MessageBox.Show("User added successfully.");

                }
                else
                {
                    MessageBox.Show("Failed to add user.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check which tab is selected
            if (materialTabControl1.SelectedTab == tabPage1) // Replace with the actual tabPage you want to handle
            {
                // Update the DataGridView based on the selected tab
                UpdateDataGridView();
            }
        }

        private void UpdateDataGridView()
        {
            // Assuming you have a method to fetch data from the database'
            MySqlDataReader drUser = adminBL.GetAllEmployee();
            DataTable newData = new DataTable(); // Replace with your actual data-fetching method
            newData.Load(drUser);

            // Assuming your DataGridView is named dataGridView1
            dataGridView1.DataSource = null; // Clear the current data source
            dataGridView1.Rows.Clear(); // Clear existing rows if any

            // Bind the new data to the DataGridView
            if (newData != null && newData.Rows.Count > 0)
            {
                dataGridView1.DataSource = newData;
            }
            else
            {
                // Handle case where no data is available or show a message
                MessageBox.Show("No data available for the selected tab.");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string filePath = "Users.csv";

            using (MySqlDataReader drUser = adminBL.GetAllEmployee())
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write the column headers
                    writer.WriteLine("id,Username,Phone,Email");

                    // Write the data
                    while (drUser.Read())
                    {
                        writer.Write(drUser["employee_id"] + ",");
                        writer.Write(drUser["username"].ToString() + ",");
                        writer.Write(drUser["phone"].ToString() + ",");
                        writer.Write(drUser["email"].ToString());
                        writer.WriteLine();
                    }
                }

            }
            MessageBox.Show("Data exported to Users.csv");
        }
    }
}
