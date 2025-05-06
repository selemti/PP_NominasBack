using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    public class ChecadaRemota
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public string Id { get; set; }

        [BsonElement("empleadoId")]
        public string EmpleadoId { get; set; }

        [BsonElement("fechaHora")]
        public DateTime FechaHora { get; set; }

        [BsonElement("tipoEvento")]
        public int TipoEvento { get; set; }

        [BsonElement("latitud")]
        public decimal Latitud { get; set; }

        [BsonElement("longitud")]
        public decimal Longitud { get; set; }

        [BsonElement("ubicacionId")]
        public string UbicacionId { get; set; }

        [BsonElement("fotoAdjunta")]
        public string FotoAdjunta { get; set; }

        [BsonElement("auditable")]
        public string Auditable { get; set; }

    }
}