﻿using System;
using System.Text;
using De_CryptDLL;
using System.Data;
using System.IO;
using System.IO.Compression;
using SisCreWin.BD;
using System.Windows.Forms;

namespace SisCreWin.Modelo
{
    public class clsGeneral
    {
        #region Variables
        private static De_Crypt crypto = new De_Crypt();
        private const string UserDec = "be5d512677858999b0be0253bbf4848343036b9a9d6b2ea43446de08b975f78fd8f15419ed616af1b29526f2102c4dae365223bbca35cbedda543c1ea6df7a1dab7a47fa37b34ae9c0b62da753e5bf0219dd44795e27fe22b62ccb7074907efd8c015f165c950ac726570b3acd5c35f4eeae870e4b5ca752d2b46d4fac6f295dc614b12307818ddc7bbf4b279409b7ff9f2d552b610bee6ce0806aab9052cb53d3225bb05bca62c33f67b82e6b51f63b8e7ec6bcd61206fd0e5dd7db96d7f58961b8b15019f11819d385894871e97fdd56577acb040a035a91d1ae9887b1f05d542fe3f5b729809e347df04b6e9463906e871c24e3c92af55cca71d3d54983de48796902bb299812c0a9c35741685712c14e315496e4562fa91039d8057cf89011be687c0b227277f225c605cdff55b34103367e4268e69ae2361bac0e7205bad6f36b238fbb42972d66eb56c4b03aeda92068d499e9f5704a9f1d733f840f72175fe56cec245d3afb5b54c8e4346bde5ae7da63cd53b7bcda72616f84e640cebb660de28c9582a98df0d651873ea833f2cecb6675eb2a1e64fd9ac287556b1adf5f5683ab87e15dd3dc633a5d34b6c1ca8a24fa695de595851834ed6b82e7a6cf8b51e5b6369f5ca2ff5c3fabefd4c965f9aa86fbf1a9cfce0ff2e254965d72c71dc2bf4ecfed48572cbe54d2f2be6281f16c375006d881d5b5ed179a870127";
        //public static string RutaReportes = System.Web.Configuration.WebConfigurationManager.AppSettings["RutaReportes"].ToString();
        public static string Produccion = crypto.Desencriptar(System.Configuration.ConfigurationManager.AppSettings["Produccion"].ToString(), "ODES", true);
        public static string BDCnx = crypto.Desencriptar(System.Configuration.ConfigurationManager.ConnectionStrings["Sistema"].ConnectionString, "ODES", true);

        public static DataTable ddlSiNo
        {
            get
            {
                DataTable ddl = new DataTable();
                DataRow dr;

                ddl.Columns.Add("Valor");
                ddl.Columns.Add("Descripcion");
                dr = ddl.NewRow();
                dr[0] = 1;
                dr[1] = "S";
                ddl.Rows.Add(dr);
                dr = ddl.NewRow();
                dr[0] = 0;
                dr[1] = "N";
                ddl.Rows.Add(dr);

                return ddl;
            }
        }

        public static DataTable ddlActLiq
        {
            get
            {
                DataTable ddl = new DataTable();
                DataRow dr;

                ddl.Columns.Add("Valor");
                ddl.Columns.Add("Descripcion");
                dr = ddl.NewRow();
                dr[0] = "ACTIVO";
                dr[1] = "Activo";
                ddl.Rows.Add(dr);
                dr = ddl.NewRow();
                dr[0] = "LIQUIDADO";
                dr[1] = "Liquidado";
                ddl.Rows.Add(dr);

                return ddl;
            }
        }

