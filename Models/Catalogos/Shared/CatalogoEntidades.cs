using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Shared
{
    public class CatalogoEntidades
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("entityCode")]
        public List<string> EntityCode { get; set; }

        [BsonElement("nombreEntidad")]
        public List<string> NombreEntidad { get; set; }

        [BsonElement("moduloRelacionado")]
        public List<string> ModuloRelacionado { get; set; }

        [BsonElement("descripcionEntidad")]
        public List<string> DescripcionEntidad { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}