using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Shared
{
    public class Persona
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Curp { get; set; }

        public string Rfc { get; set; }

        public string Nombre { get; set; }

        public string ApellidoPaterno { get; set; }

        public string ApellidoMaterno { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public int? Sexo { get; set; }

        public int? EstadoCivil { get; set; }

        public int? NivelEstudio { get; set; }

        public int? TipoSangre { get; set; }

        public string Auditable { get; set; }

    }
}