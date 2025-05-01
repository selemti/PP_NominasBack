using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.VacacionesPermisos
{
    public class PeriodoVacacional
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public int? Anio { get; set; }

        public int? DiasAsignados { get; set; }

        public string Auditable { get; set; }

    }
}