using MongoDB.Bson;

namespace PP_Nominas.Models.Shared
{
    public class DestinatarioAlertaDto
    {
        public ObjectId Id { get; set; }
        public ObjectId AlertaId { get; set; }
        public Auditable Auditable { get; set; }
        public int TipoDestinatario { get; set; }
        public string ValorDestino { get; set; }
    }
}
