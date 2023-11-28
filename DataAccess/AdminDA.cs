using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BusinessObject;


namespace DataAccess
{
    public class AdminDA
    {
        public MySqlDataReader GetUserByUsernameAndPassword(string username, string password)
        {
            try
            {
                MySqlParameter[] myparams = new MySqlParameter[] //We set the parameters if meron man, basically 1 variable has 2 parameters.
                {
                    new MySqlParameter("p_username", username),
                    new MySqlParameter("p_password", password)
                };
                //Storage procedure           , Command Type               , parameters
                return DBHelper.ExecuteParameterizedReader("GetUserByUsernameAndPassword", CommandType.StoredProcedure, myparams);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MySqlDataReader GetAllEmployee() //GridView Display!
        {
            try
            {
                //Since no parameters, just call for execution.
                return DBHelper.ExecuteReader("GetAllEmployee", CommandType.StoredProcedure);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MySqlDataReader GetEmployeeByUsername(string searchName) //Search User storage Procedure.
        {
            try
            {
                MySqlParameter[] myparams = new MySqlParameter[]
                {
                    new MySqlParameter("p_Username", searchName),
                };

                return DBHelper.ExecuteParameterizedReader("GetEmployeeByUsername", CommandType.StoredProcedure, myparams);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MySqlDataReader UpdateEmployeeByID(Employee user) //Update User.
        {
            try
            {
                MySqlParameter[] myparams = new MySqlParameter[]
                {
                    new MySqlParameter("p_ID",user.Id),
                    new MySqlParameter("p_Username", user.UserName),
                    new MySqlParameter("p_Email", user.Email),
                    new MySqlParameter("p_Phone", user.Phone)
                };

                return DBHelper.ExecuteParameterizedReader("UpdateEmployeeByID", CommandType.StoredProcedure, myparams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MySqlDataReader DeleteUserById(int id) //GridView Display!
        {
            try
            {
                MySqlParameter[] myparams = new MySqlParameter[] //We set the parameters if meron man, basically 1 variable has 2 parameters.
              {
                    new MySqlParameter("p_id", id),
              };
                //Storage procedure           , Command Type               , parameters
                return DBHelper.ExecuteParameterizedReader("DeleteUserById", CommandType.StoredProcedure, myparams);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MySqlDataReader SearchUsersByUsername(string searchName) //Search User storage Procedure.
        {
            try
            {
                MySqlParameter[] myparams = new MySqlParameter[]
                {
                    new MySqlParameter("p_searchQuery", searchName),
                };

                return DBHelper.ExecuteParameterizedReader("SearchUsersByUsername", CommandType.StoredProcedure, myparams);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MySqlDataReader InsertUser(Employee user)
        {
            try
            {
                MySqlParameter[] myparams = new MySqlParameter[] //We set the parameters if meron man, basically 1 variable has 2 parameters.
                {
                    new MySqlParameter("p_username", user.UserName),
                    new MySqlParameter("p_password", user.Password),
                    new MySqlParameter("p_phone", user.Phone),
                    new MySqlParameter("p_email", user.Email)
                };
                //Storage procedure           , Command Type               , parameters
                return DBHelper.ExecuteParameterizedReader("InsertUser", CommandType.StoredProcedure, myparams);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}
