using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Empleados
{
    public class RegistroImss
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("empleadoId")]
        public List<string> EmpleadoId { get; set; }

        [BsonElement("fechaAlta")]
        public List<DateTime?> FechaAlta { get; set; }

        [BsonElement("fechaBaja")]
        public List<DateTime?> FechaBaja { get; set; }

        [BsonElement("nss")]
        public List<string> Nss { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}