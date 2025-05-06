using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PP_NominasBack.Models.Shared
{
    public class AlertaNotificacion
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("activo")]
        public bool Activo { get; set; }

        [BsonElement("auditable")]
        public Auditable Auditable { get; set; }

        [BsonElement("descripcionAlerta")]
        public string DescripcionAlerta { get; set; }

        [BsonElement("eventoDisparador")]
        public string EventoDisparador { get; set; }

        [BsonElement("medioEnvio")]
        public int MedioEnvio { get; set; }

        [BsonElement("plantillaMensaje")]
        public string PlantillaMensaje { get; set; }

        [BsonElement("tipoPeriodicidad")]
        public int TipoPeriodicidad { get; set; }
    }
}
