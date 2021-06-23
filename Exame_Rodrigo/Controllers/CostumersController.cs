using Exame_Rodrigo.Data;
using Exame_Rodrigo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Exame_Rodrigo.Controllers
{
    public class CostumersController : ApiController
    {
        public HttpResponseMessage Get()
        {
            HttpResponseMessage answer = null;
            EntityResponse response = new EntityResponse();
            try
            {
                EntityCostumers[] myList = null;
                using (DataSet data = CostumerData.costumerDataGetAll())
                {
                    if (data != null)
                    {
                        myList = new EntityCostumers[data.Tables[0].Rows.Count];
                        for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                        {
                            EntityCostumers values = new EntityCostumers();
                            values.Id = Convert.ToInt32(data.Tables[0].Rows[i][0]);
                            values.name = Convert.ToString(data.Tables[0].Rows[i][1]);
                            values.lastname = Convert.ToString(data.Tables[0].Rows[i][2]);
                            values.surname = Convert.ToString(data.Tables[0].Rows[i][3]);
                            values.gender = Convert.ToInt32(data.Tables[0].Rows[i][4]);
                            values.DateOfBirth = Convert.ToDateTime(data.Tables[0].Rows[i][5]);
                            values.idMunicipality = Convert.ToInt32(data.Tables[0].Rows[i][6]);
                            values.Email = Convert.ToString(data.Tables[0].Rows[i][7]);
                            values.password = Convert.ToString(data.Tables[0].Rows[i][8]);
                            values.DateSystem = Convert.ToDateTime(data.Tables[0].Rows[i][9]);
                            myList[i] = values;
                        }
                    }
                }
                response.costumer = myList;
                answer = Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                response.message = ex.ToString();
                answer = Request.CreateResponse(HttpStatusCode.InternalServerError, response);
            }
            return answer;
        }

        // GET: api/GeoData/5
        public HttpResponseMessage Get(int id)
        {
            HttpResponseMessage answer = null;
            EntityResponse response = new EntityResponse();
            try
            {
                EntityCostumers[] myList = null;
                using (DataSet data = CostumerData.costumerDataGetOne(new EntityCostumers { Id = id }))
                {
                    if (data != null)
                    {
                        myList = new EntityCostumers[data.Tables[0].Rows.Count];
                        for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                        {
                            EntityCostumers values = new EntityCostumers();
                            values.Id = Convert.ToInt32(data.Tables[0].Rows[i][0]);
                            values.name = Convert.ToString(data.Tables[0].Rows[i][1]);
                            values.lastname = Convert.ToString(data.Tables[0].Rows[i][2]);
                            values.surname = Convert.ToString(data.Tables[0].Rows[i][3]);
                            values.gender = Convert.ToInt32(data.Tables[0].Rows[i][4]);
                            values.DateOfBirth = Convert.ToDateTime(data.Tables[0].Rows[i][5]);
                            values.idMunicipality = Convert.ToInt32(data.Tables[0].Rows[i][6]);
                            values.Email = Convert.ToString(data.Tables[0].Rows[i][7]);
                            values.password = Convert.ToString(data.Tables[0].Rows[i][8]);
                            values.DateSystem = Convert.ToDateTime(data.Tables[0].Rows[i][9]);
                            myList[i] = values;
                        }
                    }
                }
                response.costumer = myList;
                answer = Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                response.message = ex.ToString();
                answer = Request.CreateResponse(HttpStatusCode.InternalServerError, response);
            }
            return answer;
        }

        // POST: api/Ejemplo
        public HttpResponseMessage Post([FromBody]EntityCostumers value)
        {
            HttpResponseMessage answer = null;
            EntityResponse response = new EntityResponse();
            try
            {
                int index = CostumerData.costumerDataAdd(value);
                answer = Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                response.message = ex.ToString();
                answer = Request.CreateResponse(HttpStatusCode.InternalServerError, response);
            }
            return answer;
        }

        // PUT: api/GeoData/5
        public HttpResponseMessage Put([FromBody]EntityCostumers value)
        {
            HttpResponseMessage answer = null;
            EntityResponse response = new EntityResponse();
            try
            {
                int index = CostumerData.costumerDataUpdate(value);

                if (index > 0)
                {
                    response.message = index.ToString();
                    answer = Request.CreateResponse(HttpStatusCode.OK, response);
                }
                else
                {
                    response.message = "no se pudo eliminar el registro en la base de datos";
                    answer = Request.CreateResponse(HttpStatusCode.NotAcceptable, response);
                }
            }
            catch (Exception ex)
            {
                response.message = ex.ToString();
                answer = Request.CreateResponse(HttpStatusCode.InternalServerError, response);
            }
            return answer;
        }

        // DELETE: api/GeoData/5
        public HttpResponseMessage Delete(int id)
        {
            HttpResponseMessage answer = null;
            EntityResponse response = new EntityResponse();
            try
            {
                int index = CostumerData.costumerDataDelete(new EntityCostumers { Id = id });

                if (index > 0)
                {
                    response.message = index.ToString();
                    answer = Request.CreateResponse(HttpStatusCode.OK, response);
                }
                else
                {
                    response.message = "no se pudo eliminar el registro en la base de datos";
                    answer = Request.CreateResponse(HttpStatusCode.NotAcceptable, response);
                }
            }
            catch (Exception ex)
            {
                response.message = ex.ToString();
                answer = Request.CreateResponse(HttpStatusCode.InternalServerError, response);
            }
            return answer;
        }
    }
}
