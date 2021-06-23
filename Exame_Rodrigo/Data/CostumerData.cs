using Exame_Rodrigo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Exame_Rodrigo.Data
{
    public class CostumerData
    {
        public static int costumerDataAdd(EntityCostumers values)
        {
            int answer;
            SqlParameter[] parameters = new SqlParameter[10];
            parameters[0] = new SqlParameter("@id", values.Id);
            parameters[1] = new SqlParameter("@name", values.name);
            parameters[2] = new SqlParameter("@lastname", values.lastname);
            parameters[3] = new SqlParameter("@surname", values.surname);
            parameters[4] = new SqlParameter("@gender", values.gender);
            parameters[5] = new SqlParameter("@dateofbirth", values.DateOfBirth);
            parameters[6] = new SqlParameter("@idmunicipality", values.idMunicipality);
            parameters[7] = new SqlParameter("@email", values.Email);
            parameters[8] = new SqlParameter("@password", values.password);
            parameters[9] = new SqlParameter("@datesystem", values.DateSystem);
            




            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "COSTUMER_I",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryInt(dataBaseHelperVAlues);
            return answer;
        }
        public static int costumerDataDelete(EntityCostumers values)
        {
            int answer;
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", values.Id);


            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "COSTUMER_D",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryInt(dataBaseHelperVAlues);
            return answer;
        }
        public static int costumerDataUpdate(EntityCostumers values)
        {
            int answer;
            SqlParameter[] parameters = new SqlParameter[10];
            parameters[0] = new SqlParameter("@id", values.Id);
            parameters[1] = new SqlParameter("@name", values.name);
            parameters[2] = new SqlParameter("@lastname", values.lastname);
            parameters[3] = new SqlParameter("@surname", values.surname);
            parameters[4] = new SqlParameter("@gender", values.gender);
            parameters[5] = new SqlParameter("@dateofbirth", values.DateOfBirth);
            parameters[6] = new SqlParameter("@idmunicipality", values.idMunicipality);
            parameters[7] = new SqlParameter("@email", values.Email);
            parameters[8] = new SqlParameter("@password", values.password);
            parameters[9] = new SqlParameter("@datesystem", values.DateSystem);




            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "COSTUMER_U",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryInt(dataBaseHelperVAlues);
            return answer;
        }
        public static DataSet costumerDataGetOne(EntityCostumers values)
        {
            DataSet answer = null;
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", values.Id);


            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "COSTUMER_GO",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryDatasSet(dataBaseHelperVAlues);
            return answer;
        }
        public static DataSet costumerDataGetAll()
        {
            DataSet answer = null;

            SqlParameter[] parameters = new SqlParameter[0];
            ParameterDataBaseHelper dataBaseHelperVAlues = new ParameterDataBaseHelper()
            {
                storedProcedureName = "COSTUMER_GA",
                parameters = parameters
            };
            answer = DataBaseHelper.executeQueryDatasSet(dataBaseHelperVAlues);
            return answer;
        }
    }
}