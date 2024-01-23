using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DataAccess;
using BusinessObject;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Mozilla;
using System.Configuration;

namespace BusinessLogic
{
    public class AdminBL
    {
        public MySqlDataReader GetUserByUsernameAndPassword(string username, string password) //Login page storage procedure.
        {
            AdminDA userDA = new AdminDA();
            try
            {
                return userDA.GetUserByUsernameAndPassword(username, password);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MySqlDataReader GetAllEmployee() //GetAllUser Storage Procedure
        {
            AdminDA adminDA = new DataAccess.AdminDA(); //Creating new userDA object for access
            try
            {
                return adminDA.GetAllEmployee();
            }

            catch (Exception ex)
            {
                throw ex;

            }
        }

        public MySqlDataReader GetEmployeeByUsername(string searchName) //Search User storage procedure
        {
            AdminDA userDA = new AdminDA(); //Creating new userDA object for access
            try
            {
                return userDA.GetEmployeeByUsername(searchName);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int UpdateEmployeeByID(Employee employee) //Search User storage procedure
        {
            AdminDA userDA = new AdminDA(); //Creating new userDA object for access
            try
            {
                userDA.UpdateEmployeeByID(employee);
                return 1;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int DeleteUserById(int id) //GridView Display!
        {
            AdminDA userDA = new AdminDA(); //Creating new userDA object for access
            try
            {
                userDA.DeleteUserById(id);
                return 1;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MySqlDataReader SearchUsersByUsername(string searchName) //Search User storage procedure
        {
            AdminDA userDA = new AdminDA(); //Creating new userDA object for access
            try
            {
                return userDA.SearchUsersByUsername(searchName);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertUser(Employee user)
        {
            AdminDA userDA = new AdminDA();
            try
            {
                Regex phoneRegex = new Regex("^[0-9]+$");
                Regex emailRegex = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$"); //Regex checks for patterns

                if (phoneRegex.IsMatch(user.Phone)) //Checks if the entered phone number is valid
                {
                    if (emailRegex.IsMatch(user.Email))//Checks if the new email is valid.
                    {
                        userDA.InsertUser(user);
                        return 1;
                    }
                    else
                    {
                        MessageBox.Show("Please add a valid email!");
                        return 0;
                    }
                }
                else
                {
                    MessageBox.Show("Please add a valid phone number!");
                    return 0;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


            private string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;// Replace with your actual connection string

            public List<Recipe> FetchRecipesFromDatabase()
            {
                List<Recipe> recipes = new List<Recipe>();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM recipes"; // Replace with your actual table name
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                        while (reader.Read())
                        {
                            Recipe recipe = new Recipe
                            {
                                RecipeID = Convert.ToInt32(reader["RecipeID"]),
                                RecipeName = reader["RecipeName"].ToString(),
                                Ingredients = reader["Ingredients"].ToString(),
                                CookingTime = Convert.ToInt32(reader["CookingTime"]),
                                Servings = Convert.ToInt32(reader["Servings"]),
                                RecipeImage = reader["image"] as byte[]
                            };

                            recipes.Add(recipe);
                        }
                    }
                    }
                }

                return recipes;
            }

        public int InsertRecipe(Recipe recipe)
        {
            AdminDA adminDA = new AdminDA();
            try
            {
                adminDA.InsertRecipe(recipe);
                return 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }


    }


