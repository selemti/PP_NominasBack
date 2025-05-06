using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Organizacion
{
    public class Division
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("grupoEmpresaId")]
        public List<string> GrupoEmpresaId { get; set; }

        [BsonElement("claveDivision")]
        public List<string> ClaveDivision { get; set; }

        [BsonElement("nombreDivision")]
        public List<string> NombreDivision { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}