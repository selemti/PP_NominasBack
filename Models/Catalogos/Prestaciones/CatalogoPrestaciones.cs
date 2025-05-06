using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Prestaciones
{
    public class CatalogoPrestaciones
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("nombrePrestacion")]
        public List<string> NombrePrestacion { get; set; }

        [BsonElement("descripcionPrestacion")]
        public List<string> DescripcionPrestacion { get; set; }

        [BsonElement("aplicaEmpresaId")]
        public List<string> AplicaEmpresaId { get; set; }

        [BsonElement("aplicaDivisionId")]
        public List<string> AplicaDivisionId { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}