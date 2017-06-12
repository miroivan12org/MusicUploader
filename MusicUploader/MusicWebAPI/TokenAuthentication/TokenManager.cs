using System.Web;

namespace MusicWebAPI.TokenAuthentication
{
    public static class TokenManager
    {
        public static string GetIP(HttpRequestBase request)
        {
            string ip = request.Headers["X-Forwarded-For"];

            if (string.IsNullOrEmpty(ip))
                ip = request.UserHostAddress;

            return ip;
        }
    }
}