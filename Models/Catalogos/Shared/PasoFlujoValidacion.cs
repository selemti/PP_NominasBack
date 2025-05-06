using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PP_NominasBack.Models.Shared
{
    public class PasoFlujoValidacion
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("auditable")]
        public Auditable Auditable { get; set; }

        [BsonElement("autorizacionNecesaria")]
        public bool AutorizacionNecesaria { get; set; }

        [BsonElement("flujoValidacionId")]
        public ObjectId FlujoValidacionId { get; set; }

        [BsonElement("notificarEnEstePaso")]
        public bool NotificarEnEstePaso { get; set; }

        [BsonElement("ordenPaso")]
        public int OrdenPaso { get; set; }

        [BsonElement("responsableId")]
        public ObjectId ResponsableId { get; set; }

        [BsonElement("tipoResponsable")]
        public int TipoResponsable { get; set; }
    }
}
