using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Shared
{
    public class CatalogoEnums
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("key")]
        public int Key { get; set; }

        [BsonElement("value")]
        public string Value { get; set; }

        [BsonElement("catalogName")]
        public string CatalogName { get; set; }

        [BsonElement("items")]
        public List<CatalogoEnumsDto> Items { get; set; }

    }
}