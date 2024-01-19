using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ResidentialProxyCheck
{
    public class ResidentialProxyChecker
    {
        public bool IsResidentialProxy(string proxy, int timeout)
        {
            WebRequest request = WebRequest.Create("https://www.google.com/");
            request.Proxy = new WebProxy(proxy);
            request.Timeout = timeout;

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (var stream = response.GetResponseStream())
                    {
                        byte[] buffer = new byte[8192];
                        StringBuilder sb = new StringBuilder();
                        int read;

                        while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            sb.Append(Encoding.UTF8.GetString(buffer, 0, read));
                            if (sb.ToString().Contains("google"))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            catch (TimeoutException ex)
            {
                throw ex; // Re-throw the TimeoutException
            }
            catch (WebException ex)
            {
                return false;
            }

            return false;
        }

    }
}
