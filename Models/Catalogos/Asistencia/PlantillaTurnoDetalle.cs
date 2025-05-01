using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    public class PlantillaTurnoDetalle
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string PlantillaId { get; set; }

        public DateTime? Fecha { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string TurnoId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string PlazaId { get; set; }

        public string Auditable { get; set; }

    }
}