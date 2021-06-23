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
    public class ProductsController : ApiController
    {
        public HttpResponseMessage Get()
        {
            HttpResponseMessage answer = null;
            EntityResponse response = new EntityResponse();
            try
            {
                EntityProducts[] myList = null;
                using (DataSet data = ProductData.productDataGetAll())
                {
                    if (data != null)
                    {
                        myList = new EntityProducts[data.Tables[0].Rows.Count];
                        for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                        {
                            EntityProducts values = new EntityProducts();
                            values.id = Convert.ToInt32(data.Tables[0].Rows[i][0]);
                            values.NameProduct = Convert.ToString(data.Tables[0].Rows[i][1]);
                            values.ProductManufactured = Convert.ToString(data.Tables[0].Rows[i][2]);
                            values.Cost = Convert.ToInt32(data.Tables[0].Rows[i][3]);
                            values.Image = Convert.ToString(data.Tables[0].Rows[i][4]);
                            values.Description = Convert.ToString(data.Tables[0].Rows[i][5]);
                            myList[i] = values;
                        }
                    }
                }
                response.Product = myList;
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
                EntityProducts[] myList = null;
                using (DataSet data = ProductData.productDataGetOne(new EntityProducts { id = id }))
                {
                    if (data != null)
                    {
                        myList = new EntityProducts[data.Tables[0].Rows.Count];
                        for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                        {
                            EntityProducts values = new EntityProducts();
                            values.id = Convert.ToInt32(data.Tables[0].Rows[i][0]);
                            values.NameProduct = Convert.ToString(data.Tables[0].Rows[i][1]);
                            values.ProductManufactured = Convert.ToString(data.Tables[0].Rows[i][2]);
                            values.Cost = Convert.ToInt32(data.Tables[0].Rows[i][3]);
                            values.Image = Convert.ToString(data.Tables[0].Rows[i][4]);
                            values.Description = Convert.ToString(data.Tables[0].Rows[i][5]);
                            myList[i] = values;
                        }
                    }
                }
                response.Product = myList;
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
        public HttpResponseMessage Post([FromBody]EntityProducts value)
        {
            HttpResponseMessage answer = null;
            EntityResponse response = new EntityResponse();
            try
            {
                int index = ProductData.productDataAdd(value);
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
        public HttpResponseMessage Put([FromBody]EntityProducts value)
        {
            HttpResponseMessage answer = null;
            EntityResponse response = new EntityResponse();
            try
            {
                int index = ProductData.productDataUpdate(value);

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
                int index = ProductData.productDataDelete(new EntityProducts { id = id });

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
