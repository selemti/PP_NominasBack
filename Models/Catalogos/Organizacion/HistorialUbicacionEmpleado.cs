using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Organización
{
    public class HistorialUbicacionEmpleado
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("empleadoId")]
        public List<string> EmpleadoId { get; set; }

        [BsonElement("ubicacionId")]
        public List<string> UbicacionId { get; set; }

        [BsonElement("fechaInicio")]
        public List<DateTime?> FechaInicio { get; set; }

        [BsonElement("fechaFin")]
        public List<DateTime?> FechaFin { get; set; }

    }
}