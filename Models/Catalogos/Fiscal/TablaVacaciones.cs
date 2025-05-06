using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Fiscal
{
    public class TablaVacaciones
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("aniosAntiguedadMinimo")]
        public List<int?> AniosAntiguedadMinimo { get; set; }

        [BsonElement("aniosAntiguedadMaximo")]
        public List<int?> AniosAntiguedadMaximo { get; set; }

        [BsonElement("diasVacaciones")]
        public List<int?> DiasVacaciones { get; set; }

        [BsonElement("ejercicioFiscal")]
        public List<int?> EjercicioFiscal { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}