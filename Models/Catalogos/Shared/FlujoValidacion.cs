using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PP_NominasBack.Models.Shared
{
    public class FlujoValidacion
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("activo")]
        public bool Activo { get; set; }

        [BsonElement("auditable")]
        public Auditable Auditable { get; set; }

        [BsonElement("descripcionFlujo")]
        public string DescripcionFlujo { get; set; }

        [BsonElement("nombreFlujo")]
        public string NombreFlujo { get; set; }

        [BsonElement("procesoRelacionado")]
        public string ProcesoRelacionado { get; set; }
    }
}
