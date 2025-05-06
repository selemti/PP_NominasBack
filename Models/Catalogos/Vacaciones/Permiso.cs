using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Vacaciones
{
    public class Permiso
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public List<string> Id { get; set; }

        [BsonElement("empleadoId")]
        public List<string> EmpleadoId { get; set; }

        [BsonElement("tipoPermiso")]
        public List<int?> TipoPermiso { get; set; }

        [BsonElement("fechaInicio")]
        public List<DateTime?> FechaInicio { get; set; }

        [BsonElement("fechaFin")]
        public List<DateTime?> FechaFin { get; set; }

        [BsonElement("requiereSuplente")]
        public List<bool?> RequiereSuplente { get; set; }

        [BsonElement("modalidadReposicion")]
        public List<int?> ModalidadReposicion { get; set; }

        [BsonElement("detalleReposicion")]
        public List<string> DetalleReposicion { get; set; }

        [BsonElement("auditable")]
        public List<Auditable?> Auditable { get; set; }

    }
}