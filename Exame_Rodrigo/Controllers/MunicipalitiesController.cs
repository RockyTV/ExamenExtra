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
    public class MunicipalitiesController : ApiController
    {
        public HttpResponseMessage Get()
        {
            HttpResponseMessage answer = null;
            EntityResponse response = new EntityResponse();
            try
            {
                EntityMunicipalities[] myList = null;
                using (DataSet data = MunicipalityData.municipalityDataGetAll())
                {
                    if (data != null)
                    {
                        myList = new EntityMunicipalities[data.Tables[0].Rows.Count];
                        for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                        {
                            EntityMunicipalities values = new EntityMunicipalities();
                            values.Id = Convert.ToInt32(data.Tables[0].Rows[i][0]);
                            values.IdState = Convert.ToInt32(data.Tables[0].Rows[i][1]);
                            values.MunicipalityName = Convert.ToString(data.Tables[0].Rows[i][2]);
                            values.IsMetropolitanArea = Convert.ToInt32(data.Tables[0].Rows[i][3]);
                            myList[i] = values;
                        }
                    }
                }
                response.municipality = myList;
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
                EntityMunicipalities[] myList = null;
                using (DataSet data = MunicipalityData.municipalityDataGetOne(new EntityMunicipalities { Id = id }))
                {
                    if (data != null)
                    {
                        myList = new EntityMunicipalities[data.Tables[0].Rows.Count];
                        for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                        {
                            EntityMunicipalities values = new EntityMunicipalities();
                            values.Id = Convert.ToInt32(data.Tables[0].Rows[i][0]);
                            values.IdState = Convert.ToInt32(data.Tables[0].Rows[i][1]);
                            values.MunicipalityName = Convert.ToString(data.Tables[0].Rows[i][2]);
                            values.IsMetropolitanArea = Convert.ToInt32(data.Tables[0].Rows[i][3]);
                            myList[i] = values;
                        }
                    }
                }
                response.municipality = myList;
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
        public HttpResponseMessage Post([FromBody]EntityMunicipalities value)
        {
            HttpResponseMessage answer = null;
            EntityResponse response = new EntityResponse();
            try
            {
                int index = MunicipalityData.municipalityDataAdd(value);
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
        public HttpResponseMessage Put([FromBody]EntityMunicipalities value)
        {
            HttpResponseMessage answer = null;
            EntityResponse response = new EntityResponse();
            try
            {
                int index = MunicipalityData.municipalityDataUpdate(value);

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
                int index = MunicipalityData.municipalityDataDelete(new EntityMunicipalities { Id = id });

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
