using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.CompensacionesDeducciones
{
    public class CatalogoDeducciones
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public int? TipoDeduccion { get; set; }

        public string NombreDeduccion { get; set; }

        public string DescripcionDeduccion { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string AplicaEmpresaId { get; set; }

        public string Auditable { get; set; }

    }
}