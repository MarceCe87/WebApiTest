using System.Net.Http;
using System.Web.Http;

namespace MyRestfullApp.EstrategiasMoneda
{
    public class CotizacionPesoService : ApiController, ITipoCotizacion
    {
        public IHttpActionResult Cotizar()
        {
            this.Configuration = new HttpConfiguration();
            this.Request = new HttpRequestMessage();
            return Unauthorized();
        }
    }
}