using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisCreWin.Modelo
{
    public class clsCatalogosFijos
    {

    }

    public static class CatalogoStoreds
    {
        #region Variables
        #region Sistema
        //Usuarios
        public static String Usuarios_C_ValidarLogin { get { return "sp_Usuarios_C_ValidarLogin"; } }
        public static String Usuarios_C_AccesoModulo { get { return "sp_Usuarios_C_AccesoModulo"; } }
        public static String Usuarios_C_Usuarios { get { return "sp_Usuarios_C_Usuarios"; } }
        public static String Usuarios_I_Usuarios { get { return "sp_Usuarios_I_Usuarios"; } }
        public static String Usuarios_U_Usuarios { get { return "sp_Usuarios_U_Usuarios"; } }
        public static String Usuarios_C_UsuariosBitacora { get { return "sp_Usuarios_C_UsuariosBitacora"; } }
        public static String Usuarios_C_AutocompleteUsuarios { get { return "sp_Usuarios_C_AutocompleteUsuarios"; } }
        public static String Usuarios_C_Permisos { get { return "sp_Usuarios_C_Permisos"; } }
        public static String Usuarios_M_Permisos { get { return "sp_Usuarios_M_Permisos"; } }
        public static String Usuarios_C_PermisosBitacora { get { return "sp_Usuarios_C_PermisosBitacora"; } }
        //!Usuarios
        //Modulos
        public static String Catalogos_C_Modulos { get { return "sp_Catalogos_C_Modulos"; } }
        public static String Catalogos_I_Modulos { get { return "sp_Catalogos_I_Modulos"; } }
        public static String Catalogos_U_Modulos { get { return "sp_Catalogos_U_Modulos"; } }
        public static String Catalogos_C_ModulosBitacora { get { return "sp_Catalogos_C_ModulosBitacora"; } }
        public static String Modulos_C_Activo { get { return "sp_Modulos_C_Activo"; } }
        //!Modulos
        //Bitacoras
        public static String Bitacoras_I_MovimientosSistema { get { return "sp_Bitacoras_I_MovimientosSistema"; } }
        public static String Bitacoras_C_MovimientosSistema { get { return "sp_Bitacoras_C_MovimientosSistema"; } }
        public static String Bitacoras_C_MovimientosDatos { get { return "sp_Bitacoras_C_MovimientosDatos"; } }
        //!Bitacoras
        //General
        public static String Sistema_C_Mantenimiento { get { return "sp_Sistema_C_Mantenimiento"; } }
        public static String Sistema_C_Top10PaginasUsuario { get { return "sp_Sistema_C_Top10PaginasUsuario"; } }
        public static String Catalogos_C_Procedimientos { get { return "sp_Catalogos_C_Procedimientos"; } }
        //!General
        #endregion Sistema
        #region Negocio
        //Promotores
        public static String Catalogos_C_Promotores { get { return "sp_Catalogos_C_Promotores"; } }
        public static String Catalogos_I_Promotores { get { return "sp_Catalogos_I_Promotores"; } }
        public static String Catalogos_U_Promotores { get { return "sp_Catalogos_U_Promotores"; } }
        public static String Catalogos_C_PromotoresBitacora { get { return "sp_Catalogos_C_PromotoresBitacora"; } }
        //!Promotores
        //Proyectos
        public static String Catalogos_C_Proyectos { get { return "sp_Catalogos_C_Proyectos"; } }
        public static String Catalogos_I_Proyectos { get { return "sp_Catalogos_I_Proyectos"; } }
        public static String Catalogos_U_Proyectos { get { return "sp_Catalogos_U_Proyectos"; } }
        public static String Catalogos_C_ProyectosBitacora { get { return "sp_Catalogos_C_ProyectosBitacora"; } }
        //!Proyectos
        //Buro
        public static String ReportesBuro_C_CreditosPuentes { get { return "sp_ReportesBuro_C_CreditosPuentes"; } }
        public static String Buro_I_HistoricoPuentes { get { return "sp_Buro_I_HistoricoPuentes"; } }
        public static String Buro_C_HistoricoPuentes { get { return "sp_Buro_C_HistoricoPuentes"; } }
        public static String Buro_C_HistoricoPuentesDatos { get { return "sp_Buro_C_HistoricoPuentesDatos"; } }
        public static String Buro_C_PeriodosDisponiblesPuentes { get { return "sp_Buro_C_PeriodosDisponiblesPuentes"; } }
        public static String ReportesBuro_C_CreditosIndividuales { get { return "sp_ReportesBuro_C_CreditosIndividuales"; } }
        public static String Buro_I_HistoricoIndividuales { get { return "sp_Buro_I_HistoricoIndividuales"; } }
        public static String Buro_C_HistoricoIndividuales { get { return "sp_Buro_C_HistoricoIndividuales"; } }
        public static String Buro_C_HistoricoIndDatos { get { return "sp_Buro_C_HistoricoIndDatos"; } }
        public static String Buro_C_PeriodosDisponiblesIndividuales { get { return "sp_Buro_C_PeriodosDisponiblesIndividuales"; } }
        public static String Buro_M_Documentos { get { return "sp_Buro_M_Documentos"; } }
        public static String Buro_U_AutorizarRecreacion { get { return "sp_Buro_U_AutorizarRecreacion"; } }
        //!Buro
        //TIIE
        public static String Catalogos_C_TIIE { get { return "sp_Catalogos_C_TIIE"; } }
        public static String Catalogos_I_TIIE { get { return "sp_Catalogos_I_TIIE"; } }
        public static String Catalogos_U_TIIE { get { return "sp_Catalogos_U_TIIE"; } }
        public static String Catalogos_C_TIIEBitacora { get { return "sp_Catalogos_C_TIIEBitacora"; } }
        //!TIIE
        //Origen_Creditos_Puente
        public static String Catalogos_C_OrigenCreditosPuente { get { return "sp_Catalogos_C_OrigenCreditosPuente"; } }
        public static String Catalogos_I_OrigenCreditosPuente { get { return "sp_Catalogos_I_OrigenCreditosPuente"; } }
        public static String Catalogos_U_OrigenCreditosPuente { get { return "sp_Catalogos_U_OrigenCreditosPuente"; } }
        public static String Catalogos_C_OrigenCreditosPuenteBitacora { get { return "sp_Catalogos_C_OrigenCreditosPuenteBitacora"; } }
        //!Origen_Creditos_Puente
        //Operaciones_Puentes
        public static String Puentes_C_VerificarPosibilidadCierre { get { return "sp_Puentes_C_VerificarPosibilidadCierre"; } }
        public static String Puentes_C_ObtenerFechaUltimoCierre { get { return "sp_Puentes_C_ObtenerFechaUltimoCierre"; } }
        public static String Puentes_I_CierreDiario { get { return "sp_Puentes_I_CierreDiario"; } }
        public static String Puentes_M_RegistrarPago { get { return "sp_Puentes_M_RegistrarPago"; } }
        public static String Puentes_C_ObtenerPrestamos { get { return "sp_Puentes_C_ObtenerPrestamos"; } }
        public static String Puentes_C_MovimientosPrestamo { get { return "sp_Puentes_C_MovimientosPrestamo"; } }
        //!Operaciones_Puentes
        #endregion Negocio
        #endregion Variables

    }

    public static class CatalogoModulos
    {
        #region Variables
        #region Sistema
        public static int Catalogos_Modulos_ABC { get { return 1; } }
        public static int Usuarios_ABC { get { return 2; } }
        public static int Usuarios_Permisos { get { return 11; } }
        public static int Bitacora_Movimientos { get { return 12; } }
        #endregion Sistema
        #region Negocio
        public static int Catalogos_TIIE_ABC { get { return 6; } }
        public static int Buro_Individuales_GenerarCSV { get { return 8; } }
        public static int Buro_Individuales_Historico { get { return 13; } }
        public static int Buro_Individuales_RegenerarCSV { get { return 16; } }
        public static int Buro_Puentes_GenerarINTF { get { return 5; } }
        public static int Buro_Puentes_Historico { get { return 14; } }
        public static int Buro_Puentes_RegenerarINTF { get { return 17; } }
        public static int Promotores_ABC { get { return 3; } }
        public static int Proyectos_ABC { get { return 4; } }
        public static int Puentes_OCP_ABC { get { return 7; } }
        public static int Puentes_GenerarCierre { get { return 9; } }
        public static int Puentes_RegistrarPago { get { return 10; } }
        public static int Puentes_Historico { get { return 15; } }
        #endregion Negocio
        #endregion Variables
    }
}
