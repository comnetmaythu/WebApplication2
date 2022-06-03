using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages.Html;

namespace WebApplication2.Models
{
    //maythu 20220603 add 
    //testing 2
    public class Employee
    {
        [Display(Name = "Name")]
        public string EmployeeName { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        //public string Gender { get; set; }
        public string City { get; set; }
        public decimal Salary { get; set; }
        public Gender EmployeeGender { get; set; }

       

        private bool connection_open;
        private MySqlConnection connection;

        //public Employee()
        //{
        //    Get_Connection();
        //    //DB_Connect.CloseTheConnection(connection);
        //    try
        //    {
        //        MySqlCommand cmd = new MySqlCommand();
        //        cmd.Connection = connection;
        //        cmd.CommandText = "SELECT EmployeeId,Name,Gender,City,Salary FROM mvcdb.employee; ";
        //        MySqlDataReader reader = cmd.ExecuteReader();

        //        try
        //        {
        //            reader.Read();
        //            if (reader.IsDBNull(0) == false)
        //                EmployeeId = reader.GetInt32(0);
        //            else
        //                Name = null;

        //            if (reader.IsDBNull(0) == false)
        //                Name = reader.GetString(0);
        //            else
        //                Name = null;

        //            if (reader.IsDBNull(0) == false)
        //                Gender = reader.GetString(0);
        //            else
        //                Name = null;

        //            if (reader.IsDBNull(0) == false)
        //                City = reader.GetString(0);
        //            else
        //                Name = null;

        //            if (reader.IsDBNull(0) == false)
        //                Salary = reader.GetDecimal(0);
        //            else
        //                Name = null;

        //            reader.Close();

        //        }
        //        catch (MySqlException e)
        //        {
        //            reader.Close();
        //        }

        //    }
        //    catch (MySqlException e)
        //    { connection.Close(); }
        //}



        //private void Get_Connection()
        //{
        //    connection_open = false;

        //    connection = new MySqlConnection();
        //    //connection = DB_Connect.Make_Connnection(ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString);
        //    connection.ConnectionString = ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;

        //    //            if (db_manage_connnection.DB_Connect.OpenTheConnection(connection))
        //    if (Open_Local_Connection())
        //    {
        //        connection_open = true;
        //    }
        //    else
        //    {
        //        //					MessageBox::Show("No database connection connection made...\n Exiting now", "Database Connection Error");
        //        //					 Application::Exit();
        //    }

        //}

        //private bool Open_Local_Connection()
        //{
        //    try
        //    {
        //        connection.Open();
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        return false;
        //    }
        //}
    }

    public enum Gender
    {
        Male,
        Female
    }

}