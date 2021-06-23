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
    public class DetailController : ApiController
    {
        public HttpResponseMessage Get()
        {
            HttpResponseMessage answer = null;
            EntityResponse response = new EntityResponse();
            try
            {
                EntitySaleDetails[] myList = null;
                using (DataSet data = DetailData.detailDataGetAll())
                {
                    if (data != null)
                    {
                        myList = new EntitySaleDetails[data.Tables[0].Rows.Count];
                        for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                        {
                            EntitySaleDetails values = new EntitySaleDetails();
                            values.id = Convert.ToInt32(data.Tables[0].Rows[i][0]);
                            values.idOnlineSale = Convert.ToInt32(data.Tables[0].Rows[i][1]);
                            values.idProduct = Convert.ToInt32(data.Tables[0].Rows[i][2]);
                            values.NumberOfProduct = Convert.ToInt32(data.Tables[0].Rows[i][3]);
                            values.Cost = Convert.ToInt32(data.Tables[0].Rows[i][4]);
                            myList[i] = values;
                        }
                    }
                }
                response.Detail = myList;
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
                EntitySaleDetails[] myList = null;
                using (DataSet data = DetailData.detailDataGetOne(new EntitySaleDetails { id = id }))
                {
                    if (data != null)
                    {
                        myList = new EntitySaleDetails[data.Tables[0].Rows.Count];
                        for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                        {
                            EntitySaleDetails values = new EntitySaleDetails();
                            values.id = Convert.ToInt32(data.Tables[0].Rows[i][0]);
                            values.idOnlineSale = Convert.ToInt32(data.Tables[0].Rows[i][1]);
                            values.idProduct = Convert.ToInt32(data.Tables[0].Rows[i][2]);
                            values.NumberOfProduct = Convert.ToInt32(data.Tables[0].Rows[i][3]);
                            values.Cost = Convert.ToInt32(data.Tables[0].Rows[i][4]);
                            myList[i] = values;
                        }
                    }
                }
                response.Detail = myList;
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
        public HttpResponseMessage Post([FromBody]EntitySaleDetails value)
        {
            HttpResponseMessage answer = null;
            EntityResponse response = new EntityResponse();
            try
            {
                int index = DetailData.detailDataAdd(value);
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
        public HttpResponseMessage Put([FromBody]EntitySaleDetails value)
        {
            HttpResponseMessage answer = null;
            EntityResponse response = new EntityResponse();
            try
            {
                int index = DetailData.detailDataUpdate(value);

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
                int index = DetailData.detailDataDelete(new EntitySaleDetails { id = id });

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
