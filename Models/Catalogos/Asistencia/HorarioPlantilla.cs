using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    public class HorarioPlantilla
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("nombrePlantilla")]
        public List<string> NombrePlantilla { get; set; }

        [BsonElement("descripcionPlantilla")]
        public List<string> DescripcionPlantilla { get; set; }

        [BsonElement("turnoId")]
        public List<string> TurnoId { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}