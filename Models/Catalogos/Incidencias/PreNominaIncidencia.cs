using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Incidencias
{
    public class PreNominaIncidencia
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string EmpleadoId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string PeriodoNominaId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string TipoIncidenciaId { get; set; }

        public DateTime? Fecha { get; set; }

        public decimal? Duracion { get; set; }

        public string JustificanteAdjunto { get; set; }

        public string Estatus { get; set; }

        public string Auditable { get; set; }

    }
}