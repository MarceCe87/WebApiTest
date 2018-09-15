using MyRestfullApp.EstrategiasMoneda;
using System;
using System.Web.Http;

namespace MyRestfullApp.Controllers
{
    public class CotizacionController : ApiController
    {
        [Route("MyRestfullApp/Cotizacion/{moneda}")]
        [HttpGet()]
        public IHttpActionResult GetCotizacion(string moneda)
        {
            CotizacionContext cn = new CotizacionContext();

            if (moneda.Equals("Dolar", StringComparison.InvariantCultureIgnoreCase))
            {
                cn.SetCotizador(new CotizacionDolarService());
            }
            else if (moneda.Equals("Peso", StringComparison.InvariantCultureIgnoreCase))
            {
                cn.SetCotizador(new CotizacionPesoService());
            }
            else if (moneda.Equals("Real", StringComparison.InvariantCultureIgnoreCase))
            {
                cn.SetCotizador(new CotizacionRealService());
            }
            else
            {
                cn.SetCotizador(new CotizacionOtraService());
            }

            return cn.Cotizar();
        }
    }
}
