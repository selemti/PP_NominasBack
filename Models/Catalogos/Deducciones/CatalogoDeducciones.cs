using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Deducciones
{
    public class CatalogoDeducciones
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("tipoDeduccion")]
        public List<int?> TipoDeduccion { get; set; }

        [BsonElement("nombreDeduccion")]
        public List<string> NombreDeduccion { get; set; }

        [BsonElement("descripcionDeduccion")]
        public List<string> DescripcionDeduccion { get; set; }

        [BsonElement("aplicaEmpresaId")]
        public List<string> AplicaEmpresaId { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}