using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Organizacion
{
    public class Ubicacion
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("nombre")]
        public List<string> Nombre { get; set; }

        [BsonElement("latitud")]
        public List<decimal?> Latitud { get; set; }

        [BsonElement("longitud")]
        public List<decimal?> Longitud { get; set; }

        [BsonElement("radio")]
        public List<decimal?> Radio { get; set; }

        [BsonElement("tipoUbicacion")]
        public List<int?> TipoUbicacion { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}