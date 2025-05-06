using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Incidencias
{
    public class TipoIncidencia
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("nombreTipoIncidencia")]
        public List<string> NombreTipoIncidencia { get; set; }

        [BsonElement("descripcionTipoIncidencia")]
        public List<string> DescripcionTipoIncidencia { get; set; }

        [BsonElement("requiereJustificante")]
        public List<bool?> RequiereJustificante { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}