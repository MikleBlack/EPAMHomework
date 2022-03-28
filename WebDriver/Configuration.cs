using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.WebDriver
{
    class Configuration
    {
        public static string GetEnviromentVar(string var, string defaultValue)
        {
            return ConfigurationManager.AppSettings[var] ?? defaultValue;
        }

        public static string ElementTimeout = GetEnviromentVar("Element timeout", "30");
        public static string Browser = GetEnviromentVar("Browser", "Chrome");
        public static string StartURL = GetEnviromentVar("StartURL", "https://account.mail.ru/login?page=https%3A%2F%2Fe.mail.ru%2Fmessages%2Finbox%3Futm_source%3Dportal%26utm_medium%3Dnew_portal_navigation%26utm_campaign%3De.mail.ru%26mt_sub5%3D28%26mt_sub1%3Dmail.ru%26mt_click_id%3Dmt-y7s979-1648425307-4110180360&allow_external=1&from=octavius");
    }
}
