using Exame_Rodrigo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Exame_Rodrigo.Data
{
    public class MunicipalityData
    {
        public static int municipalityDataAdd(EntityMunicipalities values)
        {
            int answer;
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@id", values.Id);
            parameters[1] = new SqlParameter("@idstate", values.IdState);
            parameters[2] = new SqlParameter("@municipalityname", values.MunicipalityName);
            parameters[3] = new SqlParameter("@ismetropolitanarea", values.IsMetropolitanArea);




            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "MUNICIPALITY_I",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryInt(dataBaseHelperVAlues);
            return answer;
        }
        public static int municipalityDataDelete(EntityMunicipalities values)
        {
            int answer;
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", values.Id);


            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "MUNICIPALITY_D",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryInt(dataBaseHelperVAlues);
            return answer;
        }
        public static int municipalityDataUpdate(EntityMunicipalities values)
        {
            int answer;
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@id", values.Id);
            parameters[1] = new SqlParameter("@idstate", values.IdState);
            parameters[2] = new SqlParameter("@municipalityname", values.MunicipalityName);
            parameters[3] = new SqlParameter("@ismetropolitanarea", values.IsMetropolitanArea);




            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "MUNICIPALITY_U",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryInt(dataBaseHelperVAlues);
            return answer;
        }
        public static DataSet municipalityDataGetOne(EntityMunicipalities values)
        {
            DataSet answer = null;
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", values.Id);


            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "MUNICIPALITY_GO",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryDatasSet(dataBaseHelperVAlues);
            return answer;
        }
        public static DataSet municipalityDataGetAll()
        {
            DataSet answer = null;

            SqlParameter[] parameters = new SqlParameter[0];
            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "MUNICIPALITY_GA",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryDatasSet(dataBaseHelperVAlues);
            return answer;
        }
    }
}