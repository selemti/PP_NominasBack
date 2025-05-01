using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Empleados
{
    public class Empleado
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string PersonaId { get; set; }

        public int? EstatusEmpleado { get; set; }

        public DateTime? FechaIngreso { get; set; }

        public DateTime? FechaBaja { get; set; }

        public string Auditable { get; set; }

    }
}