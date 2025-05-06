using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Incidencias
{
    public class PreNominaIncidencia
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("empleadoId")]
        public List<string> EmpleadoId { get; set; }

        [BsonElement("periodoNominaId")]
        public List<string> PeriodoNominaId { get; set; }

        [BsonElement("tipoIncidenciaId")]
        public List<string> TipoIncidenciaId { get; set; }

        [BsonElement("fecha")]
        public List<DateTime?> Fecha { get; set; }

        [BsonElement("duracion")]
        public List<decimal?> Duracion { get; set; }

        [BsonElement("justificanteAdjunto")]
        public List<string> JustificanteAdjunto { get; set; }

        [BsonElement("estatus")]
        public List<string> Estatus { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}