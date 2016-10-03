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
        // This is a Demokey from Napster that should not be used in production. Just register your own App with Napster
        public static string GetApiKey => "NmE0ZTY0MTUtZDdkMy00MDkxLWFhN2YtMjdlZmY5MTljN2I5";
        public static string GetApiSecret => "MzBkNmY4NzYtNjhlNy00MDY5LTk3YjUtNjFiYjMwY2YwYjRh";
    }


}
