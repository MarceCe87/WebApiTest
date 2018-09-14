using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace WinApiTest.EstrategiasMoneda
{
    public class CotizadorOtraService : ApiController, ITipoCotizacion
    { 
        public IHttpActionResult Cotizar()
        {
            this.Configuration = new HttpConfiguration();
            this.Request = new HttpRequestMessage();
            this.Configuration = new HttpConfiguration();
            return Ok("Moneda sin cotizacion");
        }
    }
}