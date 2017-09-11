using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace XbapSample
{
    public class RegistryPageFunction : PageFunction<string>
    {
        public void GetResult(object sender, ReturnEventArgs<string> e)
        {
            var result = e.Result;
        }
    }
}
