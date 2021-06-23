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
    public class OnlineSalesController : ApiController
    {
        public HttpResponseMessage Get()
        {
            HttpResponseMessage answer = null;
            EntityResponse response = new EntityResponse();
            try
            {
                EntityOnlineSales[] myList = null;
                using (DataSet data = OnlineSaleData.onlinesaleDataGetAll())
                {
                    if (data != null)
                    {
                        myList = new EntityOnlineSales[data.Tables[0].Rows.Count];
                        for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                        {
                            EntityOnlineSales values = new EntityOnlineSales();
                            values.Id = Convert.ToInt32(data.Tables[0].Rows[i][0]);
                            values.IdCostumer = Convert.ToInt32(data.Tables[0].Rows[i][1]);
                            values.DateSystem = Convert.ToDateTime(data.Tables[0].Rows[i][2]);
                            values.Status = Convert.ToString(data.Tables[0].Rows[i][3]);
                            
                            myList[i] = values;
                        }
                    }
                }
                response.Sale = myList;
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
                EntityOnlineSales[] myList = null;
                using (DataSet data = OnlineSaleData.onlinesaleDataGetOne(new EntityOnlineSales { Id = id }))
                {
                    if (data != null)
                    {
                        myList = new EntityOnlineSales[data.Tables[0].Rows.Count];
                        for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                        {
                            EntityOnlineSales values = new EntityOnlineSales();
                            values.Id = Convert.ToInt32(data.Tables[0].Rows[i][0]);
                            values.IdCostumer = Convert.ToInt32(data.Tables[0].Rows[i][1]);
                            values.DateSystem = Convert.ToDateTime(data.Tables[0].Rows[i][2]);
                            values.Status = Convert.ToString(data.Tables[0].Rows[i][3]);

                            myList[i] = values;
                        }
                    }
                }
                response.Sale = myList;
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
        public HttpResponseMessage Post([FromBody]EntityOnlineSales value)
        {
            HttpResponseMessage answer = null;
            EntityResponse response = new EntityResponse();
            try
            {
                int index = OnlineSaleData.onlinesaleDataAdd(value);
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
        public HttpResponseMessage Put([FromBody]EntityOnlineSales value)
        {
            HttpResponseMessage answer = null;
            EntityResponse response = new EntityResponse();
            try
            {
                int index = OnlineSaleData.onlinesaleDataUpdate(value);

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
                int index = OnlineSaleData.onlinesaleDataDelete(new EntityOnlineSales { Id = id });

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
