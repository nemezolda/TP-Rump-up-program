using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace XbapSample
{
    public static class SecurityManager
    {
        public static bool IsPermissionGranted(CodeAccessPermission requestedPermission)
        {
            try
            {
                requestedPermission.Demand();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
