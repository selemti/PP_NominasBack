using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.PrenominaNomina
{
    public class ReciboNomina
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string EmpleadoId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string PeriodoNominaId { get; set; }

        public decimal? TotalPercepciones { get; set; }

        public decimal? TotalDeducciones { get; set; }

        public decimal? TotalNeto { get; set; }

        public int? FormaPago { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string BancoId { get; set; }

        public string CuentaBancaria { get; set; }

        public string Auditable { get; set; }

        public int? TipoNomina { get; set; }

        public decimal? NetoGravado { get; set; }

        public decimal? NetoExento { get; set; }

        public decimal? NetoExcedente { get; set; }

    }
}