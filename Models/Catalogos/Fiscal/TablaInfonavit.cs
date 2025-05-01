using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Fiscal
{
    public class TablaInfonavit
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public int? TipoDescuento { get; set; }

        public decimal? ValorDescuento { get; set; }

        public string Descripcion { get; set; }

        public int? EjercicioFiscal { get; set; }

        public string Auditable { get; set; }

    }
}