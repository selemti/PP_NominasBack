using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Shared
{
    public class Persona
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("curp")]
        public List<string> Curp { get; set; }

        [BsonElement("rfc")]
        public List<string> Rfc { get; set; }

        [BsonElement("email")]
        public List<string> Email { get; set; }

        [BsonElement("nacionalidad")]
        public List<string> Nacionalidad { get; set; }

        [BsonElement("direccion")]
        public List<Direccion>? Direccion { get; set; }

        [BsonElement("telefonos")]
        public List<List<Telefono>?> Telefonos { get; set; }

    }
}