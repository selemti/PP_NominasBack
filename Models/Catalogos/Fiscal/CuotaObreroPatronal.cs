using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Fiscal
{
    public class CuotaObreroPatronal
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Concepto { get; set; }

        public decimal? PorcentajePatron { get; set; }

        public decimal? PorcentajeEmpleado { get; set; }

        public DateTime? VigenciaInicio { get; set; }

        public DateTime? VigenciaFin { get; set; }

        public string Auditable { get; set; }

    }
}