using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Nomina
{
    public class CentroPagoNomina
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("nombreCentroPago")]
        public List<string> NombreCentroPago { get; set; }

        [BsonElement("fechaCorteQuincena1")]
        public List<int?> FechaCorteQuincena1 { get; set; }

        [BsonElement("fechaCorteQuincena2")]
        public List<int?> FechaCorteQuincena2 { get; set; }

        [BsonElement("fechaPagoQuincena1")]
        public List<int?> FechaPagoQuincena1 { get; set; }

        [BsonElement("fechaPagoQuincena2")]
        public List<int?> FechaPagoQuincena2 { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}