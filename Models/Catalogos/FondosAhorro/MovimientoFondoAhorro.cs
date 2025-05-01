using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.FondosAhorro
{
    public class MovimientoFondoAhorro
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string FondoAhorroId { get; set; }

        public int? TipoMovimiento { get; set; }

        public decimal? Monto { get; set; }

        public DateTime? FechaMovimiento { get; set; }

        public string Descripcion { get; set; }

        public string Auditable { get; set; }

    }
}