using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    public class Incidencia
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("tipoFalta")]
        public List<int?> TipoFalta { get; set; }

        [BsonElement("checadaId")]
        public string ChecadaId { get; set; }

        [BsonElement("estatusIncidencia")]
        public string EstatusIncidencia { get; set; }

        [BsonElement("duracionRetardo")]
        public double? DuracionRetardo { get; set; }

        [BsonElement("justificacion")]
        public string Justificacion { get; set; }

        [BsonElement("tipoPermiso")]
        public string TipoPermiso { get; set; }

    }
}