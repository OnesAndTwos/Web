using System;
using System.Collections.Generic;
using System.Web;
using OnesAndTwos.Infrastructure.Common.Extensions;

namespace OnesAndTwos.Web.Support
{
    public interface IAlert
    {
        void RaiseSuccess(string message);
        void RaiseError(string message);
        void RaiseAttention(string message);
        void RaiseInformation(string message);
    }

    public class Alerter : IAlert
    {
        private static Dictionary<Alert, string> Alerts
        {
            get
            {
                return HttpContext.Current.Items.LazyLoad("Web.Alerts", () => new Dictionary<Alert, string>());
            }
        }

        public static bool HasAlert(Alert alert)
        {
            return Alerts.ContainsKey(alert);
        }

        public static string GetCssClassFor(Alert alert)
        {
            return alert.GetAttributeString<CssClassAttribute>(a => a.CssClass);
        }

        public static string GetMessageFor(Alert alert)
        {
            return Alerts[alert];
        }

        public void RaiseSuccess(string message)
        {
            Alerts[Alert.Success] = message;
        }

        public void RaiseError(string message)
        {
            Alerts[Alert.Error] = message;
        }

        public void RaiseAttention(string message)
        {
            Alerts[Alert.Attention] = message;
        }

        public void RaiseInformation(string message)
        {
            Alerts[Alert.Information] = message;
        }
    }

    public enum Alert
    {
        [CssClass("success")] Success,
        [CssClass("attention")] Attention,
        [CssClass("error")] Error,
        [CssClass("info")] Information
    }

    internal class CssClassAttribute : Attribute
    {
        public CssClassAttribute(string cssClass)
        {
            CssClass = cssClass;
        }

        public string CssClass
        {
            get; private set;
        }
    }
}