using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace shopManagment.Models.DAL
{
    public class ItemGateway
    {
        private string conString = WebConfigurationManager.ConnectionStrings["ItemDBConnString"].ConnectionString;

        public int Insert (Item aItem)
        {
            int n = 0;

            SqlConnection aSqlConnection = new SqlConnection(conString);
            string query = "Insert into item_tbl Values ('"+aItem.Name+"','"+aItem.Quantity+"','"+aItem.UnitPrice+"')";
            SqlCommand aCommand = new SqlCommand(query, aSqlConnection);
            aSqlConnection.Open();
            n = aCommand.ExecuteNonQuery();
            aSqlConnection.Close();

            return n;

        }
        public List<Item> GetList ()
        {
            List<Item> aItemList = new List<Item>();
            SqlConnection aSqlConnection = new SqlConnection(conString);
            string query = "select * from item_tbl";
            SqlCommand aCommand = new SqlCommand(query, aSqlConnection);
            aSqlConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();
            
            while (aReader.Read())
            {
                Item aItem = new Item();
                aItem.Id = Convert.ToInt32(aReader["id"]);
                aItem.Name = Convert.ToString(aReader["name"]);
                aItem.Quantity = Convert.ToInt32(aReader["quantity"]);
                aItem.UnitPrice = Convert.ToDouble(aReader["unitPrice"]);

                aItemList.Add(aItem); 
            }
            aReader.Close();
            aSqlConnection.Close();

            return aItemList;
        }

    }
}