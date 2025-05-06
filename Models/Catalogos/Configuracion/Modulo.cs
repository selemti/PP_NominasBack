using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Configuracion
{
    public class Modulo
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("nombre")]
        public List<string> Nombre { get; set; }

        [BsonElement("descripcion")]
        public List<string> Descripcion { get; set; }

        [BsonElement("activo")]
        public List<bool?> Activo { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}