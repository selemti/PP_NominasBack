using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Empleados
{
    public class ArchivoEmpleado
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("empleadoId")]
        public List<string> EmpleadoId { get; set; }

        [BsonElement("tipoArchivo")]
        public List<int?> TipoArchivo { get; set; }

        [BsonElement("urlArchivo")]
        public List<string> UrlArchivo { get; set; }

        [BsonElement("fechaCarga")]
        public List<DateTime?> FechaCarga { get; set; }

        [BsonElement("vigente")]
        public List<bool?> Vigente { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}