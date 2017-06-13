using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SisCreWin.Modelo;
using System.Data.SqlClient;

namespace SisCreWin.BD
{
    public class clsBD
    {
        #region ProcedimientosBase
        public static BaseConectada ObtenerBaseConectada()
        {
            BaseConectada vBase = new BaseConectada(string.Empty, string.Empty);

            try
            {
                if (SisCreWin.Sistema.Global.OverrideCnx == string.Empty)
                    SisCreWin.Sistema.Global.OverrideCnx = clsGeneral.BDCnx;
                
                SqlConnectionStringBuilder cnxDet = new SqlConnectionStringBuilder(SisCreWin.Sistema.Global.OverrideCnx);

                vBase.BaseDatos = cnxDet.InitialCatalog;
                vBase.Detalle = "Servidor: " + cnxDet.DataSource + Environment.NewLine + "Usuario: " + cnxDet.UserID;
            }
            catch (Exception ex){ string s = ex.Message; }

            return vBase;
        }
        private static ResultadoStored_Str EjecutarStored_Str(string Stored, List<SqlParameter> Params, string ColumnaResultado, bool DevolverError = true, int TimeOut = 0)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlConnection cn = null;
            SqlCommand cmd = null;

            try
            {
                cn = new SqlConnection(SisCreWin.Sistema.Global.OverrideCnx);
                cmd = new SqlCommand(Stored.ToString(), cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (Params != null && Params.Count > 0)
                    cmd.Parameters.AddRange(Params.ToArray());

                cn.Open();

                if (TimeOut > 0)
                    cmd.CommandTimeout = TimeOut;

                using (SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (rdr.Read())
                        Resultado.Resultado = rdr.GetString(rdr.GetOrdinal(ColumnaResultado));

                    rdr.Close();
                }

            }
            catch (Exception ex)
            {
                Resultado.HayError = true;
                Resultado.Resultado = string.Empty;

                if (DevolverError)
                    Resultado.Error = "Error: " + ex.Message;
                else
                    Resultado.Error = string.Empty;
            }

            return Resultado;
        }

        private static ResultadoStored_Str EjecutarStored_StrNQ(string Stored, List<SqlParameter> Params, bool DevolverError = true, int TimeOut = 0)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlConnection cn = null;
            SqlCommand cmd = null;

            try
            {
                cn = new SqlConnection(SisCreWin.Sistema.Global.OverrideCnx);
                cmd = new SqlCommand(Stored.ToString(), cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (Params != null && Params.Count > 0)
                    cmd.Parameters.AddRange(Params.ToArray());

                cn.Open();

                if (TimeOut > 0)
                    cmd.CommandTimeout = TimeOut;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Resultado.HayError = true;
                Resultado.Resultado = string.Empty;

                if (DevolverError)
                    Resultado.Error = "Error: " + ex.Message;
                else
                    Resultado.Error = string.Empty;
            }

            return Resultado;
        }

        private static ResultadoStored_DT EjecutarStored_DT(string Stored, List<SqlParameter> Params, bool DevolverError = true, int TimeOut = 0)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable("Resultado"), string.Empty, false);
            SqlConnection cn = null;
            SqlCommand cmd = null;

            try
            {
                cn = new SqlConnection(SisCreWin.Sistema.Global.OverrideCnx);
                cmd = new SqlCommand(Stored.ToString(), cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (Params != null && Params.Count > 0)
                    cmd.Parameters.AddRange(Params.ToArray());

                cn.Open();

                if (TimeOut > 0)
                    cmd.CommandTimeout = TimeOut;

                Resultado.Resultado.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            }
            catch (Exception ex)
            {
                Resultado.HayError = true;
                Resultado.Resultado = new DataTable("Error");

                if (DevolverError)
                    Resultado.Error = "Error: " + ex.Message;
                else
                    Resultado.Error = string.Empty;
            }

            return Resultado;
        }

        private static ResultadoStored_Int EjecutarStored_Int(string Stored, List<SqlParameter> Params, string ColumnaResultado, bool DevolverError = true, int TimeOut = 0)
        {
            ResultadoStored_Int Resultado = new ResultadoStored_Int(0, string.Empty, false);
            SqlConnection cn = null;
            SqlCommand cmd = null;

            try
            {
                cn = new SqlConnection(SisCreWin.Sistema.Global.OverrideCnx);
                cmd = new SqlCommand(Stored.ToString(), cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (Params != null && Params.Count > 0)
                    cmd.Parameters.AddRange(Params.ToArray());

                cn.Open();

                if (TimeOut > 0)
                    cmd.CommandTimeout = TimeOut;

                using (SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (rdr.Read())
                        Resultado.Resultado = rdr.GetInt32(rdr.GetOrdinal(ColumnaResultado));

                    rdr.Close();
                }

            }
            catch (Exception ex)
            {
                Resultado.HayError = true;
                Resultado.Resultado = 0;

                if (DevolverError)
                    Resultado.Error = "Error: " + ex.Message;
                else
                    Resultado.Error = string.Empty;
            }

            return Resultado;
        }

        private static ResultadoStored_Byte EjecutarStored_Byte(string Stored, List<SqlParameter> Params, string ColumnaResultado, bool DevolverError = true, int TimeOut = 0)
        {
            ResultadoStored_Byte Resultado = new ResultadoStored_Byte(null, string.Empty, false);
            SqlConnection cn = null;
            SqlCommand cmd = null;

            try
            {
                cn = new SqlConnection(SisCreWin.Sistema.Global.OverrideCnx);
                cmd = new SqlCommand(Stored.ToString(), cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (Params != null && Params.Count > 0)
                    cmd.Parameters.AddRange(Params.ToArray());

                cn.Open();

                if (TimeOut > 0)
                    cmd.CommandTimeout = TimeOut;

                using (SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (rdr.Read())
                        Resultado.Resultado = (byte[])rdr.GetValue(rdr.GetOrdinal(ColumnaResultado));

                    rdr.Close();
                }

            }
            catch (Exception ex)
            {
                Resultado.HayError = true;
                Resultado.Resultado = null;

                if (DevolverError)
                    Resultado.Error = "Error: " + ex.Message;
                else
                    Resultado.Error = string.Empty;
            }

            return Resultado;
        }

        public static ResultadoExport ExportarExcel(string Stored, List<SqlParameter> Params, bool DevolverError = true, int TimeOut = 0)
        {
            ResultadoExport Resultado = new ResultadoExport(string.Empty, string.Empty, false);
            SqlConnection cn = null;
            SqlCommand cmd = null;
            ExportarExcel exportar = new ExportarExcel();

            try
            {
                cn = new SqlConnection(SisCreWin.Sistema.Global.OverrideCnx);
                cmd = new SqlCommand(Stored.ToString(), cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (Params != null && Params.Count > 0)
                    cmd.Parameters.AddRange(Params.ToArray());

                cn.Open();

                if (TimeOut > 0)
                    cmd.CommandTimeout = TimeOut;
                
                Resultado.Archivo = System.IO.Path.Combine(System.IO.Path.GetTempPath(), exportar.GenerarExcel(cmd.ExecuteReader(CommandBehavior.CloseConnection), System.IO.Path.GetTempPath(), clsGeneral.GeneraNombreArchivoRnd("Rpt_", "xlsx"), 250000));
                //Resultado.Resultado.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            }
            catch (Exception ex)
            {
                Resultado.HayError = true;
                Resultado.Error = ex.Message;
            }

            return Resultado;
        }

        public static ResultadoExport ExportarExcel(DataTable DT, bool DevolverError = true, int TimeOut = 0)
        {
            ResultadoExport Resultado = new ResultadoExport(string.Empty, string.Empty, false);
            ExportarExcel exportar = new ExportarExcel();

            try
            {
                Resultado.Archivo = System.IO.Path.Combine(System.IO.Path.GetTempPath(), exportar.GenerarExcel(DT.CreateDataReader(), System.IO.Path.GetTempPath(), clsGeneral.GeneraNombreArchivoRnd("Rpt_", "xlsx"), 250000));
            }
            catch (Exception ex)
            {
                Resultado.HayError = true;
                Resultado.Error = ex.Message;
            }

            return Resultado;
        }
        #endregion ProcedimientosBase
        #region Sistema
        #region Usuarios
        public static ResultadoStored_Int Usuarios_C_ValidarLogin(string Usuario)
        {
            ResultadoStored_Int Resultado = new ResultadoStored_Int(0, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Usuario", SqlDbType.VarChar);
            param.Value = clsGeneral.UserDecoded(Usuario);
            paramC.Add(param);

            Resultado = EjecutarStored_Int(CatalogoStoreds.Usuarios_C_ValidarLogin, paramC, "Usr_Id");

            return Resultado;
        }

        public static ResultadoStored_Int Usuarios_C_AccesoModulo(int Usr_Id, int Mod_Id)
        {
            ResultadoStored_Int Resultado = new ResultadoStored_Int(0, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Usr_Id", SqlDbType.Int);
            param.Value = Usr_Id;
            paramC.Add(param);
            param = new SqlParameter("@Mod_Id", SqlDbType.Int);
            param.Value = Mod_Id;
            paramC.Add(param);

            Resultado = EjecutarStored_Int(CatalogoStoreds.Usuarios_C_AccesoModulo, paramC, "MensajeBD");

            return Resultado;
        }

        public static ResultadoStored_Int Sistema_C_Mantenimiento(int Usr_Id)
        {
            ResultadoStored_Int Resultado = new ResultadoStored_Int(0, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Usr_Id", SqlDbType.Int);
            param.Value = Usr_Id;
            paramC.Add(param);

            Resultado = EjecutarStored_Int(CatalogoStoreds.Sistema_C_Mantenimiento, paramC, "MensajeBD");

            return Resultado;
        }

        public static ResultadoStored_DT Usuarios_C_Usuarios()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Usuarios_C_Usuarios, null);

            return Resultado;
        }

        public static ResultadoStored_DT Sistema_C_Top10PaginasUsuario(int Usr_Id)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Usr_Id", SqlDbType.Int);
            param.Value = Usr_Id;
            paramC.Add(param);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Sistema_C_Top10PaginasUsuario, paramC);

            return Resultado;
        }

        public static ResultadoStored_Int Usuarios_I_Usuarios(clsGeneral.Usuario Usuario)
        {
            ResultadoStored_Int Resultado = new ResultadoStored_Int(0, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Usr_Login", SqlDbType.VarChar);
            param.Value = Usuario.Usr_Login.Replace("|", "");
            paramC.Add(param);
            param = new SqlParameter("@Usr_Nombre", SqlDbType.VarChar);
            param.Value = Usuario.Usr_Nombre.Replace("|", "");
            paramC.Add(param);
            param = new SqlParameter("@Usr_Activo", SqlDbType.Bit);
            param.Value = Usuario.Usr_Activo;
            paramC.Add(param);

            Resultado = EjecutarStored_Int(CatalogoStoreds.Usuarios_I_Usuarios, paramC, "MensajeBD");

            return Resultado;
        }

        public static ResultadoStored_Str Usuarios_U_Usuarios(clsGeneral.Usuario Usuario)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Usr_Id", SqlDbType.Int);
            param.Value = Usuario.Usr_Id;
            paramC.Add(param);
            param = new SqlParameter("@Usr_Login", SqlDbType.VarChar);
            param.Value = Usuario.Usr_Login.Replace("|", "");
            paramC.Add(param);
            param = new SqlParameter("@Usr_Nombre", SqlDbType.VarChar);
            param.Value = Usuario.Usr_Nombre.Replace("|", "");
            paramC.Add(param);
            param = new SqlParameter("@Usr_Activo", SqlDbType.Bit);
            param.Value = Usuario.Usr_Activo;
            paramC.Add(param);

            Resultado = EjecutarStored_StrNQ(CatalogoStoreds.Usuarios_U_Usuarios, paramC);

            return Resultado;
        }

        public static ResultadoStored_Str Usuarios_C_UsuariosBitacora(int Usr_Id)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Usr_Id", SqlDbType.Int);
            param.Value = Usr_Id;
            paramC.Add(param);

            Resultado = EjecutarStored_Str(CatalogoStoreds.Usuarios_C_UsuariosBitacora, paramC, "ColXML");

            return Resultado;
        }

        public static ResultadoStored_DT Usuarios_C_AutocompleteUsuarios()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Usuarios_C_AutocompleteUsuarios, null);

            return Resultado;
        }

