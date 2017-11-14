using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationConsumindoWebService
{
    public class Instituicao
    {
        public int idInstituicao { get; set; }
        public string nomeInstituicao { get; set; }
        public string enderecoInstituicao { get; set; }
        public string cidadeInstituicao { get; set; }
        public string estadoInstituicao { get; set; }
        public string cepInstituicao { get; set; }
        public string telefoneInstituicao { get; set; }
        public int idStatusInstituicao { get; set; }
    }
}