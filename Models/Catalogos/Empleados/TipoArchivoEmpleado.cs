using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Empleados
{
    public class TipoArchivoEmpleado
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("codigo")]
        public List<string> Codigo { get; set; }

        [BsonElement("nombre")]
        public List<string> Nombre { get; set; }

        [BsonElement("requerido")]
        public List<bool?> Requerido { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}