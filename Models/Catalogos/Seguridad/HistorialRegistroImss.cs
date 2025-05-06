using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Seguridad
{
    public class HistorialRegistroImss
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("empleadoId")]
        public List<string> EmpleadoId { get; set; }

        [BsonElement("nss")]
        public List<string> Nss { get; set; }

        [BsonElement("registroPatronalId")]
        public List<string> RegistroPatronalId { get; set; }

        [BsonElement("fechaAlta")]
        public List<DateTime?> FechaAlta { get; set; }

        [BsonElement("fechaBaja")]
        public List<DateTime?> FechaBaja { get; set; }

    }
}