        public static ResultadoStored_DT Usuarios_C_Permisos(int Usr_Id)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Usr_Id", SqlDbType.Int);
            param.Value = Usr_Id;
            paramC.Add(param);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Usuarios_C_Permisos, paramC);

            return Resultado;
        }

        public static ResultadoStored_Str Usuarios_M_Permisos(clsGeneral.UsuarioPermiso Usuario)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Usr_Id", SqlDbType.Int);
            param.Value = Usuario.Usr_Id;
            paramC.Add(param);
            param = new SqlParameter("@Mod_Id", SqlDbType.Int);
            param.Value = Usuario.Mod_Id;
            paramC.Add(param);
            param = new SqlParameter("@Mod_Autorizado", SqlDbType.Bit);
            param.Value = Usuario.Mod_Autorizado;
            paramC.Add(param);

            Resultado = EjecutarStored_StrNQ(CatalogoStoreds.Usuarios_M_Permisos, paramC);

            return Resultado;
        }

        public static ResultadoStored_Str Usuarios_C_PermisosBitacora(clsGeneral.UsuarioPermiso Usuario)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Usr_Id", SqlDbType.Int);
            param.Value = Usuario.Usr_Id;
            paramC.Add(param);
            param = new SqlParameter("@Mod_Id", SqlDbType.Int);
            param.Value = Usuario.Mod_Id;
            paramC.Add(param);

            Resultado = EjecutarStored_Str(CatalogoStoreds.Usuarios_C_PermisosBitacora, paramC, "ColXML");

            return Resultado;
        }
        #endregion Usuarios
        #region Catalogos
        //Modulos
        public static ResultadoStored_DT Catalogos_C_Modulos()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Catalogos_C_Modulos, null);

            return Resultado;
        }

        public static ResultadoStored_DT Catalogos_C_Procedimientos()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Catalogos_C_Procedimientos, null);

            return Resultado;
        }

        public static ResultadoStored_Int Catalogos_I_Modulos(clsGeneral.CatModulos Modulos)
        {
            ResultadoStored_Int Resultado = new ResultadoStored_Int(0, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Mod_Nombre", SqlDbType.VarChar);
            param.Value = Modulos.Mod_Nombre;
            paramC.Add(param);
            param = new SqlParameter("@Mod_Descripcion", SqlDbType.VarChar);
            param.Value = Modulos.Mod_Descripcion;
            paramC.Add(param);
            param = new SqlParameter("@Mod_Formulario", SqlDbType.VarChar);
            param.Value = Modulos.Mod_Formulario;
            paramC.Add(param);
            param = new SqlParameter("@Mod_Multiple", SqlDbType.Bit);
            param.Value = Modulos.Mod_Multiple;
            paramC.Add(param);
            param = new SqlParameter("@Mod_Activo", SqlDbType.Bit);
            param.Value = Modulos.Mod_Activo;
            paramC.Add(param);

            Resultado = EjecutarStored_Int(CatalogoStoreds.Catalogos_I_Modulos, paramC, "MensajeBD");

            return Resultado;
        }

        public static ResultadoStored_Str Catalogos_U_Modulos(clsGeneral.CatModulos Modulos)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Mod_Id", SqlDbType.Int);
            param.Value = Modulos.Mod_Id;
            paramC.Add(param);
            param = new SqlParameter("@Mod_Nombre", SqlDbType.VarChar);
            param.Value = Modulos.Mod_Nombre;
            paramC.Add(param);
            param = new SqlParameter("@Mod_Descripcion", SqlDbType.VarChar);
            param.Value = Modulos.Mod_Descripcion;
            paramC.Add(param);
            param = new SqlParameter("@Mod_Formulario", SqlDbType.VarChar);
            param.Value = Modulos.Mod_Formulario;
            paramC.Add(param);
            param = new SqlParameter("@Mod_Multiple", SqlDbType.Bit);
            param.Value = Modulos.Mod_Multiple;
            paramC.Add(param);
            param = new SqlParameter("@Mod_Activo", SqlDbType.Bit);
            param.Value = Modulos.Mod_Activo;
            paramC.Add(param);

            Resultado = EjecutarStored_StrNQ(CatalogoStoreds.Catalogos_U_Modulos, paramC);

            return Resultado;
        }

        public static ResultadoStored_Str Catalogos_C_ModulosBitacora(int Mod_Id)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Mod_Id", SqlDbType.Int);
            param.Value = Mod_Id;
            paramC.Add(param);

            Resultado = EjecutarStored_Str(CatalogoStoreds.Catalogos_C_ModulosBitacora, paramC, "ColXML");

            return Resultado;
        }

        public static ResultadoStored_Str Modulos_C_Activo(int Mod_Id)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Mod_Id", SqlDbType.Int);
            param.Value = Mod_Id;
            paramC.Add(param);

            Resultado = EjecutarStored_Str(CatalogoStoreds.Modulos_C_Activo, paramC, "Mod_Activo");

            return Resultado;
        }

        public static ResultadoStored_DT Catalogos_C_DatosModulo(int Mod_Id)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Mod_Id", SqlDbType.Int);
            param.Value = Mod_Id;
            paramC.Add(param);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Catalogos_C_DatosModulo, paramC);

            return Resultado;
        }
        //!Modulos
        #endregion Catalogos
        #region Bitacoras
        public static ResultadoStored_Str Bitacoras_I_MovimientosSistema(clsGeneral.BitacoraMovimientosSistema Bitacora)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Usr_Id", SqlDbType.Int);
            param.Value = Bitacora.Usr_Id;
            paramC.Add(param);
            param = new SqlParameter("@Bit_Procedimiento", SqlDbType.VarChar);
            param.Value = Bitacora.Bit_Procedimiento;
            paramC.Add(param);
            param = new SqlParameter("@Bit_DatosPrevios", SqlDbType.VarBinary);
            param.Value = Bitacora.Bit_DatosPrevios;
            paramC.Add(param);

            Resultado = EjecutarStored_StrNQ(CatalogoStoreds.Bitacoras_I_MovimientosSistema, paramC);

            return Resultado;
        }

        public static ResultadoStored_DT Bitacoras_C_MovimientosSistema(DateTime? Bit_Fecha_Ini, DateTime? Bit_Fecha_Fin, string Bit_Procedimiento, int? Usr_Id, int TopSel = 100)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Bit_Fecha_Ini", SqlDbType.DateTime);
            param.Value = Bit_Fecha_Ini;
            paramC.Add(param);
            param = new SqlParameter("@Bit_Fecha_Fin", SqlDbType.DateTime);
            param.Value = Bit_Fecha_Fin;
            paramC.Add(param);
            param = new SqlParameter("@Bit_Procedimiento", SqlDbType.VarChar);
            param.Value = Bit_Procedimiento;
            paramC.Add(param);
            param = new SqlParameter("@Usr_Id", SqlDbType.Int);
            param.Value = Usr_Id;
            paramC.Add(param);
            param = new SqlParameter("@TopSel", SqlDbType.Int);
            param.Value = TopSel;
            paramC.Add(param);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Bitacoras_C_MovimientosSistema, paramC);

            return Resultado;
        }

        public static ResultadoExport Bitacoras_C_MovimientosSistema_Exp(DateTime? Bit_Fecha_Ini, DateTime? Bit_Fecha_Fin, string Bit_Procedimiento, int? Usr_Id, int TopSel = 100)
        {
            ResultadoExport Resultado = new ResultadoExport();
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Bit_Fecha_Ini", SqlDbType.DateTime);
            param.Value = Bit_Fecha_Ini;
            paramC.Add(param);
            param = new SqlParameter("@Bit_Fecha_Fin", SqlDbType.DateTime);
            param.Value = Bit_Fecha_Fin;
            paramC.Add(param);
            param = new SqlParameter("@Bit_Procedimiento", SqlDbType.VarChar);
            param.Value = Bit_Procedimiento;
            paramC.Add(param);
            param = new SqlParameter("@Usr_Id", SqlDbType.Int);
            param.Value = Usr_Id;
            paramC.Add(param);
            param = new SqlParameter("@TopSel", SqlDbType.Int);
            param.Value = TopSel;
            paramC.Add(param);

            Resultado = ExportarExcel(CatalogoStoreds.Bitacoras_C_MovimientosSistema, paramC);

            return Resultado;
        }

        public static ResultadoStored_Byte Bitacoras_C_MovimientosDatos(Int64 Bit_Id)
        {
            ResultadoStored_Byte Resultado = new ResultadoStored_Byte(null, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Bit_Id", SqlDbType.BigInt);
            param.Value = Bit_Id;
            paramC.Add(param);

            Resultado = EjecutarStored_Byte(CatalogoStoreds.Bitacoras_C_MovimientosDatos, paramC, "Bit_DatosPrevios");

            return Resultado;
        }
        #endregion Bitacoras
        #region General
        public static ResultadoStored_DT Sistema_C_ParametrosMantenimiento()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Sistema_C_ParametrosMantenimiento, null);

            return Resultado;
        }

        public static ResultadoStored_Str Sistema_U_ParametrosMantenimiento(string SisMant, string UsuMant)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@SisMant", SqlDbType.VarChar);
            param.Value = SisMant;
            paramC.Add(param);
            param = new SqlParameter("@UsuMant", SqlDbType.VarChar);
            param.Value = UsuMant;
            paramC.Add(param);

            Resultado = EjecutarStored_StrNQ(CatalogoStoreds.Sistema_U_ParametrosMantenimiento, paramC);

            return Resultado;
        }

        public static ResultadoStored_Str Sistema_U_ParametroVersion(string Version)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Version", SqlDbType.VarChar);
            param.Value = Version;
            paramC.Add(param);

            Resultado = EjecutarStored_StrNQ(CatalogoStoreds.Sistema_U_ParametroVersion, paramC);

            return Resultado;
        }

        public static ResultadoStored_Str Sistema_C_ParametroVersion()
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);

            Resultado = EjecutarStored_Str(CatalogoStoreds.Sistema_C_ParametroVersion, null, "Version");

            return Resultado;
        }
        #endregion General
        #endregion Sistema
        #region Negocio
        #region General
        public static DatosStatusBar Negocio_C_FechasDelSistema(ResultadoStored_DT Resultado)
        {
            DatosStatusBar sb = new DatosStatusBar();
            sb.Titulo = "Fechas del sistema";

            if (!Resultado.HayError)
            {
                sb.Detalle = string.Empty;
                sb.Detalle += Resultado.Resultado.Columns[0].ColumnName + ": " + Resultado.Resultado.Rows[0][0].ToString() + Environment.NewLine;
                sb.Detalle += Resultado.Resultado.Columns[1].ColumnName + ": " + Resultado.Resultado.Rows[0][1].ToString() + Environment.NewLine;
            }
            else
            {
                sb.Detalle = Resultado.Error;
            }

            return sb;
        }

        public static ResultadoStored_DT Negocio_C_DatosDelSistema()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Negocio_C_DatosDelSistema, null);

            return Resultado;
        }
        #endregion General
        #region Catalogos
        //Promotores
        public static ResultadoStored_DT Catalogos_C_Promotores(bool ObtenerTodos = false)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@ObtenerTodos", SqlDbType.Bit);
            param.Value = ObtenerTodos;
            paramC.Add(param);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Catalogos_C_Promotores, paramC);

            return Resultado;
        }

        public static ResultadoStored_Int Catalogos_I_Promotores(clsGeneral.Promotor Promotor)
        {
            ResultadoStored_Int Resultado = new ResultadoStored_Int(0, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Prom_Nombre", SqlDbType.VarChar);
            param.Value = Promotor.Prom_Nombre;
            paramC.Add(param);
            param = new SqlParameter("@Prom_Activo", SqlDbType.Bit);
            param.Value = Promotor.Prom_Activo;
            paramC.Add(param);

            Resultado = EjecutarStored_Int(CatalogoStoreds.Catalogos_I_Promotores, paramC, "MensajeBD");

            return Resultado;
        }

        public static ResultadoStored_Str Catalogos_U_Promotores(clsGeneral.Promotor Promotor)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Prom_Id", SqlDbType.Int);
            param.Value = Promotor.Prom_Id;
            paramC.Add(param);
            param = new SqlParameter("@Prom_Nombre", SqlDbType.VarChar);
            param.Value = Promotor.Prom_Nombre;
            paramC.Add(param);
            param = new SqlParameter("@Prom_Activo", SqlDbType.Bit);
            param.Value = Promotor.Prom_Activo;
            paramC.Add(param);

            Resultado = EjecutarStored_StrNQ(CatalogoStoreds.Catalogos_U_Promotores, paramC);

            return Resultado;
        }

        public static ResultadoStored_Str Catalogos_C_PromotoresBitacora(int Prom_Id)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Prom_Id", SqlDbType.Int);
            param.Value = Prom_Id;
            paramC.Add(param);

            Resultado = EjecutarStored_Str(CatalogoStoreds.Catalogos_C_PromotoresBitacora, paramC, "ColXML");

            return Resultado;
        }
        //!Promotores
        //Proyectos
        public static ResultadoStored_DT Catalogos_C_Proyectos(bool ObtenerTodos = false)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@ObtenerTodos", SqlDbType.Bit);
            param.Value = ObtenerTodos;
            paramC.Add(param);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Catalogos_C_Proyectos, paramC);

            return Resultado;
        }

        public static ResultadoStored_Int Catalogos_I_Proyectos(clsGeneral.Proyecto Proyecto)
        {
            ResultadoStored_Int Resultado = new ResultadoStored_Int(0, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();


            param = new SqlParameter("@Prom_Id", SqlDbType.Int);
            param.Value = Proyecto.Prom_Id;
            paramC.Add(param);
            param = new SqlParameter("@Proy_Nombre", SqlDbType.NVarChar);
            param.Value = Proyecto.Proy_Nombre;
            paramC.Add(param);
            param = new SqlParameter("@Proy_Numero_Viviendas", SqlDbType.Int);
            param.Value = Proyecto.Proy_Numero_Viviendas;
            paramC.Add(param);
            param = new SqlParameter("@Proy_Fecha_Apertura", SqlDbType.DateTime);
            param.Value = Proyecto.Proy_Fecha_Apertura;
            paramC.Add(param);
            param = new SqlParameter("@Proy_Fecha_Vencimiento", SqlDbType.DateTime);
            param.Value = Proyecto.Proy_Fecha_Vencimiento;
            paramC.Add(param);
            param = new SqlParameter("@Proy_Monto_Credito_Pesos", SqlDbType.Decimal);
            param.Value = Proyecto.Proy_Monto_Credito_Pesos;
            paramC.Add(param);
            param = new SqlParameter("@Proy_Monto_Desembolsado_Pesos", SqlDbType.Decimal);
            param.Value = Proyecto.Proy_Monto_Desembolsado_Pesos;
            paramC.Add(param);
            param = new SqlParameter("@Proy_Tipo_Amortizacion", SqlDbType.NVarChar);
            param.Value = Proyecto.Proy_Tipo_Amortizacion;
            paramC.Add(param);
            param = new SqlParameter("@Proy_Administracion", SqlDbType.NVarChar);
            param.Value = Proyecto.Proy_Administracion;
            paramC.Add(param);
            param = new SqlParameter("@Proy_Spread", SqlDbType.Decimal);
            param.Value = Proyecto.Proy_Spread;
            paramC.Add(param);
            param = new SqlParameter("@Proy_Activo", SqlDbType.Decimal);
            param.Value = Proyecto.Proy_Activo;
            paramC.Add(param);

            Resultado = EjecutarStored_Int(CatalogoStoreds.Catalogos_I_Proyectos, paramC, "MensajeBD");

            return Resultado;
        }

        public static ResultadoStored_Str Catalogos_U_Proyectos(clsGeneral.Proyecto Proyecto)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Proy_Id", SqlDbType.Int);
            param.Value = Proyecto.Proy_Id;
            paramC.Add(param);
            param = new SqlParameter("@Prom_Id", SqlDbType.Int);
            param.Value = Proyecto.Prom_Id;
            paramC.Add(param);
            param = new SqlParameter("@Proy_Nombre", SqlDbType.NVarChar);
            param.Value = Proyecto.Proy_Nombre;
            paramC.Add(param);
            param = new SqlParameter("@Proy_Numero_Viviendas", SqlDbType.Int);
            param.Value = Proyecto.Proy_Numero_Viviendas;
            paramC.Add(param);
            param = new SqlParameter("@Proy_Fecha_Apertura", SqlDbType.DateTime);
            param.Value = Proyecto.Proy_Fecha_Apertura;
            paramC.Add(param);
            param = new SqlParameter("@Proy_Fecha_Vencimiento", SqlDbType.DateTime);
            param.Value = Proyecto.Proy_Fecha_Vencimiento;
            paramC.Add(param);
            param = new SqlParameter("@Proy_Monto_Credito_Pesos", SqlDbType.Decimal);
            param.Value = Proyecto.Proy_Monto_Credito_Pesos;
            paramC.Add(param);
            param = new SqlParameter("@Proy_Monto_Desembolsado_Pesos", SqlDbType.Decimal);
            param.Value = Proyecto.Proy_Monto_Desembolsado_Pesos;
            paramC.Add(param);
            param = new SqlParameter("@Proy_Tipo_Amortizacion", SqlDbType.NVarChar);
            param.Value = Proyecto.Proy_Tipo_Amortizacion;
            paramC.Add(param);
            param = new SqlParameter("@Proy_Administracion", SqlDbType.NVarChar);
            param.Value = Proyecto.Proy_Administracion;
            paramC.Add(param);
            param = new SqlParameter("@Proy_Spread", SqlDbType.Decimal);
            param.Value = Proyecto.Proy_Spread;
            paramC.Add(param);
            param = new SqlParameter("@Proy_Activo", SqlDbType.Bit);
            param.Value = Proyecto.Proy_Activo;
            paramC.Add(param);

            Resultado = EjecutarStored_StrNQ(CatalogoStoreds.Catalogos_U_Proyectos, paramC);

            return Resultado;
        }

        public static ResultadoStored_Str Catalogos_C_ProyectosBitacora(int Proy_Id)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Proy_Id", SqlDbType.Int);
            param.Value = Proy_Id;
            paramC.Add(param);

            Resultado = EjecutarStored_Str(CatalogoStoreds.Catalogos_C_ProyectosBitacora, paramC, "ColXML");

            return Resultado;
        }

        public static ResultadoStored_DT Catalogos_C_ViviendasEstados(bool ObtenerTodos = false)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Catalogos_C_ViviendasEstados, null);

            return Resultado;
        }

        public static ResultadoStored_DT Catalogos_C_BuscarVivienda(int Proy_Id, int PViv_Credito, string PViv_CUV, string PViv_Ubicacion, string PViv_Estatus)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Proy_Id", SqlDbType.Int);
            param.Value = Proy_Id;
            paramC.Add(param);
            param = new SqlParameter("@PViv_Credito", SqlDbType.Int);
            param.Value = PViv_Credito;
            paramC.Add(param);
            param = new SqlParameter("@PViv_CUV", SqlDbType.VarChar);
            param.Value = PViv_CUV;
            paramC.Add(param);
            param = new SqlParameter("@PViv_Ubicacion", SqlDbType.NVarChar);
            param.Value = PViv_Ubicacion;
            paramC.Add(param);
            param = new SqlParameter("@PViv_Estatus", SqlDbType.VarChar);
            param.Value = PViv_Estatus;
            paramC.Add(param);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Catalogos_C_BuscarVivienda, paramC);

            return Resultado;
        }

        public static ResultadoStored_DT Catalogos_C_ViviendasInformacionIndividual(int PViv_Id)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@PViv_Id", SqlDbType.Int);
            param.Value = PViv_Id;
            paramC.Add(param);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Catalogos_C_ViviendasInformacionIndividual, paramC);

            return Resultado;
        }

        public static ResultadoStored_Str Catalogos_U_Viviendas(clsGeneral.Vivienda Vivienda)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@PViv_Id", SqlDbType.Int);
            param.Value = Vivienda.PViv_Id;
            paramC.Add(param);
            param = new SqlParameter("@PViv_Referencia", SqlDbType.VarChar);
            param.Value = Vivienda.PViv_Referencia;
            paramC.Add(param);
            param = new SqlParameter("@PViv_CUV", SqlDbType.VarChar);
            param.Value = Vivienda.PViv_CUV;
            paramC.Add(param);
            param = new SqlParameter("@PViv_Ubicacion", SqlDbType.NVarChar);
            param.Value = Vivienda.PViv_Ubicacion;
            paramC.Add(param);
            param = new SqlParameter("@PViv_MontoCredito", SqlDbType.Decimal);
            param.Value = Vivienda.PViv_MontoCredito;
            paramC.Add(param);
            param = new SqlParameter("@PViv_MontoMinPendiente", SqlDbType.Decimal);
            param.Value = Vivienda.PViv_MontoMinPendiente;
            paramC.Add(param);
            param = new SqlParameter("@PViv_MontoPagoPendiente", SqlDbType.Decimal);
            param.Value = Vivienda.PViv_MontoPagoPendiente;
            paramC.Add(param);
            param = new SqlParameter("@PViv_MontoSaldoPendiente", SqlDbType.Decimal);
            param.Value = Vivienda.PViv_MontoSaldoPendiente;
            paramC.Add(param);
            param = new SqlParameter("@PViv_SaldoInsoluto", SqlDbType.Decimal);
            param.Value = Vivienda.PViv_SaldoInsoluto;
            paramC.Add(param);
            param = new SqlParameter("@PViv_FechaUltimoPago", SqlDbType.DateTime);

            if (Vivienda.PViv_FechaUltimoPago != null)
                param.Value = Vivienda.PViv_FechaUltimoPago;
            else
                param.Value = DBNull.Value;

            paramC.Add(param);
            param = new SqlParameter("@PViv_Estatus", SqlDbType.VarChar);
            param.Value = Vivienda.PViv_Estatus;
            paramC.Add(param);

            Resultado = EjecutarStored_StrNQ(CatalogoStoreds.Catalogos_U_Viviendas, paramC);

            return Resultado;
        }

        public static ResultadoStored_Str Catalogos_C_ViviendasBitacora(int PViv_Id)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@PViv_Id", SqlDbType.Int);
            param.Value = PViv_Id;
            paramC.Add(param);

            Resultado = EjecutarStored_Str(CatalogoStoreds.Catalogos_C_ViviendasBitacora, paramC, "ColXML");

            return Resultado;
        }
        //!Proyectos
        //TIIE
        public static ResultadoStored_DT Catalogos_C_TIIE()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Catalogos_C_TIIE, null);

            return Resultado;
        }

        public static ResultadoStored_Int Catalogos_I_TIIE(clsGeneral.TIIE TIIE)
        {
            ResultadoStored_Int Resultado = new ResultadoStored_Int(0, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@TIIE_Mes", SqlDbType.Int);
            param.Value = TIIE.TIIE_Mes;
            paramC.Add(param);
            param = new SqlParameter("@TIIE_Anno", SqlDbType.Int);
            param.Value = TIIE.TIIE_Anno;
            paramC.Add(param);
            param = new SqlParameter("@TIIE_Valor", SqlDbType.Decimal);
            param.Value = TIIE.TIIE_Valor;
            paramC.Add(param);

            Resultado = EjecutarStored_Int(CatalogoStoreds.Catalogos_I_TIIE, paramC, "MensajeBD");

            return Resultado;
        }

        public static ResultadoStored_Str Catalogos_U_TIIE(clsGeneral.TIIE TIIE)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@TIIE_Mes", SqlDbType.Int);
            param.Value = TIIE.TIIE_Mes;
            paramC.Add(param);
            param = new SqlParameter("@TIIE_Anno", SqlDbType.Int);
            param.Value = TIIE.TIIE_Anno;
            paramC.Add(param);
            param = new SqlParameter("@TIIE_Valor", SqlDbType.Decimal);
            param.Value = TIIE.TIIE_Valor;
            paramC.Add(param);

            Resultado = EjecutarStored_StrNQ(CatalogoStoreds.Catalogos_U_TIIE, paramC);

            return Resultado;
        }

        public static ResultadoStored_Str Catalogos_C_TIIEBitacora(clsGeneral.TIIE TIIE)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@TIIE_Mes", SqlDbType.Int);
            param.Value = TIIE.TIIE_Mes;
            paramC.Add(param);
            param = new SqlParameter("@TIIE_Anno", SqlDbType.Int);
            param.Value = TIIE.TIIE_Anno;
            paramC.Add(param);

            Resultado = EjecutarStored_Str(CatalogoStoreds.Catalogos_C_TIIEBitacora, paramC, "ColXML");

            return Resultado;
        }

        public static ResultadoStored_DT Catalogos_C_ObtenerTIIEMaxima()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Catalogos_C_ObtenerTIIEMaxima, null);

            return Resultado;
        }

        public static ResultadoStored_Int Catalogos_C_TIIEVerificarExistente(clsGeneral.TIIE TIIE)
        {
            ResultadoStored_Int Resultado = new ResultadoStored_Int(0, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@TIIE_Mes", SqlDbType.Int);
            param.Value = TIIE.TIIE_Mes;
            paramC.Add(param);
            param = new SqlParameter("@TIIE_Anno", SqlDbType.Int);
            param.Value = TIIE.TIIE_Anno;
            paramC.Add(param);

            Resultado = EjecutarStored_Int(CatalogoStoreds.Catalogos_C_TIIEVerificarExistente, paramC, "MensajeBD");

            return Resultado;
        }
        //!TIIE
        //Origen_Creditos_Puente
        public static ResultadoStored_DT Catalogos_C_OrigenCreditosPuente()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Catalogos_C_OrigenCreditosPuente, null);

            return Resultado;
        }

        public static ResultadoStored_Int Catalogos_I_OrigenCreditosPuente(clsGeneral.OrigenCreditosPuente OCP)
        {
            ResultadoStored_Int Resultado = new ResultadoStored_Int(0, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@OCP_Prestamo", SqlDbType.Int);
            param.Value = OCP.OCP_Prestamo;
            paramC.Add(param);
            param = new SqlParameter("@OCP_Origen_Prestamo", SqlDbType.NVarChar);
            param.Value = OCP.OCP_Origen_Prestamo;
            paramC.Add(param);
            param = new SqlParameter("@OCP_Id_Proyecto", SqlDbType.Int);
            param.Value = OCP.OCP_Id_Proyecto;
            paramC.Add(param);
            param = new SqlParameter("@OCP_Estado", SqlDbType.NVarChar);
            param.Value = OCP.OCP_Estado;
            paramC.Add(param);
            param = new SqlParameter("@OCP_Dacion_o_Adjudicacion", SqlDbType.NChar);
            param.Value = OCP.OCP_Dacion_o_Adjudicacion;
            paramC.Add(param);
            param = new SqlParameter("@OCP_Fecha_Liquidacion", SqlDbType.DateTime);
            param.Value = OCP.OCP_Fecha_Liquidacion;
            paramC.Add(param);

            Resultado = EjecutarStored_Int(CatalogoStoreds.Catalogos_I_OrigenCreditosPuente, paramC, "MensajeBD");

            return Resultado;
        }

        public static ResultadoStored_Str Catalogos_U_OrigenCreditosPuente(clsGeneral.OrigenCreditosPuente OCP)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@OCP_Prestamo", SqlDbType.Int);
            param.Value = OCP.OCP_Prestamo;
            paramC.Add(param);
            param = new SqlParameter("@OCP_Origen_Prestamo", SqlDbType.NVarChar);
            param.Value = OCP.OCP_Origen_Prestamo;
            paramC.Add(param);
            param = new SqlParameter("@OCP_Id_Proyecto", SqlDbType.Int);
            param.Value = OCP.OCP_Id_Proyecto;
            paramC.Add(param);
            param = new SqlParameter("@OCP_Estado", SqlDbType.NVarChar);
            param.Value = OCP.OCP_Estado;
            paramC.Add(param);
            param = new SqlParameter("@OCP_Dacion_o_Adjudicacion", SqlDbType.NChar);
            param.Value = OCP.OCP_Dacion_o_Adjudicacion;
            paramC.Add(param);
            param = new SqlParameter("@OCP_Fecha_Liquidacion", SqlDbType.DateTime);
            param.Value = (OCP.OCP_Fecha_Liquidacion != null) ? (object)OCP.OCP_Fecha_Liquidacion : DBNull.Value;
            paramC.Add(param);

            Resultado = EjecutarStored_StrNQ(CatalogoStoreds.Catalogos_U_OrigenCreditosPuente, paramC);

            return Resultado;
        }

        public static ResultadoStored_Str Catalogos_C_OrigenCreditosPuenteBitacora(int OCP_Prestamo)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@OCP_Prestamo", SqlDbType.Int);
            param.Value = OCP_Prestamo;
            paramC.Add(param);

            Resultado = EjecutarStored_Str(CatalogoStoreds.Catalogos_C_OrigenCreditosPuenteBitacora, paramC, "ColXML");

            return Resultado;
        }
        //!Origen_Creditos_Puente
        //TiposPagoPuentes
        public static ResultadoStored_DT Catalogos_C_TiposPagoPuentes()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Catalogos_C_TiposPagoPuentes, null);

            return Resultado;
        }

        public static ResultadoStored_Int Catalogos_I_TiposPagoPuentes(clsGeneral.TiposPagoPuentes TP)
        {
            ResultadoStored_Int Resultado = new ResultadoStored_Int(0, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@PTP_Descripcion", SqlDbType.VarChar);
            param.Value = TP.PTP_Descripcion;
            paramC.Add(param);
            param = new SqlParameter("@PTP_Orden", SqlDbType.Int);
            param.Value = TP.PTP_Orden;
            paramC.Add(param);
            param = new SqlParameter("@PTP_Activo", SqlDbType.Bit);
            param.Value = TP.PTP_Activo;
            paramC.Add(param);

            Resultado = EjecutarStored_Int(CatalogoStoreds.Catalogos_I_TiposPagoPuentes, paramC, "MensajeBD");

            return Resultado;
        }

        public static ResultadoStored_Str Catalogos_U_TiposPagoPuentes(clsGeneral.TiposPagoPuentes TP)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@PTP_Id", SqlDbType.Int);
            param.Value = TP.PTP_Id;
            paramC.Add(param);
            param = new SqlParameter("@PTP_Descripcion", SqlDbType.VarChar);
            param.Value = TP.PTP_Descripcion;
            paramC.Add(param);
            param = new SqlParameter("@PTP_Orden", SqlDbType.Int);
            param.Value = TP.PTP_Orden;
            paramC.Add(param);
            param = new SqlParameter("@PTP_Activo", SqlDbType.Bit);
            param.Value = TP.PTP_Activo;
            paramC.Add(param);

            Resultado = EjecutarStored_StrNQ(CatalogoStoreds.Catalogos_U_TiposPagoPuentes, paramC);

            return Resultado;
        }

        public static ResultadoStored_Str Catalogos_C_TiposPagoPuentesBitacora(int PTP_Id)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@PTP_Id", SqlDbType.Int);
            param.Value = PTP_Id;
            paramC.Add(param);

            Resultado = EjecutarStored_Str(CatalogoStoreds.Catalogos_C_TiposPagoPuentesBitacora, paramC, "ColXML");

            return Resultado;
        }
        //!TiposPagoPuentes
        #endregion Catalogos
        #region Buro
        //Puentes
        public static ResultadoStored_DT ReportesBuro_C_CreditosPuentes(string FechaDoc, string Periodo, int PeriodoInt)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@FechaDoc", SqlDbType.VarChar);
            param.Value = FechaDoc;
            paramC.Add(param);
            param = new SqlParameter("@Periodo", SqlDbType.VarChar);
            param.Value = Periodo;
            paramC.Add(param);
            param = new SqlParameter("@PeriodoInt", SqlDbType.Int);
            param.Value = PeriodoInt;
            paramC.Add(param);

            Resultado = EjecutarStored_DT(CatalogoStoreds.ReportesBuro_C_CreditosPuentes, paramC);

            return Resultado;
        }

        public static ResultadoStored_Str Buro_I_HistoricoPuentes(clsGeneral.BuroHistoricoPuentes Buro)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Usr_Id", SqlDbType.Int);
            param.Value = Buro.Usr_Id;
            paramC.Add(param);
            param = new SqlParameter("@BHP_Documento", SqlDbType.VarBinary);
            param.Value = Buro.BHP_Documento;
            paramC.Add(param);
            param = new SqlParameter("@BCP_Identificador_Proceso", SqlDbType.Int);
            param.Value = Buro.BCP_Identificador_Proceso;
            paramC.Add(param);

            Resultado = EjecutarStored_StrNQ(CatalogoStoreds.Buro_I_HistoricoPuentes, paramC);

            return Resultado;
        }

        public static ResultadoStored_DT Buro_C_HistoricoPuentes(DateTime? BHP_Fecha_Ini, DateTime? BHP_Fecha_Fin, int? Usr_Id, int? BCP_Identificador_Proceso = null, int TopSel = 100)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT();
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@BHP_Fecha_Ini", SqlDbType.DateTime);
            param.Value = BHP_Fecha_Ini;
            paramC.Add(param);
            param = new SqlParameter("@BHP_Fecha_Fin", SqlDbType.DateTime);
            param.Value = BHP_Fecha_Fin;
            paramC.Add(param);
            param = new SqlParameter("@Usr_Id", SqlDbType.Int);
            param.Value = Usr_Id;
            paramC.Add(param);
            param = new SqlParameter("@BCP_Identificador_Proceso", SqlDbType.Int);
            param.Value = BCP_Identificador_Proceso;
            paramC.Add(param);
            param = new SqlParameter("@TopSel", SqlDbType.Int);
            param.Value = TopSel;
            paramC.Add(param);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Buro_C_HistoricoPuentes, paramC);

            return Resultado;
        }

        public static ResultadoExport Buro_C_HistoricoPuentes_Exp(DateTime? BHP_Fecha_Ini, DateTime? BHP_Fecha_Fin, int? Usr_Id, int? BCP_Identificador_Proceso = null, int TopSel = 100)
        {
            ResultadoExport Resultado = new ResultadoExport();
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@BHP_Fecha_Ini", SqlDbType.DateTime);
            param.Value = BHP_Fecha_Ini;
            paramC.Add(param);
            param = new SqlParameter("@BHP_Fecha_Fin", SqlDbType.DateTime);
            param.Value = BHP_Fecha_Fin;
            paramC.Add(param);
            param = new SqlParameter("@Usr_Id", SqlDbType.Int);
            param.Value = Usr_Id;
            paramC.Add(param);
            param = new SqlParameter("@BCP_Identificador_Proceso", SqlDbType.Int);
            param.Value = BCP_Identificador_Proceso;
            paramC.Add(param);
            param = new SqlParameter("@TopSel", SqlDbType.Int);
            param.Value = TopSel;
            paramC.Add(param);

            Resultado = ExportarExcel(CatalogoStoreds.Buro_C_HistoricoPuentes, paramC);

            return Resultado;
        }

        public static ResultadoStored_Byte Buro_C_HistoricoPuentesDatos(int BHP_Id)
        {
            ResultadoStored_Byte Resultado = new ResultadoStored_Byte(null, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@BHP_Id", SqlDbType.Int);
            param.Value = BHP_Id;
            paramC.Add(param);

            Resultado = EjecutarStored_Byte(CatalogoStoreds.Buro_C_HistoricoPuentesDatos, paramC, "BHP_Documento");

            return Resultado;
        }

        public static ResultadoStored_DT Buro_C_PeriodosDisponiblesPuentes(bool ObtenerCreados = false)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@ObtenerCreados", SqlDbType.Bit);
            param.Value = ObtenerCreados;
            paramC.Add(param);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Buro_C_PeriodosDisponiblesPuentes, paramC);

            return Resultado;
        }

        public static ResultadoStored_Str Buro_I_SaldosPuente(DateTime FechaProceso, int IdentificadorProceso)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@FechaProceso", SqlDbType.DateTime);
            param.Value = FechaProceso;
            paramC.Add(param);
            param = new SqlParameter("@IdentificadorProceso", SqlDbType.Int);
            param.Value = IdentificadorProceso;
            paramC.Add(param);

            Resultado = EjecutarStored_StrNQ(CatalogoStoreds.Buro_I_SaldosPuente, paramC);

            return Resultado;
        }
        //!Puentes
        //Individuales
        public static ResultadoStored_DT ReportesBuro_C_CreditosIndividuales(string FECHA_DEL_REPORTE)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@FECHA_DEL_REPORTE", SqlDbType.VarChar);
            param.Value = FECHA_DEL_REPORTE;
            paramC.Add(param);

            Resultado = EjecutarStored_DT(CatalogoStoreds.ReportesBuro_C_CreditosIndividuales, paramC);

            return Resultado;
        }

        public static ResultadoStored_Str Buro_I_HistoricoIndividuales(clsGeneral.BuroHistoricoIndividuales Buro)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Usr_Id", SqlDbType.Int);
            param.Value = Buro.Usr_Id;
            paramC.Add(param);
            param = new SqlParameter("@BHI_Documento", SqlDbType.VarBinary);
            param.Value = Buro.BHI_Documento;
            paramC.Add(param);

            Resultado = EjecutarStored_StrNQ(CatalogoStoreds.Buro_I_HistoricoIndividuales, paramC);

            return Resultado;
        }

        public static ResultadoStored_DT Buro_C_HistoricoIndividuales(DateTime? BHI_Fecha_Ini, DateTime? BHI_Fecha_Fin, int? Usr_Id, int TopSel = 100)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT();
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@BHI_Fecha_Ini", SqlDbType.DateTime);
            param.Value = BHI_Fecha_Ini;
            paramC.Add(param);
            param = new SqlParameter("@BHI_Fecha_Fin", SqlDbType.DateTime);
            param.Value = BHI_Fecha_Fin;
            paramC.Add(param);
            param = new SqlParameter("@Usr_Id", SqlDbType.Int);
            param.Value = Usr_Id;
            paramC.Add(param);
            param = new SqlParameter("@TopSel", SqlDbType.Int);
            param.Value = TopSel;
            paramC.Add(param);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Buro_C_HistoricoIndividuales, paramC);

            return Resultado;
        }

        public static ResultadoExport Buro_C_HistoricoIndividuales_Exp(DateTime? BHI_Fecha_Ini, DateTime? BHI_Fecha_Fin, int? Usr_Id, int TopSel = 100)
        {
            ResultadoExport Resultado = new ResultadoExport();
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@BHI_Fecha_Ini", SqlDbType.DateTime);
            param.Value = BHI_Fecha_Ini;
            paramC.Add(param);
            param = new SqlParameter("@BHI_Fecha_Fin", SqlDbType.DateTime);
            param.Value = BHI_Fecha_Fin;
            paramC.Add(param);
            param = new SqlParameter("@Usr_Id", SqlDbType.Int);
            param.Value = Usr_Id;
            paramC.Add(param);
            param = new SqlParameter("@TopSel", SqlDbType.Int);
            param.Value = TopSel;
            paramC.Add(param);

            Resultado = ExportarExcel(CatalogoStoreds.Buro_C_HistoricoIndividuales, paramC);

            return Resultado;
        }

        public static ResultadoStored_Byte Buro_C_HistoricoIndDatos(int BHI_Id)
        {
            ResultadoStored_Byte Resultado = new ResultadoStored_Byte(null, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@BHI_Id", SqlDbType.Int);
            param.Value = BHI_Id;
            paramC.Add(param);

            Resultado = EjecutarStored_Byte(CatalogoStoreds.Buro_C_HistoricoIndDatos, paramC, "BHI_Documento");

            return Resultado;
        }

        public static ResultadoStored_DT Buro_C_PeriodosDisponiblesIndividuales(bool ObtenerCreados = false)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@ObtenerCreados", SqlDbType.Bit);
            param.Value = ObtenerCreados;
            paramC.Add(param);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Buro_C_PeriodosDisponiblesIndividuales, paramC);

            return Resultado;
        }

        public static ResultadoStored_DT Buro_C_PeriodosExistentesIndividuales()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Buro_C_PeriodosExistentesIndividuales, null);

            return Resultado;
        }

        public static string Buro_I_InsercionMasivaIndividuales(ref DataTable dtCSV)
        {
            string Resultado = string.Empty;

            try
            {
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(SisCreWin.Sistema.Global.OverrideCnx))
                {
                    bulkCopy.DestinationTableName = "dbo.Buro_Creditos_Individuales";
                    bulkCopy.WriteToServer(dtCSV);
                }
            }
            catch(Exception ex)
            {
                Resultado = ex.Message;
            }

            return Resultado;
        }
        //!Individuales
        public static ResultadoStored_Str Buro_M_Documentos(clsGeneral.BuroDocumentos Buro)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Usr_Id", SqlDbType.Int);
            param.Value = Buro.Usr_Id;
            paramC.Add(param);
            param = new SqlParameter("@BDG_Anno", SqlDbType.Int);
            param.Value = Buro.BDG_Anno;
            paramC.Add(param);
            param = new SqlParameter("@BDG_Mes", SqlDbType.Int);
            param.Value = Buro.BDG_Mes;
            paramC.Add(param);
            param = new SqlParameter("@BDG_Tipo", SqlDbType.VarChar);
            param.Value = Buro.BDG_Tipo;
            paramC.Add(param);
            param = new SqlParameter("@BDG_Documento", SqlDbType.VarBinary);
            param.Value = Buro.BDG_Documento;
            paramC.Add(param);

            Resultado = EjecutarStored_StrNQ(CatalogoStoreds.Buro_M_Documentos, paramC);

            return Resultado;
        }

        public static ResultadoStored_Str Buro_U_AutorizarRecreacion(clsGeneral.BuroDocumentos Buro)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();
            
            param = new SqlParameter("@BDG_Anno", SqlDbType.Int);
            param.Value = Buro.BDG_Anno;
            paramC.Add(param);
            param = new SqlParameter("@BDG_Mes", SqlDbType.Int);
            param.Value = Buro.BDG_Mes;
            paramC.Add(param);
            param = new SqlParameter("@BDG_Tipo", SqlDbType.VarChar);
            param.Value = Buro.BDG_Tipo;
            paramC.Add(param);

            Resultado = EjecutarStored_StrNQ(CatalogoStoreds.Buro_U_AutorizarRecreacion, paramC);

            return Resultado;
        }
        #endregion Buro
        #region Puentes
        //Operaciones_Puentes
        public static ResultadoStored_DT Puentes_C_VerificarPosibilidadCierre()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Puentes_C_VerificarPosibilidadCierre, null);

            return Resultado;
        }

        public static ResultadoStored_Str Puentes_C_ObtenerFechaUltimoCierre()
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);

            Resultado = EjecutarStored_Str(CatalogoStoreds.Puentes_C_ObtenerFechaUltimoCierre, null, "MensajeBD");

            return Resultado;
        }

        public static ResultadoStored_Str Puentes_I_CierreDiario(int? NumeroPrestamo = null)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@NumeroPrestamo", SqlDbType.Int);
            param.Value = NumeroPrestamo;
            paramC.Add(param);

            Resultado = EjecutarStored_StrNQ(CatalogoStoreds.Puentes_I_CierreDiario, paramC);

            return Resultado;
        }

        public static ResultadoStored_Str Puentes_M_RegistrarPago(clsGeneral.PuentesPagos Puente, clsGeneral.PuentesPagos PuenteQ, Guid? idArchivos = null)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Usr_Id", SqlDbType.Int);
            param.Value = Puente.Usr_Id;
            paramC.Add(param);
            param = new SqlParameter("@PHP_FechaPago", SqlDbType.DateTime);
            param.Value = Puente.PHP_FechaPago;
            paramC.Add(param);
            param = new SqlParameter("@PHP_NumeroPrestamo", SqlDbType.Int);
            param.Value = Puente.PHP_NumeroPrestamo;
            paramC.Add(param);
            param = new SqlParameter("@PHP_PagoCapital", SqlDbType.Decimal);
            param.Value = Puente.PHP_PagoCapital;
            paramC.Add(param);
            param = new SqlParameter("@PHP_InteresCubierto", SqlDbType.Decimal);
            param.Value = Puente.PHP_InteresCubierto;
            paramC.Add(param);
            param = new SqlParameter("@PHP_InteresCapVenc", SqlDbType.Decimal);
            param.Value = Puente.PHP_InteresCapVenc;
            paramC.Add(param);
            param = new SqlParameter("@PHP_ComiAplicacion", SqlDbType.Decimal);
            param.Value = Puente.PHP_ComiAplicacion;
            paramC.Add(param);
            param = new SqlParameter("@PHP_PagoIntMoratorios", SqlDbType.Decimal);
            param.Value = Puente.PHP_PagoIntMoratorios;
            paramC.Add(param);
            param = new SqlParameter("@PHP_Observaciones", SqlDbType.VarChar);
            param.Value = Puente.PHP_Observaciones;
            paramC.Add(param);
            //Quitas, quebrantos y ajustes
            param = new SqlParameter("@PTP_Id", SqlDbType.Decimal);
            param.Value = PuenteQ.PTP_Id;
            paramC.Add(param);
            param = new SqlParameter("@PHP_QPagoCapital", SqlDbType.Decimal);
            param.Value = PuenteQ.PHP_PagoCapital;
            paramC.Add(param);
            param = new SqlParameter("@PHP_QInteresCubierto", SqlDbType.Decimal);
            param.Value = PuenteQ.PHP_InteresCubierto;
            paramC.Add(param);
            param = new SqlParameter("@PHP_QInteresCapVenc", SqlDbType.Decimal);
            param.Value = PuenteQ.PHP_InteresCapVenc;
            paramC.Add(param);
            param = new SqlParameter("@PHP_QComiAplicacion", SqlDbType.Decimal);
            param.Value = PuenteQ.PHP_ComiAplicacion;
            paramC.Add(param);
            param = new SqlParameter("@PHP_QPagoIntMoratorios", SqlDbType.Decimal);
            param.Value = PuenteQ.PHP_PagoIntMoratorios;
            paramC.Add(param);
            param = new SqlParameter("@PHP_QObservaciones", SqlDbType.VarChar);
            param.Value = PuenteQ.PHP_Observaciones;
            paramC.Add(param);
            //Ajuste
            param = new SqlParameter("@PHP_Archivos", SqlDbType.UniqueIdentifier);
            param.Value = idArchivos;
            paramC.Add(param);

            Resultado = EjecutarStored_StrNQ(CatalogoStoreds.Puentes_M_RegistrarPago, paramC);

            return Resultado;
        }

        public static ResultadoStored_DT Puentes_C_ObtenerPrestamos(bool ObtenerTodos = false)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@ObtenerTodos", SqlDbType.Bit);
            param.Value = ObtenerTodos;
            paramC.Add(param);
            Resultado = EjecutarStored_DT(CatalogoStoreds.Puentes_C_ObtenerPrestamos, paramC);

            return Resultado;
        }

        public static ResultadoStored_DT Puentes_C_MovimientosPrestamo(int? SCP_PRESTAMO, DateTime? Fecha_Ini, DateTime? Fecha_Fin)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@SCP_PRESTAMO", SqlDbType.Int);
            param.Value = SCP_PRESTAMO;
            paramC.Add(param);
            param = new SqlParameter("@Fecha_Ini", SqlDbType.DateTime);
            param.Value = Fecha_Ini;
            paramC.Add(param);
            param = new SqlParameter("@Fecha_Fin", SqlDbType.DateTime);
            param.Value = Fecha_Fin;
            paramC.Add(param);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Puentes_C_MovimientosPrestamo, paramC);

            return Resultado;
        }

        public static ResultadoStored_DT Puentes_C_ObtenerFechasCierre(bool ObtenerGenerados = false)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@ObtenerGenerados", SqlDbType.Bit);
            param.Value = ObtenerGenerados;
            paramC.Add(param);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Puentes_C_ObtenerFechasCierre, paramC);

            return Resultado;
        }

        public static ResultadoStored_DT Puentes_C_ReporteContableMensual(DateTime? Fecha_Ini, DateTime? Fecha_Fin)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();
            
            param = new SqlParameter("@Fecha_Ini", SqlDbType.DateTime);
            param.Value = Fecha_Ini;
            paramC.Add(param);
            param = new SqlParameter("@Fecha_Fin", SqlDbType.DateTime);
            param.Value = Fecha_Fin;
            paramC.Add(param);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Puentes_C_ReporteContableMensual, paramC);

            return Resultado;
        }

        public static ResultadoStored_Str Puentes_I_HistoricoCierreMensual(int Usr_Id, DateTime PHCM_Periodo, byte[] PHCM_Datos)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Usr_Id", SqlDbType.Int);
            param.Value = Usr_Id;
            paramC.Add(param);
            param = new SqlParameter("@PHCM_Periodo", SqlDbType.DateTime);
            param.Value = PHCM_Periodo;
            paramC.Add(param);
            param = new SqlParameter("@PHCM_Datos", SqlDbType.VarBinary);
            param.Value = PHCM_Datos;
            paramC.Add(param);

            Resultado = EjecutarStored_StrNQ(CatalogoStoreds.Puentes_I_HistoricoCierreMensual, paramC);

            return Resultado;
        }

        public static ResultadoStored_Str Puentes_M_CierreMensual(clsGeneral.PuentesCierreMensual Cierre)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Usr_Id", SqlDbType.Int);
            param.Value = Cierre.Usr_Id;
            paramC.Add(param);
            param = new SqlParameter("@PCM_Anno", SqlDbType.Int);
            param.Value = Cierre.PCM_Anno;
            paramC.Add(param);
            param = new SqlParameter("@PCM_Mes", SqlDbType.Int);
            param.Value = Cierre.PCM_Mes;
            paramC.Add(param);
            param = new SqlParameter("@PCM_Datos", SqlDbType.VarBinary);
            param.Value = Cierre.PCM_Datos;
            paramC.Add(param);

            Resultado = EjecutarStored_StrNQ(CatalogoStoreds.Puentes_M_CierreMensual, paramC);

            return Resultado;
        }

        public static ResultadoStored_DT Puentes_C_HistoricoCierresMensuales(DateTime? PHCM_Fecha_Ini, DateTime? PHCM_Fecha_Fin, DateTime? PHCM_Periodo, int? Usr_Id, int TopSel = 100)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT();
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@PHCM_Fecha_Ini", SqlDbType.DateTime);
            param.Value = PHCM_Fecha_Ini;
            paramC.Add(param);
            param = new SqlParameter("@PHCM_Fecha_Fin", SqlDbType.DateTime);
            param.Value = PHCM_Fecha_Fin;
            paramC.Add(param);
            param = new SqlParameter("@PHCM_Periodo", SqlDbType.DateTime);
            param.Value = PHCM_Periodo;
            paramC.Add(param);
            param = new SqlParameter("@Usr_Id", SqlDbType.Int);
            param.Value = Usr_Id;
            paramC.Add(param);
            param = new SqlParameter("@TopSel", SqlDbType.Int);
            param.Value = TopSel;
            paramC.Add(param);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Puentes_C_HistoricoCierresMensuales, paramC);

            return Resultado;
        }

        public static ResultadoStored_Byte Puentes_C_HistoricoDatos(int PHCM_Id)
        {
            ResultadoStored_Byte Resultado = new ResultadoStored_Byte(null, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@PHCM_Id", SqlDbType.Int);
            param.Value = PHCM_Id;
            paramC.Add(param);

            Resultado = EjecutarStored_Byte(CatalogoStoreds.Puentes_C_HistoricoDatos, paramC, "PHCM_Datos");

            return Resultado;
        }

        public static ResultadoStored_Str Puentes_U_AutorizarRegeneracionCierreMensual(int PCM_Anno, int PCM_Mes)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@PCM_Anno", SqlDbType.Int);
            param.Value = PCM_Anno;
            paramC.Add(param);
            param = new SqlParameter("@PCM_Mes", SqlDbType.Int);
            param.Value = PCM_Mes;
            paramC.Add(param);

            Resultado = EjecutarStored_StrNQ(CatalogoStoreds.Puentes_U_AutorizarRegeneracionCierreMensual, paramC);

            return Resultado;
        }
        
        public static ResultadoStored_DT Puentes_C_TiposPago()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Puentes_C_TiposPago, null);

            return Resultado;
        }

        public static ResultadoStored_DT Puentes_C_HistoricoDePago(int PHP_NumeroPrestamo, DateTime PHP_FechaPago)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@PHP_NumeroPrestamo", SqlDbType.Int);
            param.Value = PHP_NumeroPrestamo;
            paramC.Add(param);
            param = new SqlParameter("@PHP_FechaPago", SqlDbType.DateTime);
            param.Value = PHP_FechaPago;
            paramC.Add(param);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Puentes_C_HistoricoDePago, paramC);

            return Resultado;
        }

        public static ResultadoStored_DT Puentes_C_ReporteDePagos(int? PHP_NumeroPrestamo, DateTime? PHP_FechaPago_Ini, DateTime? PHP_FechaPago_Fin)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@PHP_NumeroPrestamo", SqlDbType.Int);
            param.Value = PHP_NumeroPrestamo;
            paramC.Add(param);
            param = new SqlParameter("@PHP_FechaPago_Ini", SqlDbType.DateTime);
            param.Value = PHP_FechaPago_Ini;
            paramC.Add(param);
            param = new SqlParameter("@PHP_FechaPago_Fin", SqlDbType.DateTime);
            param.Value = PHP_FechaPago_Fin;
            paramC.Add(param);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Puentes_C_ReporteDePagos, paramC);

            return Resultado;
        }

        public static ResultadoStored_DT Puentes_C_ObtenerSaldosParaLiquidar(int NumeroPrestamo)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@NumeroPrestamo", SqlDbType.Int);
            param.Value = NumeroPrestamo;
            paramC.Add(param);
            Resultado = EjecutarStored_DT(CatalogoStoreds.Puentes_C_ObtenerSaldosParaLiquidar, paramC);

            return Resultado;
        }

        public static ResultadoStored_DT Puentes_C_CarteraFechaDeterminada(DateTime? Fecha_Ini, DateTime? Fecha_Fin)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Fecha_Ini", SqlDbType.DateTime);
            param.Value = Fecha_Ini;
            paramC.Add(param);
            param = new SqlParameter("@Fecha_Fin", SqlDbType.DateTime);
            param.Value = Fecha_Fin;
            paramC.Add(param);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Puentes_C_CarteraFechaDeterminada, paramC);

            return Resultado;
        }

        public static ResultadoStored_Str Puentes_C_ObtenerFechaContable()
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);

            Resultado = EjecutarStored_Str(CatalogoStoreds.Puentes_C_ObtenerFechaContable, null, "MensajeBD");

            return Resultado;
        }

        public static ResultadoStored_Str Puentes_U_EstablecerFechaContable(string Fecha)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Fecha", SqlDbType.VarChar);
            param.Value = Fecha;
            paramC.Add(param);

            Resultado = EjecutarStored_StrNQ(CatalogoStoreds.Puentes_U_EstablecerFechaContable, paramC);

            return Resultado;
        }

        public static ResultadoStored_Str Puentes_I_ArchivosAjustes(Guid PHP_Archivos, string PAA_Nombre, long PAA_Tamanno, byte[] PAA_Archivo)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@PHP_Archivos", SqlDbType.UniqueIdentifier);
            param.Value = PHP_Archivos;
            paramC.Add(param);
            param = new SqlParameter("@PAA_Nombre", SqlDbType.VarChar);
            param.Value = PAA_Nombre;
            paramC.Add(param);
            param = new SqlParameter("@PAA_Tamanno", SqlDbType.Int);
            param.Value = PAA_Tamanno;
            paramC.Add(param);
            param = new SqlParameter("@PAA_Archivo", SqlDbType.VarBinary);
            param.Value = PAA_Archivo;
            paramC.Add(param);

            Resultado = EjecutarStored_StrNQ(CatalogoStoreds.Puentes_I_ArchivosAjustes, paramC);

            return Resultado;
        }

        public static ResultadoStored_DT Puentes_C_ReporteDeAjustes(int? PHP_NumeroPrestamo, DateTime? PHP_FechaPago_Ini, DateTime? PHP_FechaPago_Fin)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@PHP_NumeroPrestamo", SqlDbType.Int);
            param.Value = PHP_NumeroPrestamo;
            paramC.Add(param);
            param = new SqlParameter("@PHP_FechaPago_Ini", SqlDbType.DateTime);
            param.Value = PHP_FechaPago_Ini;
            paramC.Add(param);
            param = new SqlParameter("@PHP_FechaPago_Fin", SqlDbType.DateTime);
            param.Value = PHP_FechaPago_Fin;
            paramC.Add(param);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Puentes_C_ReporteDeAjustes, paramC);

            return Resultado;
        }

        public static ResultadoStored_DT Puentes_C_AdjuntosPorAjuste(Guid? PHP_Archivos)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@PHP_Archivos", SqlDbType.UniqueIdentifier);
            param.Value = PHP_Archivos;
            paramC.Add(param);

            Resultado = EjecutarStored_DT(CatalogoStoreds.Puentes_C_AdjuntosPorAjuste, paramC);

            return Resultado;
        }

        public static ResultadoStored_Byte Puentes_C_DatosAdjuntoAjuste(int PAA_Id)
        {
            ResultadoStored_Byte Resultado = new ResultadoStored_Byte(null, string.Empty, false);
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@PAA_Id", SqlDbType.Int);
            param.Value = PAA_Id;
            paramC.Add(param);

            Resultado = EjecutarStored_Byte(CatalogoStoreds.Puentes_C_DatosAdjuntoAjuste, paramC, "PAA_Archivo");

            return Resultado;
        }
        //!Operaciones_Puentes
        #endregion Puentes
        #endregion Negocio
    }
    #region Modelos
    public struct ResultadoStored_Str
    {
        public string Resultado;
        public string Error;
        public bool HayError;

        public ResultadoStored_Str(string vResultado, string vError, bool vHayError)
        {
            Resultado = vResultado;
            Error = vError;
            HayError = vHayError;
        }
    }

    public struct ResultadoStored_DT
    {
        public DataTable Resultado;
        public string Error;
        public bool HayError;

        public ResultadoStored_DT(DataTable vResultado, string vError, bool vHayError)
        {
            Resultado = vResultado;
            Error = vError;
            HayError = vHayError;
        }
    }

    public struct ResultadoStored_Int
    {
        public int Resultado;
        public string Error;
        public bool HayError;

        public ResultadoStored_Int(int vResultado, string vError, bool vHayError)
        {
            Resultado = vResultado;
            Error = vError;
            HayError = vHayError;
        }
    }

    public struct ResultadoStored_Byte
    {
        public byte[] Resultado;
        public string Error;
        public bool HayError;

        public ResultadoStored_Byte(byte[] vResultado, string vError, bool vHayError)
        {
            Resultado = vResultado;
            Error = vError;
            HayError = vHayError;
        }
    }

    public struct ResultadoExport
    {
        public string Archivo;
        public string Error;
        public bool HayError;

        public ResultadoExport(string vArchivo, string vError, bool vHayError)
        {
            Archivo = vArchivo;
            Error = vError;
            HayError = vHayError;
        }
    }

    public struct BaseConectada
    {
        public string BaseDatos;
        public string Detalle;

        public BaseConectada(string vBaseDatos, string vDetalle)
        {
            BaseDatos = vBaseDatos;
            Detalle = vDetalle;
        }
    }

    public struct DatosStatusBar
    {
        public string Titulo;
        public string Detalle;

        public DatosStatusBar(string vTitulo, string vDetalle)
        {
            Titulo = vTitulo;
            Detalle = vDetalle;
        }
    }
    #endregion Modelos
}
