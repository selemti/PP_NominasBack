using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Empleados
{
    public class DatosPagoEmpleado
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("empleadoId")]
        public List<string> EmpleadoId { get; set; }

        [BsonElement("bancoId")]
        public List<string> BancoId { get; set; }

        [BsonElement("cuentaBancaria")]
        public List<string> CuentaBancaria { get; set; }

        [BsonElement("formaPago")]
        public List<int?> FormaPago { get; set; }

        [BsonElement("vigente")]
        public List<bool?> Vigente { get; set; }

        [BsonElement("fechaInicio")]
        public List<DateTime?> FechaInicio { get; set; }

        [BsonElement("fechaFin")]
        public List<DateTime?> FechaFin { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}