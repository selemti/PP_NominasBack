using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Organizacion
{
    public class Departamento
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("claveDepartamento")]
        public List<string> ClaveDepartamento { get; set; }

        [BsonElement("nombreDepartamento")]
        public List<string> NombreDepartamento { get; set; }

        [BsonElement("divisionId")]
        public List<string> DivisionId { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}