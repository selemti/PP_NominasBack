using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Configuracion
{
    public class ParametroSistema
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("claveParametro")]
        public List<string> ClaveParametro { get; set; }

        [BsonElement("valorParametro")]
        public List<string> ValorParametro { get; set; }

        [BsonElement("descripcionParametro")]
        public List<string> DescripcionParametro { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}