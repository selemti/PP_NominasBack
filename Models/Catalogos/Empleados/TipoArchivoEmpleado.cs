using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Empleados
{
    public class TipoArchivoEmpleado
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public bool? Requerido { get; set; }

        public string Auditable { get; set; }

    }
}