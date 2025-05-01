using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    public class Turno
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string NombreTurno { get; set; }

        public string HoraEntrada { get; set; }

        public string HoraSalida { get; set; }

        public int? TipoTurno { get; set; }

        public string Auditable { get; set; }

    }
}