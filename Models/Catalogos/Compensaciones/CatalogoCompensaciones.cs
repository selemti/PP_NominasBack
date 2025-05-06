using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Compensaciones
{
    public class CatalogoCompensaciones
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("tipoCompensacion")]
        public List<int?> TipoCompensacion { get; set; }

        [BsonElement("nombreCompensacion")]
        public List<string> NombreCompensacion { get; set; }

        [BsonElement("descripcionCompensacion")]
        public List<string> DescripcionCompensacion { get; set; }

        [BsonElement("aplicaEmpresaId")]
        public List<string> AplicaEmpresaId { get; set; }

        [BsonElement("aplicaDivisionId")]
        public List<string> AplicaDivisionId { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}