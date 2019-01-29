using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiCotizaciones.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Web;


namespace WebApiCotizaciones.Controllers
{
    public class CotizacionesController : ApiController
    {

        public CotizacionModel GetCotizacion(string tipo)
        {
            CotizacionModel cotizacion = new CotizacionModel();
            try
            {
                using (var client = new HttpClient())
                {
                    //token maxi: eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJleHAiOjE1ODAxODQ3NjYsInR5cGUiOiJleHRlcm5hbCIsInVzZXIiOiJyb2RyaWd1ZXoubWF4aUB5bWFpbC5jb20ifQ.pDXgYPJxqXyFYBwYt4UW7TBMBCaU3BWT1fNiAnuETasb3opUAlqsMMW8kqNxf-HLVxJvdnvmmMz9-pUUQ6dT7g
                    //token que funciona: eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJleHAiOjE1ODAxODQ5NjIsInR5cGUiOiJleHRlcm5hbCIsInVzZXIiOiJhcmV2YWxvLm1zQGhvdG1haWwuY29tIn0.aO30THJuNzoMSoA2HY90xwMgZbx2l7QIzmxpQQvTJ7A56mxWqxsA9ASmMd02_fQlJ5_smnZ2koUJ6HdVLJDQig
                    var url = "http://api.estadisticasbcra.com/" + tipo;
                    client.DefaultRequestHeaders.Add("Authorization", "BEARER " + "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJleHAiOjE1ODAxODQ5NjIsInR5cGUiOiJleHRlcm5hbCIsInVzZXIiOiJhcmV2YWxvLm1zQGhvdG1haWwuY29tIn0.aO30THJuNzoMSoA2HY90xwMgZbx2l7QIzmxpQQvTJ7A56mxWqxsA9ASmMd02_fQlJ5_smnZ2koUJ6HdVLJDQig");
                    var response = client.GetStringAsync(url).Result;
                    var lista = JsonConvert.DeserializeObject<IList<CotizacionModel>>(response);
                    cotizacion = lista.Last();
                }

                return cotizacion;
            }
            catch (Exception ex)
            {
                cotizacion.d = string.Empty;
                cotizacion.v = string.Empty;
                return cotizacion;
            }

        }
    }
}
