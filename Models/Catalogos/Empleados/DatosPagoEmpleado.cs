using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Empleados
{
    public class DatosPagoEmpleado
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string EmpleadoId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string BancoId { get; set; }

        public string CuentaBancaria { get; set; }

        public int? FormaPago { get; set; }

        public bool? Vigente { get; set; }

        public DateTime? FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        public string Auditable { get; set; }

    }
}