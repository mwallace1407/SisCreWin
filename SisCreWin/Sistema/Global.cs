﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisCreWin.Sistema
{
    static class Global
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
    }
}
