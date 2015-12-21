using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;

namespace DataAccess
{
    public class DataController
    {


        /// <summary> 
        /// Define Sql Config with EnterpriseLibrary V6.
        /// </summary> 

        public static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        Database db = factory.Create("DefaultConnection");

        /// <summary> 
        /// Select statement by parameter.
        /// </summary> 

        public DataSet SelectByParameter(string value)
        {
            try
            {
                DbCommand cmd = db.GetStoredProcCommand("Currency_SelectByCurrencyID");
                db.AddInParameter(cmd, "CurrencyID", DbType.String, value);
                DataSet ds = db.ExecuteDataSet(cmd);
                return ds;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

    }
}
