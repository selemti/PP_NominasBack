using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Configuracion
{
    public class Politica
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string NombrePolitica { get; set; }

        public string DescripcionPolitica { get; set; }

        public string VersionPolitica { get; set; }

        public DateTime? FechaInicioVigencia { get; set; }

        public DateTime? FechaFinVigencia { get; set; }

        public string Auditable { get; set; }

    }
}