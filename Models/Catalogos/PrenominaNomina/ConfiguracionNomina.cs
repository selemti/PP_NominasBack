using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.PrenominaNomina
{
    public class ConfiguracionNomina
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string GrupoEmpresaId { get; set; }

        public int? TipoNomina { get; set; }

        public int? DiasPago { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string CentroTrabajoId { get; set; }

        public string Auditable { get; set; }

    }
}