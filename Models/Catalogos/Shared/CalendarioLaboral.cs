using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    public class CalendarioLaboral
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("fecha")]
        public List<DateTime?> Fecha { get; set; }

        [BsonElement("tipoDia")]
        public List<int?> TipoDia { get; set; }

        [BsonElement("descripcionEvento")]
        public List<string> DescripcionEvento { get; set; }

        [BsonElement("empresaId")]
        public List<string> EmpresaId { get; set; }

        [BsonElement("divisionId")]
        public List<string> DivisionId { get; set; }

        [BsonElement("vigente")]
        public List<bool?> Vigente { get; set; }

    }
}