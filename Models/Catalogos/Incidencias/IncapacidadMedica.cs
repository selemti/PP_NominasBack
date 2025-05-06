using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Incidencias
{
    public class IncapacidadMedica
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("empleadoId")]
        public List<string> EmpleadoId { get; set; }

        [BsonElement("tipoIncapacidad")]
        public List<int?> TipoIncapacidad { get; set; }

        [BsonElement("diasIncapacidad")]
        public List<int?> DiasIncapacidad { get; set; }

        [BsonElement("folioImss")]
        public List<string> FolioImss { get; set; }

        [BsonElement("fechaInicio")]
        public List<DateTime?> FechaInicio { get; set; }

        [BsonElement("fechaFin")]
        public List<DateTime?> FechaFin { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}