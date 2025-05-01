using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Models.Catalogos.Shared
{
    public enum EstatusEmpleadoEnum
    {
        [Display(Name = "Activo")]
        Activo = 1,
        [Display(Name = "Baja")]
        Baja = 2,
        [Display(Name = "Suspendido")]
        Suspendido = 3,
        [Display(Name = "Vacaciones")]
        Vacaciones = 4,
    }

    public enum TipoContratoEnum
    {
        [Display(Name = "Indeterminado")]
        Indeterminado = 1,
        [Display(Name = "Determinado")]
        Determinado = 2,
        [Display(Name = "Por obra o proyecto")]
        PorObra = 3,
        [Display(Name = "Por temporada")]
        PorTemporada = 4,
        [Display(Name = "Prueba o capacitación")]
        Prueba = 5,
        [Display(Name = "Otro")]
        Otro = 6,
    }

    public enum TipoArchivoEnum
    {
        [Display(Name = "INE")]
        INE = 1,
        [Display(Name = "CURP")]
        CURP = 2,
        [Display(Name = "Comprobante de domicilio")]
        ComprobanteDomicilio = 3,
        [Display(Name = "Contrato laboral")]
        Contrato = 4,
        [Display(Name = "Otro")]
        Otro = 5,
    }

    public enum FormaPagoEnum
    {
        [Display(Name = "Transferencia electrónica")]
        Transferencia = 1,
        [Display(Name = "Cheque nominativo")]
        Cheque = 2,
        [Display(Name = "Efectivo")]
        Efectivo = 3,
        [Display(Name = "Otro")]
        Otro = 4,
    }

    public enum TipoSalarioEnum
    {
        [Display(Name = "Fijo")]
        Fijo = 1,
        [Display(Name = "Variable")]
        Variable = 2,
        [Display(Name = "Mixto")]
        Mixto = 3,
    }

    public enum EstatusPlazaEnum
    {
        [Display(Name = "Ocupada")]
        Ocupada = 1,
        [Display(Name = "Vacante")]
        Vacante = 2,
        [Display(Name = "Suspendida")]
        Suspendida = 3,
    }

    public enum TipoTurnoEnum
    {
        [Display(Name = "Matutino")]
        Matutino = 1,
        [Display(Name = "Vespertino")]
        Vespertino = 2,
        [Display(Name = "Nocturno")]
        Nocturno = 3,
        [Display(Name = "Mixto")]
        Mixto = 4,
    }

    public enum TipoEventoEnum
    {
        [Display(Name = "Entrada")]
        Entrada = 1,
        [Display(Name = "Salida")]
        Salida = 2,
        [Display(Name = "Justificado")]
        Justificado = 3,
        [Display(Name = "Falta")]
        Falta = 4,
    }

    public enum TipoDiaEnum
    {
        [Display(Name = "Día laboral")]
        Laboral = 1,
        [Display(Name = "Día de descanso")]
        Descanso = 2,
        [Display(Name = "Día festivo oficial")]
        Festivo = 3,
    }

    public enum TipoDispositivoEnum
    {
        [Display(Name = "Dispositivo biométrico")]
        Biometrico = 1,
        [Display(Name = "Aplicación móvil")]
        Movil = 2,
        [Display(Name = "Plataforma web")]
        Web = 3,
    }

    public enum TipoJustificanteEnum
    {
        [Display(Name = "Justificante médico")]
        Medico = 1,
        [Display(Name = "Permiso personal")]
        Personal = 2,
        [Display(Name = "Otro")]
        Otro = 3,
    }

    public enum TipoIncapacidadEnum
    {
        [Display(Name = "Enfermedad general")]
        EnfermedadGeneral = 1,
        [Display(Name = "Riesgo de trabajo")]
        RiesgoTrabajo = 2,
        [Display(Name = "Maternidad")]
        Maternidad = 3,
        [Display(Name = "Otro")]
        Otro = 4,
    }

    public enum TipoPermisoEnum
    {
        [Display(Name = "Con goce de sueldo")]
        ConGoce = 1,
        [Display(Name = "Sin goce de sueldo")]
        SinGoce = 2,
        [Display(Name = "Por horas")]
        PorHoras = 3,
    }

    public enum ModalidadReposicionEnum
    {
        [Display(Name = "Reposición con tiempo extra")]
        TiempoExtra = 1,
        [Display(Name = "Día compensatorio")]
        DíaCompensatorio = 2,
        [Display(Name = "No requiere reposición")]
        NoRequiere = 3,
    }

    public enum TipoNominaEnum
    {
        [Display(Name = "Nómina ordinaria")]
        Ordinaria = 1,
        [Display(Name = "Nómina extraordinaria")]
        Extraordinaria = 2,
        [Display(Name = "Finiquito")]
        Finiquito = 3,
        [Display(Name = "Liquidación")]
        Liquidacion = 4,
    }

    public enum TipoFiscalizacionEnum
    {
        [Display(Name = "Normal")]
        Normal = 1,
        [Display(Name = "Complementaria")]
        Complementaria = 2,
        [Display(Name = "Sustitutiva")]
        Sustitutiva = 3,
    }

    public enum TipoCompensacionEnum
    {
        [Display(Name = "Bono")]
        Bono = 1,
        [Display(Name = "Vales")]
        Vales = 2,
        [Display(Name = "Prestación")]
        Prestacion = 3,
        [Display(Name = "Otro")]
        Otro = 4,
    }

    public enum TipoDeduccionEnum
    {
        [Display(Name = "ISR")]
        ISR = 1,
        [Display(Name = "IMSS")]
        IMSS = 2,
        [Display(Name = "Préstamo")]
        Prestamo = 3,
        [Display(Name = "Infonavit")]
        Infonavit = 4,
    }

    public enum TipoAsignacionEnum
    {
        [Display(Name = "Automática")]
        Automatica = 1,
        [Display(Name = "Manual")]
        Manual = 2,
    }

    public enum PeriodicidadEnum
    {
        [Display(Name = "Diario")]
        Diario = 1,
        [Display(Name = "Semanal")]
        Semanal = 2,
        [Display(Name = "Quincenal")]
        Quincenal = 3,
        [Display(Name = "Mensual")]
        Mensual = 4,
        [Display(Name = "Otro")]
        Otro = 5,
    }

    public enum TipoResponsabilidadEnum
    {
        [Display(Name = "Administrador")]
        Administrador = 1,
        [Display(Name = "Supervisor")]
        Supervisor = 2,
        [Display(Name = "Empleado")]
        Empleado = 3,
    }

    public enum PeriodoEnum
    {
        [Display(Name = "Enero")]
        Enero = 1,
        [Display(Name = "Febrero")]
        Febrero = 2,
        [Display(Name = "Marzo")]
        Marzo = 3,
        [Display(Name = "Abril")]
        Abril = 4,
        [Display(Name = "Mayo")]
        Mayo = 5,
        [Display(Name = "Junio")]
        Junio = 6,
        [Display(Name = "Julio")]
        Julio = 7,
        [Display(Name = "Agosto")]
        Agosto = 8,
        [Display(Name = "Septiembre")]
        Septiembre = 9,
        [Display(Name = "Octubre")]
        Octubre = 10,
        [Display(Name = "Noviembre")]
        Noviembre = 11,
        [Display(Name = "Diciembre")]
        Diciembre = 12,
    }

    public enum TipoDescuentoEnum
    {
        [Display(Name = "Porcentaje")]
        Porcentaje = 1,
        [Display(Name = "Cantidad fija")]
        CantidadFija = 2,
    }

    public enum TipoMovimientoEnum
    {
        [Display(Name = "Alta")]
        Alta = 1,
        [Display(Name = "Baja")]
        Baja = 2,
        [Display(Name = "Modificación")]
        Modificacion = 3,
        [Display(Name = "Reingreso")]
        Reingreso = 4,
    }

    public enum EstatusUsuarioEnum
    {
        [Display(Name = "Activo")]
        Activo = 1,
        [Display(Name = "Suspendido")]
        Suspendido = 2,
        [Display(Name = "Inactivo")]
        Inactivo = 3,
        [Display(Name = "Bloqueado")]
        Bloqueado = 4,
    }

    public enum TipoDestinatarioEnum
    {
        [Display(Name = "Empleado")]
        Empleado = 1,
        [Display(Name = "Supervisor")]
        Supervisor = 2,
        [Display(Name = "Departamento")]
        Departamento = 3,
        [Display(Name = "Global")]
        Global = 4,
    }

    public enum TipoResponsableEnum
    {
        [Display(Name = "Usuario")]
        Usuario = 1,
        [Display(Name = "Perfil")]
        Perfil = 2,
        [Display(Name = "Sistema")]
        Sistema = 3,
    }

    public enum MedioEnvioEnum
    {
        [Display(Name = "Correo electrónico")]
        Correo = 1,
        [Display(Name = "WhatsApp")]
        Whatsapp = 2,
        [Display(Name = "Mensaje SMS")]
        SMS = 3,
        [Display(Name = "Notificación interna")]
        Interno = 4,
    }

}