using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Biometria
{
    public class TipoEventoBiometrico
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("nombreEvento")]
        public List<string> NombreEvento { get; set; }

        [BsonElement("descripcionEvento")]
        public List<string> DescripcionEvento { get; set; }

        [BsonElement("activo")]
        public List<bool?> Activo { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}