using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Empleados
{
    public class ContratoEmpleado
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string EmpleadoId { get; set; }

        public int? TipoContrato { get; set; }

        public DateTime? FechaInicioContrato { get; set; }

        public DateTime? FechaFinContrato { get; set; }

        public string Auditable { get; set; }

    }
}