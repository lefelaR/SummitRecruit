using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DepartmentController : ApiController
    {

        public HttpResponseMessage Get()
        {
            //use store procedures after this example
            string qry = @"Select DepartmentId, DepartmentName from dbo.Department";
            DataTable table = new DataTable();
            using(var con = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeDb"].ConnectionString))
                using (var cmd = new SqlCommand(qry,con))
                using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK,table);
           
        }



        public string Post(Department dep)
        {

            try
            {
                //use store procedures after this example
                string qry = @"insert into dbo.Department (DepartmentName) values ('"+ dep.DepartmentName +"');";
                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeDb"].ConnectionString))
                using (var cmd = new SqlCommand(qry, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }
                return "200!!! Data Successfully posted into table row";
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }


        public string Put(Department dep)
        {

            try
            {
                //use store procedures after this example
                string qry = @"
                Update dbo.Department set DepartmentName = '"+ dep.DepartmentName+ @"' where DepartmentId =" + dep.DepartmentId + @"";
                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeDb"].ConnectionString))
                using (var cmd = new SqlCommand(qry, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }
                return "update successful";
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string Del (int Id)
        {

            try
            {
                //use store procedures after this example
                string qry = "delete from dbo.Department where DepartmentId ="+Id;
                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeDb"].ConnectionString))
                using (var cmd = new SqlCommand(qry, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }
                return "Item removed from record permanently";
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
