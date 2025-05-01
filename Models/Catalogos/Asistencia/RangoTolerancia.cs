using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    public class RangoTolerancia
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public int? MinutosDesde { get; set; }

        public int? MinutosHasta { get; set; }

        public bool? Penalizacion { get; set; }

        public string Auditable { get; set; }

    }
}