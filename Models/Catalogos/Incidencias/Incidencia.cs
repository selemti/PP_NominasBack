using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Incidencias
{
    public class Incidencia
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string EmpleadoId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string TipoIncidenciaId { get; set; }

        public DateTime? FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string JustificanteId { get; set; }

        public string Auditable { get; set; }

    }
}