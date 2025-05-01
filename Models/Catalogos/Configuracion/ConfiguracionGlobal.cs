using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Configuracion
{
    public class ConfiguracionGlobal
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string CategoriaConfiguracion { get; set; }

        public string ClaveConfiguracion { get; set; }

        public string ValorConfiguracion { get; set; }

        public string DescripcionConfiguracion { get; set; }

        public DateTime? FechaInicioVigencia { get; set; }

        public DateTime? FechaFinVigencia { get; set; }

        public string Auditable { get; set; }

    }
}