using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    public class PlantillaMensual
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("mes")]
        public List<int?> Mes { get; set; }

        [BsonElement("aO")]
        public List<int?> AO { get; set; }

        [BsonElement("horarioPlantillaId")]
        public List<string> HorarioPlantillaId { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}