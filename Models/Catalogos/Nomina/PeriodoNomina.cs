using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Nomina
{
    public class PeriodoNomina
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("tipoNomina")]
        public List<int?> TipoNomina { get; set; }

    }
}