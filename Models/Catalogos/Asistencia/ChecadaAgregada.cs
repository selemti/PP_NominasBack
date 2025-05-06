using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    public class ChecadaAgregada
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public string Id { get; set; }

        [BsonElement("empleadoId")]
        public string EmpleadoId { get; set; }

        [BsonElement("fecha")]
        public DateTime Fecha { get; set; }

        [BsonElement("horaEntrada")]
        public string HoraEntrada { get; set; }

        [BsonElement("horaSalida")]
        public string HoraSalida { get; set; }

        [BsonElement("observaciones")]
        public string Observaciones { get; set; }

        [BsonElement("auditable")]
        public string Auditable { get; set; }

    }
}