using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    public class Checada
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("empleadoId")]
        public List<string> EmpleadoId { get; set; }

        [BsonElement("fechaHora")]
        public List<DateTime?> FechaHora { get; set; }

        [BsonElement("tipoEvento")]
        public List<int?> TipoEvento { get; set; }

        [BsonElement("dispositivoId")]
        public List<string> DispositivoId { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

        [BsonElement("horasTrabajadas")]
        public List<double?> HorasTrabajadas { get; set; }

    }
}