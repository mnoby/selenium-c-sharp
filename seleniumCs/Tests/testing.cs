﻿using seleniumCs.Pages2;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumCs.Tests
{
    internal class testing
    {

        [Test]
        public void AccessHomePage()
        {
            string url = ConfigurationManager.AppSettings["ApartmentState"];
            Console.WriteLine(string.Format("URL '{0}'", url));

            //string startupPath = System.IO.Directory.GetCurrentDirectory();
            var baseDir = Environment.CurrentDirectory;
            var mainDir = baseDir[..baseDir.LastIndexOf("bin")] + "TestDataAccess";
            var fileName = "userdataTest.xlsx";
            var actualPath = Path.Combine(mainDir, fileName);
            Console.WriteLine(string.Format("PATH >>>>> '{0}'", actualPath));
        }
    }
}
