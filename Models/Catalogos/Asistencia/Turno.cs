using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    public class Turno
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("nombreTurno")]
        public List<string> NombreTurno { get; set; }

        [BsonElement("horaEntrada")]
        public List<string> HoraEntrada { get; set; }

        [BsonElement("horaSalida")]
        public List<string> HoraSalida { get; set; }

        [BsonElement("tipoTurno")]
        public List<int?> TipoTurno { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}