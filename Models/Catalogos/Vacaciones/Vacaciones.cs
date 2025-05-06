using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Vacaciones
{
    public class Vacaciones
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("empleadoId")]
        public List<string> EmpleadoId { get; set; }

        [BsonElement("fechaInicio")]
        public List<DateTime?> FechaInicio { get; set; }

        [BsonElement("fechaFin")]
        public List<DateTime?> FechaFin { get; set; }

        [BsonElement("diasProgramados")]
        public List<int?> DiasProgramados { get; set; }

        [BsonElement("diasGozados")]
        public List<int?> DiasGozados { get; set; }

        [BsonElement("periodoVacacionalId")]
        public List<string> PeriodoVacacionalId { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}