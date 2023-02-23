using System;

namespace ApiPruebaTecnica.Entities
{
    public class Tecnico
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public Double  SueldoBase { get; set; }
    }
}
