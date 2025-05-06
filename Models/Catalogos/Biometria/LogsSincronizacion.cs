using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Biometria
{
    public class LogsSincronizacion
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("dispositivoId")]
        public List<string> DispositivoId { get; set; }

        [BsonElement("fechaEvento")]
        public List<DateTime?> FechaEvento { get; set; }

        [BsonElement("descripcionLog")]
        public List<string> DescripcionLog { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}