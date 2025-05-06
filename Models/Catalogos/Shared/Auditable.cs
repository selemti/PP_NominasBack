using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Shared
{
    public class Auditable
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("fechaCreacion")]
        public List<DateTime?> FechaCreacion { get; set; }

        [BsonElement("fechaModificacion")]
        public List<DateTime?> FechaModificacion { get; set; }

        [BsonElement("usuarioCreadorId")]
        public List<string> UsuarioCreadorId { get; set; }

        [BsonElement("usuarioModificadorId")]
        public List<string> UsuarioModificadorId { get; set; }

    }
}