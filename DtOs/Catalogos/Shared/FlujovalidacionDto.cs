using MongoDB.Bson;

namespace PP_Nominas.Models.Shared
{
    public class FlujoValidacionDto
    {
        public ObjectId Id { get; set; }
        public bool Activo { get; set; }
        public Auditable Auditable { get; set; }
        public string DescripcionFlujo { get; set; }
        public string NombreFlujo { get; set; }
        public string ProcesoRelacionado { get; set; }
    }
}
