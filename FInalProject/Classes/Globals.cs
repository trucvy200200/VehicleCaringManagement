using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInalProject
{
    class Globals
    {
        //UserID
        public static int GlobalUserId { get; private set; }
        public static void SetGlobalUserId(int userId)
        {
            GlobalUserId = userId;
        }
        //Contract ID
        public static int GlobalCertId { get; private set; }
        public static void SetGlobalCertId(int certId)
        {
            GlobalCertId = certId;
        }
    }
}
