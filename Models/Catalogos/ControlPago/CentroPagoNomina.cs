using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.ControlPago
{
    public class CentroPagoNomina
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string NombreCentroPago { get; set; }

        public int? FechaCorteQuincena1 { get; set; }

        public int? FechaCorteQuincena2 { get; set; }

        public int? FechaPagoQuincena1 { get; set; }

        public int? FechaPagoQuincena2 { get; set; }

        public string Auditable { get; set; }

    }
}