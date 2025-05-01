using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Empleados
{
    public class ArchivoEmpleado
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string EmpleadoId { get; set; }

        public int? TipoArchivo { get; set; }

        public string UrlArchivo { get; set; }

        public DateTime? FechaCarga { get; set; }

        public bool? Vigente { get; set; }

        public string Auditable { get; set; }

    }
}