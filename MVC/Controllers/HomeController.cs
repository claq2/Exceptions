﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ManualResetEvent[] handles = new ManualResetEvent[1] { new ManualResetEvent(false) };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ThrowException()
        {
            throw new Exception("Oh noooo!");
        }

        public ActionResult ThrowBackgroundException()
        {
            Thread t = new Thread(this.ThreadProcedure);
            this.handles[0].Reset();
            t.Start();
            WaitHandle.WaitAll(this.handles);
            return View("Index");
        }

        public async Task<ActionResult> ThrowAsyncException()
        {
            await AsyncProcedure();
            return View("Index");
        }

        private void ThreadProcedure(object state)
        {
            throw new Exception("Oh noooo!");
            this.handles[0].Set();
        }

        private async Task AsyncProcedure()
        {
            throw new Exception("Oh noooo!");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}