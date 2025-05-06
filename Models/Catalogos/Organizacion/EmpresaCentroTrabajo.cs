using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Organizacion
{
    public class EmpresaCentroTrabajo
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("grupoEmpresaId")]
        public List<string> GrupoEmpresaId { get; set; }

        [BsonElement("centroTrabajoId")]
        public List<string> CentroTrabajoId { get; set; }

        [BsonElement("vigente")]
        public List<bool?> Vigente { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}