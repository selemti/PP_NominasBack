using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Seguridad
{
    public class RegistroPatronal
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("nombre")]
        public List<string> Nombre { get; set; }

        [BsonElement("rfc")]
        public List<string> Rfc { get; set; }

        [BsonElement("numeroRegistro")]
        public List<string> NumeroRegistro { get; set; }

        [BsonElement("subdelegacion")]
        public List<string> Subdelegacion { get; set; }

    }
}