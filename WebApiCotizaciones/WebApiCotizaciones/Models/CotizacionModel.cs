using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiCotizaciones.Models
{
    
    public class CotizacionModel
    {
        //fecha devuelta por el json 
        public string d { get; set; } 

        //valor(ej: merval, usd, tasa, uva, etc.) devuelto por json
        public string v { get; set; }
    }
}