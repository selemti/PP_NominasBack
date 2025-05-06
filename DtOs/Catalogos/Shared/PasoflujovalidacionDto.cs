using MongoDB.Bson;

namespace PP_Nominas.Models.Shared
{
    public class PasoFlujoValidacionDto
    {
        public ObjectId Id { get; set; }
        public Auditable Auditable { get; set; }
        public bool AutorizacionNecesaria { get; set; }
        public ObjectId FlujoValidacionId { get; set; }
        public bool NotificarEnEstePaso { get; set; }
        public int OrdenPaso { get; set; }
        public ObjectId ResponsableId { get; set; }
        public int TipoResponsable { get; set; }
    }
}
