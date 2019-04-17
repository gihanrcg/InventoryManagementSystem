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
        public static ResultObject insert(String tableName,String fieldString, String valuesString,Dictionary<String,Object> parameters,Boolean isScaler)
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
                if (!isScaler)
                {
                    builder.Append(") VALUES (");
                }
                else
                {
                    builder.Append(") OUTPUT INSERTED.ID VALUES(");
                }
                
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
                    if (isScaler)
                    {
                        String id = cmd.ExecuteScalar().ToString();
                        return new ResultObject(true, id);
                    }
                    else
                    {
                        cmd.ExecuteNonQuery();
                        return new ResultObject(true, null);
                    }                  
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return new ResultObject(false,null);
                }
            }
        }

        public static ResultObject read(String tableName, String fieldString, String whereString)
        {

            using (DBConnect db = new DBConnect())
            {

                StringBuilder builder = new StringBuilder();
                builder.Append("SELECT ");
                builder.Append(fieldString);
                
            }
        }
    
    
    
    }

    class ResultObject
    {
        public Boolean isCompletedSuccessFully;
        public String primaryKey;
        private bool p;
        private string id;

        public ResultObject(Boolean isCompletedSuccessFully,String primarykey)
        {
            this.isCompletedSuccessFully = isCompletedSuccessFully;
            this.primaryKey = primarykey;
        }


    }
}