        public static DataTable ddlAdminCred
        {
            get
            {
                DataTable ddl = new DataTable();
                DataRow dr;

                ddl.Columns.Add("Valor");
                ddl.Columns.Add("Descripcion");
                dr = ddl.NewRow();
                dr[0] = "FUERA DE BALANCE";
                dr[1] = "Fuera de balance";
                ddl.Rows.Add(dr);
                dr = ddl.NewRow();
                dr[0] = "BALANCE";
                dr[1] = "Balance";
                ddl.Rows.Add(dr);

                return ddl;
            }
        }
        #endregion Variables
        #region Enumeraciones
        public enum TiposMensaje
        {
            Advertencia,
            Error,
            Informacion
        }
        #endregion Enumeraciones
        #region Metodos
        public static string UserDecoded(string Usuario)
        {
            De_Crypt cr = new De_Crypt();

            return cr.Desencriptar(Usuario, UserDec + DateTime.Now.ToString("ddMMyyyy"), true);
        }

        public static string Codificar(string Texto)
        {
            De_Crypt cr = new De_Crypt();

            return cr.Encriptar(Texto, UserDec + DateTime.Now.ToString("ddMMyyyy"), true);
        }

        public static DateTime ObtieneFecha(string Fecha)
        {
            DateTime f;

            if (DateTime.TryParseExact(Fecha, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out f))
                return f;
            else
                return new DateTime(1900, 1, 1);
        }

        public static bool SistemaEnMantenimiento(int Usr_Id)
        {
            ResultadoStored_Int Resultado = new ResultadoStored_Int();

            Resultado = clsBD.Sistema_C_Mantenimiento(Usr_Id);

            if (Resultado.Resultado == 0)
                return false;
            else
                return true;
        }

        public static RespuestaAcceso ValidarAccesoUsuario(int Usr_Id, int Mod_Id)
        {
            RespuestaAcceso Respuesta = new RespuestaAcceso();

            if (Usr_Id > 0)
            {
                ResultadoStored_Int Resultado = new ResultadoStored_Int();

                Resultado = clsBD.Sistema_C_Mantenimiento(Usr_Id);

                if (!Resultado.HayError)
                {
                    if (Resultado.Resultado == 0)
                    {
                        Resultado = new ResultadoStored_Int();
                        Resultado = clsBD.Usuarios_C_AccesoModulo(Usr_Id, Mod_Id);

                        if (!Resultado.HayError)
                        {
                            if (Resultado.Resultado > 0)
                            {
                                ResultadoStored_Str Resultado2 = new BD.ResultadoStored_Str();

                                Resultado2 = clsBD.Modulos_C_Activo(Mod_Id);

                                if (!Resultado2.HayError)
                                {
                                    if(Resultado2.Resultado == "S")
                                    {
                                        Respuesta.Permitido = true;
                                        Respuesta.Mensaje = "";
                                        Respuesta.Titulo = "";
                                        Respuesta.MsgIcon = MessageBoxIcon.None;
                                    }
                                    else
                                    {
                                        Respuesta.Permitido = false;
                                        Respuesta.Mensaje = "Tiene permiso para acceder a este módulo, sin embargo, no se encuentra disponible";
                                        Respuesta.Titulo = "Acceso denegado";
                                        Respuesta.MsgIcon = MessageBoxIcon.Stop;
                                    }
                                }
                                else
                                {
                                    Respuesta.Permitido = false;
                                    Respuesta.Mensaje = Resultado.Error;
                                    Respuesta.Titulo = "Error al validar disponibilidad del módulo";
                                    Respuesta.MsgIcon = MessageBoxIcon.Error;
                                }
                            }
                            else
                            {
                                Respuesta.Permitido = false;
                                Respuesta.Mensaje = "No tiene permiso para acceder a este módulo";
                                Respuesta.Titulo = "Acceso denegado";
                                Respuesta.MsgIcon = MessageBoxIcon.Stop;
                            }
                        }
                        else
                        {
                            Respuesta.Permitido = false;
                            Respuesta.Mensaje = Resultado.Error;
                            Respuesta.Titulo = "Error al validar acceso al módulo";
                            Respuesta.MsgIcon = MessageBoxIcon.Error;
                        }
                    }
                    else
                    {
                        Respuesta.Permitido = false;
                        Respuesta.Mensaje = "El sistema se encuentra en mantenimiento";
                        Respuesta.Titulo = "Acceso denegado";
                        Respuesta.MsgIcon = MessageBoxIcon.Information;
                    }
                }
                else
                {
                    Respuesta.Permitido = false;
                    Respuesta.Mensaje = Resultado.Error;
                    Respuesta.Titulo = "Error al validar mantenimiento";
                    Respuesta.MsgIcon = MessageBoxIcon.Error;
                }
            }
            else
            {
                Respuesta.Permitido = false;
                Respuesta.Mensaje = "No se encontró el Id de su usuario";
                Respuesta.Titulo = "Error al verificar usuario";
                Respuesta.MsgIcon = MessageBoxIcon.Stop;
            }

            return Respuesta;
        }

