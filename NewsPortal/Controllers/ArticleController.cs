using NewsPortal.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsPortal.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var articles = session.Query<Article>().ToList();
                return View(articles);
            }
        }
    }
}