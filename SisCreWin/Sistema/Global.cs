namespace SisCreWin.Sistema
{
    internal static class Global
    {
        private static int vUsr_Id = 0;
        private static bool vProcesosPendientes = false;
        private static string vUsuario = string.Empty;
        private static string vCnx = string.Empty;
        private static string vBaseCnx = string.Empty;

        public static int Usr_Id
        {
            get { return vUsr_Id; }
            set { vUsr_Id = value; }
        }

        public static bool ProcesosPendientes
        {
            get { return vProcesosPendientes; }
            set { vProcesosPendientes = value; }
        }

        public static string Usuario
        {
            get { return vUsuario; }
            set { vUsuario = value; }
        }

        public static string OverrideCnx
        {
            get { return vCnx; }
            set { vCnx = value; }
        }

        public static string BaseConectada
        {
            get { return vBaseCnx; }
            set { vBaseCnx = value; }
        }

        public static System.Windows.Forms.DataGridViewCellStyle CeldaFecha
        {
            get
            {
                System.Windows.Forms.DataGridViewCellStyle estilo = new System.Windows.Forms.DataGridViewCellStyle();

                estilo.Format = "d";
                estilo.NullValue = null;
                estilo.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

                return estilo;
            }
        }

        public static System.Windows.Forms.DataGridViewCellStyle CeldaFechaHora
        {
            get
            {
                System.Windows.Forms.DataGridViewCellStyle estilo = new System.Windows.Forms.DataGridViewCellStyle();

                estilo.Format = "G";
                estilo.NullValue = null;
                estilo.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

                return estilo;
            }
        }

        public static System.Windows.Forms.DataGridViewCellStyle CeldaNumerica_0Dec
        {
            get
            {
                System.Windows.Forms.DataGridViewCellStyle estilo = new System.Windows.Forms.DataGridViewCellStyle();

                estilo.Format = "N0";
                estilo.NullValue = null;
                estilo.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

                return estilo;
            }
        }

        public static System.Windows.Forms.DataGridViewCellStyle CeldaNumerica_2Dec
        {
            get
            {
                System.Windows.Forms.DataGridViewCellStyle estilo = new System.Windows.Forms.DataGridViewCellStyle();

                estilo.Format = "N2";
                estilo.NullValue = null;
                estilo.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

                return estilo;
            }
        }

        public static System.Windows.Forms.DataGridViewCellStyle CeldaNumerica_4Dec
        {
            get
            {
                System.Windows.Forms.DataGridViewCellStyle estilo = new System.Windows.Forms.DataGridViewCellStyle();

                estilo.Format = "N4";
                estilo.NullValue = null;
                estilo.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

                return estilo;
            }
        }

        public static System.Windows.Forms.DataGridViewCellStyle CeldaNumerica_6Dec
        {
            get
            {
                System.Windows.Forms.DataGridViewCellStyle estilo = new System.Windows.Forms.DataGridViewCellStyle();

                estilo.Format = "N6";
                estilo.NullValue = null;

                return estilo;
            }
        }

        public static System.Drawing.Color ColorAltGrid
        {
            get
            {
                return System.Drawing.Color.Gainsboro;
            }
        }
    }
}