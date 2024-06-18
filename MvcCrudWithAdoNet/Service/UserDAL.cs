using MvcCrudWithAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MvcCrudWithAdoNet.Service
{
    public class UserDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;
        public List<UserModel> GetUsers()
        {
            cmd = new SqlCommand("sp_select", con);
            cmd.CommandType = CommandType.StoredProcedure;
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);

            List<UserModel> list = new List<UserModel>();
            foreach(DataRow dr in dt.Rows)
            {
                list.Add(new UserModel
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Name = dr["Name"].ToString(),
                    Email = dr["Email"].ToString(),
                    Age = Convert.ToInt32(dr["Age"])
                });
            }
            return list;
        }
    }
}