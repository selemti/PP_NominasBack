using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Shared
{
    public class Direccion
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("calle")]
        public List<string> Calle { get; set; }

        [BsonElement("numeroExterior")]
        public List<string> NumeroExterior { get; set; }

    }
}