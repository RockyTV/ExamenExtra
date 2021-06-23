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
    public class StatesController : ApiController
    {
        // GET: api/States
        public HttpResponseMessage Get()
        {
            HttpResponseMessage answer = null;
            EntityResponse response = new EntityResponse();
            try
            {
                EntityState[] myList = null;
                using (DataSet data = StateData.stateDataGetAll())
                {
                    if (data != null)
                    {
                        myList = new EntityState[data.Tables[0].Rows.Count];
                        for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                        {
                            EntityState values = new EntityState();
                            values.Id = Convert.ToInt32(data.Tables[0].Rows[i][0]);
                            values.StateName = Convert.ToString(data.Tables[0].Rows[i][1]);
                            myList[i] = values;
                        }
                    }
                }
                response.state = myList;
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
                EntityState[] myList = null;
                using (DataSet data = StateData.stateDataGetOne(new EntityState { Id = id }))
                {
                    if (data != null)
                    {
                        myList = new EntityState[data.Tables[0].Rows.Count];
                        for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                        {
                            EntityState values = new EntityState();
                            values.Id = Convert.ToInt32(data.Tables[0].Rows[i][0]);
                            values.StateName = Convert.ToString(data.Tables[0].Rows[i][1]);
                            myList[i] = values;
                        }
                    }
                }
                response.state = myList;
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
        public HttpResponseMessage Post([FromBody]EntityState value)
        {
            HttpResponseMessage answer = null;
            EntityResponse response = new EntityResponse();
            try
            {
                int index = StateData.stateDataAdd(value);
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
        public HttpResponseMessage Put([FromBody]EntityState value)
        {
            HttpResponseMessage answer = null;
            EntityResponse response = new EntityResponse();
            try
            {
                int index = StateData.stateDataUpdate(value);

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
                int index = StateData.stateDataDelete(new EntityState { Id = id });

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
