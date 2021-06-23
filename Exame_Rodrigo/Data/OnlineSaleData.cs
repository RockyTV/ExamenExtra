using Exame_Rodrigo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Exame_Rodrigo.Data
{
    public class OnlineSaleData
    {
        public static int onlinesaleDataAdd(EntityOnlineSales values)
        {
            int answer;
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@id", values.Id);
            parameters[1] = new SqlParameter("@idcostumer", values.IdCostumer);
            parameters[2] = new SqlParameter("@datesystem", values.DateSystem);
            parameters[3] = new SqlParameter("@status", values.Status);
            





            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "ONLINE_SALE_I",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryInt(dataBaseHelperVAlues);
            return answer;
        }
        public static int onlinesaleDataDelete(EntityOnlineSales values)
        {
            int answer;
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", values.Id);


            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "ONLINE_SALE_D",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryInt(dataBaseHelperVAlues);
            return answer;
        }
        public static int onlinesaleDataUpdate(EntityOnlineSales values)
        {
            int answer;
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@id", values.Id);
            parameters[1] = new SqlParameter("@idcostumer", values.IdCostumer);
            parameters[2] = new SqlParameter("@datesystem", values.DateSystem);
            parameters[3] = new SqlParameter("@status", values.Status);




            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "ONLINE_SALE_U",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryInt(dataBaseHelperVAlues);
            return answer;
        }
        public static DataSet onlinesaleDataGetOne(EntityOnlineSales values)
        {
            DataSet answer = null;
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", values.Id);


            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "ONLINE_SALE_GO",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryDatasSet(dataBaseHelperVAlues);
            return answer;
        }
        public static DataSet onlinesaleDataGetAll()
        {
            DataSet answer = null;

            SqlParameter[] parameters = new SqlParameter[0];
            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "ONLINE_SALE_GA",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryDatasSet(dataBaseHelperVAlues);
            return answer;
        }
    }
}