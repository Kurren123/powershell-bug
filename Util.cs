using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace PowershellTest
{
    public static class Util
    {

        private static string PrintPSObject(PSObject obj)
        {
            var strs = obj.Properties.Select(p => $"{p.Name}: {GetPropertyValue(p)}");
            return String.Join(Environment.NewLine, strs);
        }
        private static string GetPropertyValue(PSPropertyInfo p)
        {
            try
            {
                return (p.Value.ToString() ?? "");
            }
            catch (Exception)
            {
                return "";
            }
        }
        public static string PrintPSObjects(IEnumerable<PSObject> objs)
        {
            var separator = $"{Environment.NewLine}************{Environment.NewLine}";
            return String.Join(separator, objs.Select(PrintPSObject));
        }
    }
}
