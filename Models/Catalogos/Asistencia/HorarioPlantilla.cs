using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    public class HorarioPlantilla
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string NombrePlantilla { get; set; }

        public string DescripcionPlantilla { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string TurnoId { get; set; }

        public string Auditable { get; set; }

    }
}