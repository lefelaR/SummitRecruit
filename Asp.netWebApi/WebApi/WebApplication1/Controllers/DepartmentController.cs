using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

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
    }
}
