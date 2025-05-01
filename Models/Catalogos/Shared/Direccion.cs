using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Shared
{
    public class Direccion
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string TipoEntidad { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string EntidadId { get; set; }

        public string Calle { get; set; }

        public string NumeroExterior { get; set; }

        public string NumeroInterior { get; set; }

        public string Colonia { get; set; }

        public string Municipio { get; set; }

        public string Estado { get; set; }

        public string CodigoPostal { get; set; }

        public string Pais { get; set; }

        public string Auditable { get; set; }

    }
}