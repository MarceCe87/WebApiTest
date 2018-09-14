using System.IO;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WinApiTest.EstrategiasMoneda
{
    public class CotizadorDolarService : ApiController, ITipoCotizacion
    {
        public IHttpActionResult Cotizar()
        {
            this.Configuration = new HttpConfiguration();
            this.Request = new HttpRequestMessage();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.bancoprovincia.com.ar/Principal/Dolar");

            var response = request.GetResponse();
            var respuesta = string.Empty;

            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                respuesta = sr.ReadToEnd();

            return Ok(respuesta);
        }
    }
}