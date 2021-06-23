using Exame_Rodrigo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Exame_Rodrigo.Data
{
    public class ProductData
    {
        public static int productDataAdd(EntityProducts values)
        {
            int answer;
            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("@id", values.id);
            parameters[1] = new SqlParameter("@productname", values.NameProduct);
            parameters[2] = new SqlParameter("@productmanufactured", values.ProductManufactured);
            parameters[3] = new SqlParameter("@cost", values.Cost);
            parameters[4] = new SqlParameter("@image", values.Image);
            parameters[5] = new SqlParameter("@description", values.Description);
            





            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "PRODUCT_I",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryInt(dataBaseHelperVAlues);
            return answer;
        }
        public static int productDataDelete(EntityProducts values)
        {
            int answer;
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", values.id);


            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "PRODUCT_D",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryInt(dataBaseHelperVAlues);
            return answer;
        }
        public static int productDataUpdate(EntityProducts values)
        {
            int answer;
            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("@id", values.id);
            parameters[1] = new SqlParameter("@productname", values.NameProduct);
            parameters[2] = new SqlParameter("@productmanufactured", values.ProductManufactured);
            parameters[3] = new SqlParameter("@cost", values.Cost);
            parameters[4] = new SqlParameter("@image", values.Image);
            parameters[5] = new SqlParameter("@description", values.Description);




            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "PRODUCT_U",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryInt(dataBaseHelperVAlues);
            return answer;
        }
        public static DataSet productDataGetOne(EntityProducts values)
        {
            DataSet answer = null;
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", values.id);


            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "PRODUCT_GO",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryDatasSet(dataBaseHelperVAlues);
            return answer;
        }
        public static DataSet productDataGetAll()
        {
            DataSet answer = null;

            SqlParameter[] parameters = new SqlParameter[0];
            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "PRODUCT_GA",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryDatasSet(dataBaseHelperVAlues);
            return answer;
        }
    }
}