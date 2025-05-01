using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    public class ChecadaAgregada
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string EmpleadoId { get; set; }

        public DateTime? Fecha { get; set; }

        public string HoraEntrada { get; set; }

        public string HoraSalida { get; set; }

        public string Observaciones { get; set; }

        public string Auditable { get; set; }

    }
}