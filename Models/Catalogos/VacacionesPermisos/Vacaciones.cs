using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.VacacionesPermisos
{
    public class Vacaciones
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string EmpleadoId { get; set; }

        public DateTime? FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        public int? DiasProgramados { get; set; }

        public int? DiasGozados { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string PeriodoVacacionalId { get; set; }

        public string Auditable { get; set; }

    }
}