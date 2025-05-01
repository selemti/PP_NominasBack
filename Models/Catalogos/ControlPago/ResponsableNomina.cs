using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.ControlPago
{
    public class ResponsableNomina
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string UsuarioId { get; set; }

        public int? TipoResponsabilidad { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string CentroPagoNominaId { get; set; }

        public string Auditable { get; set; }

    }
}