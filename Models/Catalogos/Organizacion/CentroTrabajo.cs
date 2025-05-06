using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Organización
{
    public class CentroTrabajo
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("tipoCentroTrabajo")]
        public List<int?> TipoCentroTrabajo { get; set; }

    }
}