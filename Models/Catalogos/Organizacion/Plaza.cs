using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Organizacion
{
    public class Plaza
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("clavePlaza")]
        public List<string> ClavePlaza { get; set; }

        [BsonElement("nombrePlaza")]
        public List<string> NombrePlaza { get; set; }

        [BsonElement("puestoId")]
        public List<string> PuestoId { get; set; }

        [BsonElement("departamentoId")]
        public List<string> DepartamentoId { get; set; }

        [BsonElement("estatusPlaza")]
        public List<int?> EstatusPlaza { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}