﻿using AlloyTraining.Models.Pages;
using EPiServer.ServiceLocation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AlloyTraining.Business.ExtensionMethods
{
    public static class LayoutExtensionMethods
    {
        public static string RenderFooterText(this IHtmlHelper helper)
        {
            var loader = ServiceLocator.Current.GetInstance<IContentLoader>();
            var startPage = loader.Get<StartPage>(ContentReference.StartPage);
            return startPage.FooterText;
        }
    }
}
