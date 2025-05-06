using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    public class Horario
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("tipoHorario")]
        public List<int?> TipoHorario { get; set; }

    }
}