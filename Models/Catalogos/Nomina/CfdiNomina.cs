using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Nomina
{
    public class CfdiNomina
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("reciboNominaId")]
        public List<string> ReciboNominaId { get; set; }

        [BsonElement("uuid")]
        public List<string> Uuid { get; set; }

        [BsonElement("selloDigital")]
        public List<string> SelloDigital { get; set; }

        [BsonElement("fechaTimbre")]
        public List<DateTime?> FechaTimbre { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}