        public static string GeneraNombreArchivoRnd(string Prefijo, string Extension)
        {
            Random rnd = new Random();
            string Nombre = "";

            if (string.IsNullOrEmpty(Prefijo))
                Prefijo = "";

            if (string.IsNullOrEmpty(Extension))
                Extension = "";

            Extension = Extension.Replace(".", "");

            Nombre = Prefijo + DateTime.Now.ToString("yyyyMMddHHmmss") + rnd.Next(1000).ToString().PadLeft(4, Convert.ToChar("0")) + "." + Extension;

            return Nombre;
        }

        //Compresion
        public static void CopyTo(Stream src, Stream dest)
        {
            byte[] bytes = new byte[4096];

            int cnt;

            while ((cnt = src.Read(bytes, 0, bytes.Length)) != 0)
            {
                dest.Write(bytes, 0, cnt);
            }
        }

        public static byte[] Zip(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);

            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(mso, CompressionMode.Compress))
                {
                    //msi.CopyTo(gs);
                    CopyTo(msi, gs);
                }

                return mso.ToArray();
            }
        }

        public static string Unzip(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                {
                    //gs.CopyTo(mso);
                    CopyTo(gs, mso);
                }

                return Encoding.UTF8.GetString(mso.ToArray());
            }
        }
        //!Compresion

        #endregion Metodos
        #region Modelos
        #region Sistema
        public struct CatModulos
        {
            public int Mod_Id;
            public string Mod_Nombre;
            public string Mod_Descripcion;
            public bool Mod_Activo;

            public CatModulos(int vMod_Id, string vMod_Nombre, string vMod_Descripcion, bool vMod_Activo)
            {
                Mod_Id = vMod_Id;
                Mod_Nombre = vMod_Nombre;
                Mod_Descripcion = vMod_Descripcion;
                Mod_Activo = vMod_Activo;
            }
        }

        public struct BitacoraMovimientosSistema
        {
            public Int64 Bit_Id;
            public int Usr_Id;
            public DateTime? Bit_Fecha;
            public string Bit_Procedimiento;
            public byte[] Bit_DatosPrevios;

            public BitacoraMovimientosSistema(int vUsr_Id, string vBit_Procedimiento, Int64 vBit_Id = 0, DateTime? vBit_Fecha = null, byte[] vBit_DatosPrevios = null)
            {
                Bit_Id = vBit_Id;
                Usr_Id = vUsr_Id;
                Bit_Procedimiento = vBit_Procedimiento;
                Bit_Fecha = vBit_Fecha;
                Bit_DatosPrevios = vBit_DatosPrevios;
            }
        }

        public struct Usuario
        {
            public int Usr_Id;
            public string Usr_Login;
            public string Usr_Nombre;
            public bool Usr_Activo;

            public Usuario(string vUsr_Login, string vUsr_Nombre, bool vUsr_Activo, int vUsr_Id = 0)
            {
                Usr_Login = vUsr_Login;
                Usr_Nombre = vUsr_Nombre;
                Usr_Activo = vUsr_Activo;
                Usr_Id = vUsr_Id;
            }
        }

        public struct UsuarioPermiso
        {
            public int Usr_Id;
            public int Mod_Id;
            public bool Mod_Autorizado;

            public UsuarioPermiso(int vUsr_Id, int vMod_Id, bool vMod_Autorizado)
            {
                Usr_Id = vUsr_Id;
                Mod_Id = vMod_Id;
                Mod_Autorizado = vMod_Autorizado;
            }
        }

        public struct RespuestaAcceso
        {
            public string Mensaje;
            public string Titulo;
            public MessageBoxIcon MsgIcon;
            public bool Permitido;

            public RespuestaAcceso(string vMensaje, string vTitulo, MessageBoxIcon vMsgIcon, bool vPermitido)
            {
                Mensaje = vMensaje;
                Titulo = vTitulo;
                MsgIcon = vMsgIcon;
                Permitido = vPermitido;
            }
        }
        #endregion Sistema
        #region Negocio
        public struct Promotor
        {
            public int Prom_Id;
            public string Prom_Nombre;
            public bool Prom_Activo;

            public Promotor(string vProm_Nombre, bool vProm_Activo, int vProm_Id = 0)
            {
                Prom_Nombre = vProm_Nombre;
                Prom_Activo = vProm_Activo;
                Prom_Id = vProm_Id;
            }
        }

        public struct Proyecto
        {
            public int Proy_Id;
            public int Prom_Id;
            public string Proy_Nombre;
            public int Proy_Numero_Viviendas;
            public DateTime Proy_Fecha_Apertura;
            public DateTime Proy_Fecha_Vencimiento;
            public decimal Proy_Monto_Credito_Pesos;
            public decimal Proy_Monto_Desembolsado_Pesos;
            public string Proy_Tipo_Amortizacion;
            public string Proy_Administracion;
            public decimal Proy_Spread;
            public bool Proy_Activo;

            public Proyecto(int vProm_Id, string vProy_Nombre, int vProy_Numero_Viviendas, DateTime vProy_Fecha_Apertura,
                DateTime vProy_Fecha_Vencimiento, decimal vProy_Monto_Credito_Pesos, decimal vProy_Monto_Desembolsado_Pesos,
                string vProy_Tipo_Amortizacion, string vProy_Administracion, decimal vProy_Spread, bool vProy_Activo, int vProy_Id = 0)
            {
                Prom_Id = vProm_Id;
                Proy_Nombre = vProy_Nombre;
                Proy_Numero_Viviendas = vProy_Numero_Viviendas;
                Proy_Fecha_Apertura = vProy_Fecha_Apertura;
                Proy_Fecha_Vencimiento = vProy_Fecha_Vencimiento;
                Proy_Monto_Credito_Pesos = vProy_Monto_Credito_Pesos;
                Proy_Monto_Desembolsado_Pesos = vProy_Monto_Desembolsado_Pesos;
                Proy_Tipo_Amortizacion = vProy_Tipo_Amortizacion;
                Proy_Administracion = vProy_Administracion;
                Proy_Spread = vProy_Spread;
                Proy_Activo = vProy_Activo;
                Proy_Id = vProy_Id;
            }
        }

        public struct BuroHistoricoPuentes
        {
            public int BHP_Id;
            public int Usr_Id;
            public DateTime? BHP_Fecha;
            public byte[] BHP_Documento;
            public int BCP_Identificador_Proceso;

            public BuroHistoricoPuentes(int vUsr_Id, int vBCP_Identificador_Proceso, int vBHP_Id = 0, DateTime? vBHP_Fecha = null, byte[] vBHP_Documento = null)
            {
                BHP_Id = vBHP_Id;
                Usr_Id = vUsr_Id;
                BHP_Fecha = vBHP_Fecha;
                BHP_Documento = vBHP_Documento;
                BCP_Identificador_Proceso = vBCP_Identificador_Proceso;
            }
        }

        public struct BuroHistoricoIndividuales
        {
            public int BHI_Id;
            public int Usr_Id;
            public DateTime? BHI_Fecha;
            public byte[] BHI_Documento;

            public BuroHistoricoIndividuales(int vUsr_Id, int vBHI_Id = 0, DateTime? vBHI_Fecha = null, byte[] vBHI_Documento = null)
            {
                BHI_Id = vBHI_Id;
                Usr_Id = vUsr_Id;
                BHI_Fecha = vBHI_Fecha;
                BHI_Documento = vBHI_Documento;
            }
        }

        public struct TIIE
        {
            public int TIIE_Mes;
            public int TIIE_Anno;
            public decimal TIIE_Valor;

            public TIIE(int vTIIE_Mes, int vTIIE_Anno, decimal vTIIE_Valor)
            {
                TIIE_Mes = vTIIE_Mes;
                TIIE_Anno = vTIIE_Anno;
                TIIE_Valor = vTIIE_Valor;
            }
        }

        public struct OrigenCreditosPuente
        {
            public int OCP_Prestamo;
            public string OCP_Origen_Prestamo;
            public int OCP_Id_Proyecto;
            public int OCP_Numero_Viviendas;
            public DateTime OCP_Fecha_Apertura;
            public DateTime OCP_Fecha_Vencimiento;
            public string OCP_Estado;

            public OrigenCreditosPuente(int vOCP_Prestamo, string vOCP_Origen_Prestamo, int vOCP_Id_Proyecto, int vOCP_Numero_Viviendas, DateTime vOCP_Fecha_Apertura, DateTime vOCP_Fecha_Vencimiento, string vOCP_Estado)
            {
                OCP_Prestamo = vOCP_Prestamo;
                OCP_Origen_Prestamo = vOCP_Origen_Prestamo;
                OCP_Id_Proyecto = vOCP_Id_Proyecto;
                OCP_Numero_Viviendas = vOCP_Numero_Viviendas;
                OCP_Fecha_Apertura = vOCP_Fecha_Apertura;
                OCP_Fecha_Vencimiento = vOCP_Fecha_Vencimiento;
                OCP_Estado = vOCP_Estado;
            }
        }

        public struct PuentesPagos
        {
            public int PHP_Id;
            public int Usr_Id;
            public DateTime? PHP_Fecha;
            public DateTime? PHP_FechaCierre;
            public DateTime PHP_FechaPago;
            public int PHP_NumeroPrestamo;
            public decimal PHP_PagoCapital;
            public decimal PHP_InteresCubierto;
            public decimal PHP_InteresCapVenc;
            public decimal PHP_ComiAplicacion;
            public decimal PHP_PagoIntMoratorios;

            public PuentesPagos(int vUsr_Id, DateTime vPHP_FechaPago, int vPHP_NumeroPrestamo, decimal vPHP_PagoCapital,
                decimal vPHP_InteresCubierto, decimal vPHP_InteresCapVenc, decimal vPHP_ComiAplicacion, decimal vPHP_PagoIntMoratorios,
                DateTime? vPHP_FechaCierre = null, DateTime? vPHP_Fecha = null, int vPHP_Id = 0)
            {
                PHP_Id = vPHP_Id;
                Usr_Id = vUsr_Id;
                PHP_Fecha = vPHP_Fecha;
                PHP_FechaCierre = vPHP_FechaCierre;
                PHP_FechaPago = vPHP_FechaPago;
                PHP_NumeroPrestamo = vPHP_NumeroPrestamo;
                PHP_PagoCapital = vPHP_PagoCapital;
                PHP_InteresCubierto = vPHP_InteresCubierto;
                PHP_InteresCapVenc = vPHP_InteresCapVenc;
                PHP_ComiAplicacion = vPHP_ComiAplicacion;
                PHP_PagoIntMoratorios = vPHP_PagoIntMoratorios;
            }
        }
        #endregion Negocio
        #endregion Modelos
    }
}
