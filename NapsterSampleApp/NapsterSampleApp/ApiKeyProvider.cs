using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NapsterSampleApp
{
    //Don't push this file to GitHub if you inserted your real keys
    public static class ApiKeyProvider
    {
        public static string GetApiKey => "yourKey";
        public static string GetApiSecret => "yourSecret";
    }
}
