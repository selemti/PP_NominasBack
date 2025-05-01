using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.CompensacionesDeducciones
{
    public class CatalogoCompensaciones
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public int? TipoCompensacion { get; set; }

        public string NombreCompensacion { get; set; }

        public string DescripcionCompensacion { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string AplicaEmpresaId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string AplicaDivisionId { get; set; }

        public string Auditable { get; set; }

    }
}