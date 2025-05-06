using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    public class CompensacionOvertime
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("codigo")]
        public List<string> Codigo { get; set; }

        [BsonElement("nombre")]
        public List<string> Nombre { get; set; }

        [BsonElement("descripcion")]
        public List<string> Descripcion { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}