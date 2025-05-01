using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.CompensacionesDeducciones
{
    public class CatalogoPrestaciones
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string NombrePrestacion { get; set; }

        public string DescripcionPrestacion { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string AplicaEmpresaId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string AplicaDivisionId { get; set; }

        public string Auditable { get; set; }

    }
}