using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Seguridad
{
    public class Usuario
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("nombreUsuario")]
        public List<string> NombreUsuario { get; set; }

        [BsonElement("correoElectronico")]
        public List<string> CorreoElectronico { get; set; }

        [BsonElement("perfilId")]
        public List<string> PerfilId { get; set; }

        [BsonElement("estatusUsuario")]
        public List<int?> EstatusUsuario { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}