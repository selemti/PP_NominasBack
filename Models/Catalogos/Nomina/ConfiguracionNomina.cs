using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Nomina
{
    public class ConfiguracionNomina
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("grupoEmpresaId")]
        public List<string> GrupoEmpresaId { get; set; }

        [BsonElement("tipoNomina")]
        public List<int?> TipoNomina { get; set; }

        [BsonElement("diasPago")]
        public List<List<int>?> DiasPago { get; set; }

        [BsonElement("centroTrabajoId")]
        public List<string> CentroTrabajoId { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}