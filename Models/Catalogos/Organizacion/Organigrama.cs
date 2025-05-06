using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Organizacion
{
    public class Organigrama
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("divisionId")]
        public List<string> DivisionId { get; set; }

        [BsonElement("puestoId")]
        public List<string> PuestoId { get; set; }

        [BsonElement("centroCostoId")]
        public List<string> CentroCostoId { get; set; }

        [BsonElement("nodoPadreId")]
        public List<string> NodoPadreId { get; set; }

        [BsonElement("nivel")]
        public List<int?> Nivel { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}