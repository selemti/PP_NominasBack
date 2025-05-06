using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Configuracion
{
    public class ConfiguracionGlobal
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("categoriaConfiguracion")]
        public List<string> CategoriaConfiguracion { get; set; }

        [BsonElement("claveConfiguracion")]
        public List<string> ClaveConfiguracion { get; set; }

        [BsonElement("valorConfiguracion")]
        public List<string> ValorConfiguracion { get; set; }

        [BsonElement("descripcionConfiguracion")]
        public List<string> DescripcionConfiguracion { get; set; }

        [BsonElement("fechaInicioVigencia")]
        public List<DateTime?> FechaInicioVigencia { get; set; }

        [BsonElement("fechaFinVigencia")]
        public List<DateTime?> FechaFinVigencia { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}