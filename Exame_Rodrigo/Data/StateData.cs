using Exame_Rodrigo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Exame_Rodrigo.Data
{
    public class StateData
    {
        public static int stateDataAdd(EntityState values)
        {
            int answer;
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@id", values.Id);
            parameters[1] = new SqlParameter("@statename", values.StateName);
            


            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "STATE_I",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryInt(dataBaseHelperVAlues);
            return answer;
        }
        public static int stateDataDelete(EntityState values)
        {
            int answer;
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", values.Id);


            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "STATE_D",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryInt(dataBaseHelperVAlues);
            return answer;
        }
        public static int stateDataUpdate(EntityState values)
        {
            int answer;
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@id", values.Id);
            parameters[1] = new SqlParameter("@statename", values.StateName);
           



            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "STATE_U",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryInt(dataBaseHelperVAlues);
            return answer;
        }
        public static DataSet stateDataGetOne(EntityState values)
        {
            DataSet answer = null;
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", values.Id);


            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "STATE_GO",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryDatasSet(dataBaseHelperVAlues);
            return answer;
        }
        public static DataSet stateDataGetAll()
        {
            DataSet answer = null;

            SqlParameter[] parameters = new SqlParameter[0];
            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "STATE_GA",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryDatasSet(dataBaseHelperVAlues);
            return answer;
        }
    }
}