using System.Web.Http;

namespace WinApiTest.EstrategiasMoneda
{
    public class CotizacionContext
    {
        private ITipoCotizacion tipoCotizacion;

        public void SetCotizador(ITipoCotizacion tipoCotizacion)
        {
            this.tipoCotizacion = tipoCotizacion;
        }

        public IHttpActionResult Cotizar()
        {
            return tipoCotizacion.Cotizar();
        }
    }
}