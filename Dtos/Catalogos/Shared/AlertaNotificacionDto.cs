using MongoDB.Bson;

namespace PP_Nominas.Models.Shared
{
    public class AlertaNotificacionDto
    {
        public ObjectId Id { get; set; }
        public bool Activo { get; set; }
        public Auditable Auditable { get; set; }
        public string DescripcionAlerta { get; set; }
        public string EventoDisparador { get; set; }
        public int MedioEnvio { get; set; }
        public string PlantillaMensaje { get; set; }
        public int TipoPeriodicidad { get; set; }
    }
}
