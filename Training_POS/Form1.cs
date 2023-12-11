using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MaterialSkin;
using MaterialSkin.Controls;
using BusinessLogic;
using BusinessObject;


namespace Training_POS
{
    public partial class Form1 : MaterialForm
    {
        AdminBL admin = new AdminBL();
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string inputHashedPassword = Encrypt.EncryptPassword(this.txtPassword.Text);

            using (MySqlDataReader drUser = admin.GetUserByUsernameAndPassword(this.txtUsername.Text, inputHashedPassword))
            {
                try
                {
                    if (drUser.HasRows)
                    {
                        while (drUser.Read())
                        {
                            //Storing found info into variables
                            int id = Convert.ToInt32(drUser["employee_id"]);
                            string userName = drUser["username"].ToString();
                            string password = drUser["password"].ToString();
                            string phone = drUser["phone"].ToString();
                            string email = drUser["email"].ToString();

                            //Storing inputs into user object
                            Employee loggedInUser = new Employee(id, userName, password, phone, email);

                            int role = loggedInUser.Id; //if user is an admin (With ID=1)
                            if (role == 1) //Login to Admin Dashboard
                            {
                                MessageBox.Show("Successfully logged in Admin Dashboard!");
                                AdminPage adminPage = new AdminPage();
                                adminPage.Show();
                                this.Hide();
                            }
                            else //Else login to main page.
                            {
                                MessageBox.Show("Successfully logged in!");
                                MainPage mainPage = new MainPage();
                                mainPage.Show();
                                this.Hide();
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid User!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    drUser.Close();
                }

            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
           // Registration registrationPage = new Registration();
            //registrationPage.Show();
            this.Hide();
        }
    }
}
