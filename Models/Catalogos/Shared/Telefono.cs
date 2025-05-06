using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Shared
{
    public class Telefono
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("tipoEntidad")]
        public List<string> TipoEntidad { get; set; }

        [BsonElement("entidadId")]
        public List<string> EntidadId { get; set; }

        [BsonElement("clavePais")]
        public List<string> ClavePais { get; set; }

        [BsonElement("numeroTelefonico")]
        public List<string> NumeroTelefonico { get; set; }

        [BsonElement("extension")]
        public List<string> Extension { get; set; }

        [BsonElement("tipoTelefono")]
        public List<int?> TipoTelefono { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}