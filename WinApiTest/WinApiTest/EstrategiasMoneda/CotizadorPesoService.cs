using System.Net.Http;
using System.Web.Http;

namespace WinApiTest.EstrategiasMoneda
{
    public class CotizadorPesoService : ApiController, ITipoCotizacion
    {
        public IHttpActionResult Cotizar()
        {
            this.Configuration = new HttpConfiguration();
            this.Request = new HttpRequestMessage();
            return Unauthorized();
        }
    }
}