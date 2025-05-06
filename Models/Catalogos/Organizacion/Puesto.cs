using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Organización
{
    public class Puesto
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("nivelPuesto")]
        public List<int?> NivelPuesto { get; set; }

    }
}