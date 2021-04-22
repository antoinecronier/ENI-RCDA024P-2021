using Module5_Demo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Module5_Demo1.HtmlHelpers
{
    public static class MyHtmlHelper
    {
        public static MvcHtmlString MyFirstHelper(this HtmlHelper htmlHelper)
        {
            StringBuilder result = new StringBuilder();

            result.Append($"<div> Bonjour </div>");

            return MvcHtmlString.Create(result.ToString());
        }

        public static MvcHtmlString MySecondHelper(this HtmlHelper htmlHelper)
        {
            StringBuilder result = new StringBuilder();

            if (htmlHelper.ViewBag.SayHello != null && (htmlHelper.ViewBag.SayHello as bool?) == true)
            {
                result.Append($"<div> Bonjour </div>");
            }

            htmlHelper.ViewContext.RouteData.GetRequiredString("controller");
            htmlHelper.ViewContext.RouteData.GetRequiredString("action");

            return MvcHtmlString.Create(result.ToString());
        }

        public static MvcHtmlString MyThirdHelper(this HtmlHelper<Personne> htmlHelper)
        {
            StringBuilder result = new StringBuilder();

            if (htmlHelper.ViewData.Model.Age > 70)
            {

            }

            return MvcHtmlString.Create(result.ToString());
        }

        public static MvcHtmlString MyFourthHelper<T>(this HtmlHelper<T> htmlHelper)
        {
            StringBuilder result = new StringBuilder();

            return MvcHtmlString.Create(result.ToString());
        }
    }
}