using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Empleados
{
    public class HistorialPlazaEmpleado
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string EmpleadoId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string PlazaIdAnterior { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string PlazaIdNueva { get; set; }

        public DateTime? FechaCambio { get; set; }

        public string MotivoCambio { get; set; }

        public string Auditable { get; set; }

    }
}