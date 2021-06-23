using Exame_Rodrigo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Exame_Rodrigo.Data
{
    public class DetailData
    {
        public static int detailDataAdd(EntitySaleDetails values)
        {
            int answer;
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@id", values.id);
            parameters[1] = new SqlParameter("@idonlinesale", values.idOnlineSale);
            parameters[2] = new SqlParameter("@idonlineproduct", values.idProduct);
            parameters[3] = new SqlParameter("@numberofproduct", values.NumberOfProduct);
            parameters[4] = new SqlParameter("@cost", values.Cost);
           





            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "DETAIL_I",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryInt(dataBaseHelperVAlues);
            return answer;
        }
        public static int detailDataDelete(EntitySaleDetails values)
        {
            int answer;
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", values.id);


            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "DETAIL_D",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryInt(dataBaseHelperVAlues);
            return answer;
        }
        public static int detailDataUpdate(EntitySaleDetails values)
        {
            int answer;
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@id", values.id);
            parameters[1] = new SqlParameter("@idonlinesale", values.idOnlineSale);
            parameters[2] = new SqlParameter("@idonlineproduct", values.idProduct);
            parameters[3] = new SqlParameter("@numberofproduct", values.NumberOfProduct);
            parameters[4] = new SqlParameter("@cost", values.Cost);




            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "DETAIL_U",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryInt(dataBaseHelperVAlues);
            return answer;
        }
        public static DataSet detailDataGetOne(EntitySaleDetails values)
        {
            DataSet answer = null;
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", values.id);


            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "DETAIL_GO",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryDatasSet(dataBaseHelperVAlues);
            return answer;
        }
        public static DataSet detailDataGetAll()
        {
            DataSet answer = null;

            SqlParameter[] parameters = new SqlParameter[0];
            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "DETAIL_GA",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryDatasSet(dataBaseHelperVAlues);
            return answer;
        }
    }
}