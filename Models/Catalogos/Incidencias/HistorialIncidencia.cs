using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Incidencias
{
    public class HistorialIncidencia
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string IncidenciaId { get; set; }

        public DateTime? FechaCambio { get; set; }

        public string DescripcionCambio { get; set; }

        public string Auditable { get; set; }

    }
}