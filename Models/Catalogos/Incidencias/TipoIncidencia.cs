using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Incidencias
{
    public class TipoIncidencia
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string NombreTipoIncidencia { get; set; }

        public string DescripcionTipoIncidencia { get; set; }

        public bool? RequiereJustificante { get; set; }

        public string Auditable { get; set; }

    }
}