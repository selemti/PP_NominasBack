using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Configuracion
{
    public class Politica
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("nombrePolitica")]
        public List<string> NombrePolitica { get; set; }

        [BsonElement("descripcionPolitica")]
        public List<string> DescripcionPolitica { get; set; }

        [BsonElement("versionPolitica")]
        public List<string> VersionPolitica { get; set; }

        [BsonElement("fechaInicioVigencia")]
        public List<DateTime?> FechaInicioVigencia { get; set; }

        [BsonElement("fechaFinVigencia")]
        public List<string> FechaFinVigencia { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}