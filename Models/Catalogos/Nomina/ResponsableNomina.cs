using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Nomina
{
    public class ResponsableNomina
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("usuarioId")]
        public List<string> UsuarioId { get; set; }

        [BsonElement("tipoResponsabilidad")]
        public List<int?> TipoResponsabilidad { get; set; }

        [BsonElement("centroPagoNominaId")]
        public List<string> CentroPagoNominaId { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}