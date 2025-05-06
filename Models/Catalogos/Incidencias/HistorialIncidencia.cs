using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Incidencias
{
    public class HistorialIncidencia
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("incidenciaId")]
        public List<string> IncidenciaId { get; set; }

        [BsonElement("fechaCambio")]
        public List<DateTime?> FechaCambio { get; set; }

        [BsonElement("descripcionCambio")]
        public List<string> DescripcionCambio { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}