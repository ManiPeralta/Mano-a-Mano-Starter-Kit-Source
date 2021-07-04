using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umbraco.Cms.Web.Website.Controllers;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;
using B4.Models;

namespace B4.Controllers
{
    public class ContactFormController : SurfaceController
    {
        string PATH = "~/Views/Partials/ContactForm/ContactForm.cshtml";
        public ContactFormController(
               IUmbracoContextAccessor umbracoContextAccessor,
               IUmbracoDatabaseFactory databaseFactory,
               ServiceContext services,
               AppCaches appCaches,
               IProfilingLogger profilingLogger,
               IPublishedUrlProvider publishedUrlProvider)
               : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
        }
        public ActionResult RenderContactForm()
        {
            ContactModel model = new ContactModel();
            return PartialView(PATH, model);
        }
    }
}
