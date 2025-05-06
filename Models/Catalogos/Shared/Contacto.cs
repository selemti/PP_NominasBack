using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Shared
{
    public class Contacto
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("tipoEntidad")]
        public List<string> TipoEntidad { get; set; }

        [BsonElement("entidadId")]
        public List<string> EntidadId { get; set; }

        [BsonElement("nombreContacto")]
        public List<string> NombreContacto { get; set; }

        [BsonElement("telefonoContacto")]
        public List<string> TelefonoContacto { get; set; }

        [BsonElement("parentesco")]
        public List<string> Parentesco { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}