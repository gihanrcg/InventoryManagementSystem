using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.DBOperations
{
    static class CrudOperations
    {
        public static bool insert(String tableName,String fieldString, String valuesString,Dictionary<String,Object> parameters )
        {

            using (DBConnect db = new DBConnect())
            {
                StringBuilder builder = new StringBuilder();
                builder.Append("INSERT INTO ");
                builder.Append(tableName);  
                builder.Append("(");
                foreach(String field in fieldString.Split(',')){
                      if(builder.ToString().EndsWith("(")){
                          builder.Append(field);
                      }
                      else
                      {
                          builder.Append(", " +field);
                      }                    
                }
                builder.Append(") VALUES (");
                foreach (String value in valuesString.Split(','))
                {
                    if (builder.ToString().EndsWith("("))
                    {
                        builder.Append(value);
                    }
                    else
                    {
                        builder.Append(", " + value);
                    }
                }
                builder.Append(")");

                SqlCommand cmd = new SqlCommand(builder.ToString(), db.con);

                if (parameters != null)
                {
                    foreach(KeyValuePair<String,Object> pair in parameters){
                        cmd.Parameters.AddWithValue(pair.Key, pair.Value);
                    }
                }

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }

    }

    static class ResultObject
    {
        public Boolean isCompletedSuccessFully;
        public String primaryKey;
    }
}
