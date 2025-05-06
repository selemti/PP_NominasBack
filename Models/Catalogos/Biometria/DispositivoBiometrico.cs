using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Biometria
{
    public class DispositivoBiometrico
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("modelo")]
        public List<string> Modelo { get; set; }

        [BsonElement("numeroSerie")]
        public List<string> NumeroSerie { get; set; }

        [BsonElement("ipAsignada")]
        public List<string> IpAsignada { get; set; }

        [BsonElement("tipoDispositivo")]
        public List<int?> TipoDispositivo { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

        [BsonElement("centroId")]
        public List<string> CentroId { get; set; }

    }
}