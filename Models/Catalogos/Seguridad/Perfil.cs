using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Seguridad
{
    public class Perfil
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("nombrePerfil")]
        public List<string> NombrePerfil { get; set; }

        [BsonElement("descripcionPerfil")]
        public List<string> DescripcionPerfil { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}