using Module_7ApiDatabase.Models;

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;

using System.Linq;
using System.Web;

namespace Module_7ApiDatabase
{
    /// <summary>
    ///    Business Logic for all the CRUD operations on Cricketer table from database 
    /// </summary>
    //BL file for Cricketer table
    public class CricketerBL : DatabaseConfig
    {
        /// <summary>
        ///    Get All Operation 
        /// </summary>
        /// <param name="cricketer"></param>
        /// <returns>List of Cricketers</returns>
        public List<Cricketer> Get(Cricketer cricketer)
        {
            //SQL Get All query string
            string _get_query = "SELECT CricketerId,CricketerName,Team,Runs FROM Cricketer";

            using (MySqlConnection objConn = new MySqlConnection(ConnectionString))
            {
                objConn.Open();
                using (MySqlCommand objCmd = new MySqlCommand(_get_query, objConn))
                {

                    objCmd.CommandType = System.Data.CommandType.Text;
                    objCmd.CommandText = _get_query;

                    List<Cricketer> objCricketer = new List<Cricketer>();
                    using (MySqlDataReader objSDR = objCmd.ExecuteReader())
                    {
                        while (objSDR.Read())
                        {
                            objCricketer.Add(new Cricketer()
                            {
                                CricketerId = Convert.ToInt32(objSDR["CricketerId"]),
                                CricketerName = Convert.ToString(objSDR["CricketerName"]),
                                Team = Convert.ToString(objSDR["Team"]),
                                Runs = Convert.ToInt32(objSDR["Runs"])
                            });
                        }

                    }
                    return objCricketer;
                }
            }
        }

        /// <summary>
        ///     Get by Id
        /// </summary>
        /// <param name="CricketerId"></param>
        /// <returns>One record of Cricketer according to the Id</returns>
        public Cricketer GetById(int CricketerId)
        {
            //SQL Get By ID query string
            string _get_query = "SELECT CricketerId,CricketerName,Team,Runs FROM Cricketer WHERE CricketerId=@CricketerId";

            using (MySqlConnection objConn = new MySqlConnection(ConnectionString))
            {
                objConn.Open();
                using (MySqlCommand objCmd = new MySqlCommand(_get_query, objConn))
                {

                    objCmd.CommandType = System.Data.CommandType.Text;
                    objCmd.CommandText = _get_query;

                    objCmd.Parameters.AddWithValue("@CricketerId", CricketerId);

                    Cricketer objCricketer = new Cricketer();
                    using (MySqlDataReader objSDR = objCmd.ExecuteReader())
                    {
                        while (objSDR.Read())
                        {
                            objCricketer.CricketerId = Convert.ToInt32(objSDR["CricketerId"]);
                            objCricketer.CricketerName = Convert.ToString(objSDR["CricketerName"]);
                            objCricketer.Team = Convert.ToString(objSDR["Team"]);
                            objCricketer.Runs = Convert.ToInt32(objSDR["Runs"]);

                        }
                    }
                    return objCricketer;
                }
            }
        }

        /// <summary>
        ///     Insert Operation
        /// </summary>
        /// <param name="cricketer"></param>
        /// <returns>String to notify Success of operation </returns>       
        public String Insert(Cricketer cricketer)
        {
            ////SQL Insert query string
            string _insert_query = "INSERT INTO Cricketer (CricketerName,Team,Runs) VALUES (@CricketerName,@Team,@Runs)";

            using (MySqlConnection objConn = new MySqlConnection(ConnectionString))
            {
                objConn.Open();
                using (MySqlCommand objCmd = new MySqlCommand(_insert_query, objConn))
                {
                    try
                    {
                        objCmd.CommandType = System.Data.CommandType.Text;
                        objCmd.CommandText = _insert_query;

                        objCmd.Parameters.AddWithValue("@CricketerName", cricketer.CricketerName);
                        objCmd.Parameters.AddWithValue("@Team", cricketer.Team);
                        objCmd.Parameters.AddWithValue("@Runs", cricketer.Runs);

                        int ans = objCmd.ExecuteNonQuery();
                        if (ans > 0)
                        {
                            return "Inserted Successfully";
                        }

                        return "Insertion Unsuccessful";

                    }
                    catch (Exception ex)
                    {
                        return ex.ToString();
                    }

                    finally
                    {
                        objConn.Close();
                    }
                }
            }
        }

        /// <summary>
        ///     Update operation
        /// </summary>
        /// <param name="cricketer"></param>
        /// <returns>String to notify Success of operation </returns>  
        public String Update(int CricketerId, Cricketer cricketer)
        {
            //SQL Update query string
            string _update_query = "UPDATE Cricketer SET CricketerName=@CricketerName,Team=@Team,Runs=@Runs WHERE CricketerId=@CricketerId";

            using (MySqlConnection objConn = new MySqlConnection(ConnectionString))
            {
                objConn.Open();
                using (MySqlCommand objCmd = new MySqlCommand(_update_query, objConn))
                {
                    try
                    {
                        objCmd.CommandType = System.Data.CommandType.Text;
                        objCmd.CommandText = _update_query;

                        objCmd.Parameters.AddWithValue("@CricketerId", CricketerId);
                        objCmd.Parameters.AddWithValue("@CricketerName", cricketer.CricketerName);
                        objCmd.Parameters.AddWithValue("@Team", cricketer.Team);
                        objCmd.Parameters.AddWithValue("@Runs", cricketer.Runs);

                        int ans = objCmd.ExecuteNonQuery();
                        if (ans > 0)
                        {
                            return "Updated Successfully";
                        }

                        return "Updation Unsuccessful";
                    }
                    catch (Exception ex)
                    {
                        return ex.ToString();
                    }

                    finally
                    {
                        objConn.Close();
                    }
                }
            }
        }

        /// <summary>
        ///     Delete operation
        /// </summary>
        /// <param name="cricketer"></param>
        /// <returns>String to notify Success of operation </returns> 
        public String Delete(int CricketerId)
        {
            //SQL Delete query String
            string _delete_query = "DELETE CricketerId,CricketerName,Team,Runs FROM Cricketer WHERE CricketerId=@CricketerId";

            using (MySqlConnection objConn = new MySqlConnection(ConnectionString))
            {
                objConn.Open();
                using (MySqlCommand objCmd = new MySqlCommand(_delete_query, objConn))
                {
                    try
                    {
                        objCmd.CommandType = System.Data.CommandType.Text;
                        objCmd.CommandText = _delete_query;

                        objCmd.Parameters.AddWithValue("@CricketerId", CricketerId);

                        int ans = objCmd.ExecuteNonQuery();
                        if (ans > 0)
                        {
                            return "Deleted Successfully";
                        }

                        return "Deletion Unsuccessful";
                    }
                    catch (Exception ex)
                    {
                        return ex.ToString();
                    }

                    finally
                    {
                        objConn.Close();
                    }
                }
            }
        }
    }
}