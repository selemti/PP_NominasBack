using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    public class ChecadaRemota
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string EmpleadoId { get; set; }

        public DateTime? FechaHora { get; set; }

        public int? TipoEvento { get; set; }

        public decimal? Latitud { get; set; }

        public decimal? Longitud { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string UbicacionId { get; set; }

        public string FotoAdjunta { get; set; }

        public string Auditable { get; set; }

    }
}