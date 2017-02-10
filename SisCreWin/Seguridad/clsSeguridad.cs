using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisCreWin.Seguridad
{
    class clsSeguridad
    {
        public static string GetloggedinUserName()
        {
            System.Security.Principal.WindowsIdentity currentUser = System.Security.Principal.WindowsIdentity.GetCurrent();
            return currentUser.Name;
        }

        public static Credencial ObtenerUsuarioActual()
        {
            System.Security.Principal.WindowsIdentity currentUser = System.Security.Principal.WindowsIdentity.GetCurrent();
            Credencial Res = new Seguridad.clsSeguridad.Credencial((currentUser.Name.IndexOf("\\") > -1) ? currentUser.Name.Substring(currentUser.Name.IndexOf("\\") + 1, currentUser.Name.Length - currentUser.Name.IndexOf("\\") - 1) : string.Empty,
                (currentUser.Name.IndexOf("\\") > -1) ? currentUser.Name.Substring(0, currentUser.Name.IndexOf("\\")) : string.Empty);

            return Res;
        }

        [System.Runtime.InteropServices.DllImport("advapi32.dll")]
        private static extern bool LogonUser(string userName, string domainName, string password, int LogonType, int LogonProvider, ref IntPtr phToken);

        //static void Main(string[] args)
        //{
        //    Program obj = new Program();
        //    bool isValid = obj.IsValidateCredentials("myUserName", "MyPassword", "MyDomain");
        //    Console.WriteLine(isValid == true ? "Valid User details" : "Invalid User Details");
        //    Console.Read();
        //}

        public static bool IsValidateCredentials(string userName, string password, string domain)
        {
            IntPtr tokenHandler = IntPtr.Zero;
            bool isValid = LogonUser(userName, domain, password, 2, 0, ref tokenHandler);
            return isValid;
        }

        public struct Credencial
        {
            public string Usuario;
            public string Dominio;

            public Credencial (string vUsuario, string vDominio)
            {
                Usuario = vUsuario;
                Dominio = vDominio;
            }
        }
    }
}
