using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.AlertasValidacionesEnums
{
    public class PasoFlujoValidacion
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string FlujoValidacionId { get; set; }

        public int? OrdenPaso { get; set; }

        public int? TipoResponsable { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string ResponsableId { get; set; }

        public bool? AutorizacionNecesaria { get; set; }

        public bool? NotificarEnEstePaso { get; set; }

        public string Auditable { get; set; }

    }
}