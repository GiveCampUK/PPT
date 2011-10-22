using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Common
{
    public class Country : AbstractTableMigrationService
    {
        string _accessTableName = "COUNTRY";

        public override void MigrateTable()
        {
            //Get Access Data

            OleDbCommand oleCmd = AccessConnection.CreateCommand();
            
            oleCmd.CommandText = "SELECT * FROM COUNTRY";
            
            

            //get current records in SQL
            SqlDataAdapter  sqlAdapter = new SqlDataAdapter("SELECT * FROM COUNTRY", SQLConnection);

            try
            {
                SQLConnection.Open();

                DataSet sqlCountry = new DataSet("Country");
                sqlAdapter.FillSchema(sqlCountry, SchemaType.Source, "COUNTRY");
                sqlAdapter.Fill(sqlCountry);
                DataTable dt = sqlCountry.Tables["COUNTRY"];
                SQLConnection.Close();

                var reader = oleCmd.ExecuteReader();
                while (reader.Read())
                {


                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                SQLConnection.Close();//should we open and close for each database?
            }


            }
    }
}
