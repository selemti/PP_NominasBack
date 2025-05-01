using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    public class PlantillaMensual
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public int? Mes { get; set; }

        public int? Ano { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string HorarioPlantillaId { get; set; }

        public string Auditable { get; set; }

    }
}