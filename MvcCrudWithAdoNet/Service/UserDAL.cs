using MvcCrudWithAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MvcCrudWithAdoNet.Service
{
    public class UserDAL
    {
        SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);

        public List<UserModel> GetUsers()
        {

        }
    }
}