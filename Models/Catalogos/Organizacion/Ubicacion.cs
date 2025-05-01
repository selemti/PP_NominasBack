using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Organizacion
{
    public class Ubicacion
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Nombre { get; set; }

        public decimal? Latitud { get; set; }

        public decimal? Longitud { get; set; }

        public decimal? Radio { get; set; }

        public int? TipoUbicacion { get; set; }

        public string Auditable { get; set; }

    }
}