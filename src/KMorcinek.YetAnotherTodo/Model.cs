using RaptorDB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace KMorcinek.YetAnotherTodo
{
    public class Model
    {
        public string GetData()
        {
            string path = HttpContext.Current.Server.MapPath("~/App_Data");

            // long string keys without case sensitivity
            var rap = new RaptorDBString(Path.Combine(path, "longstringkey"), false);
            rap.Set("ala", "ma kota");
            string test;
            if (rap.Get("ala", out test))
            {
                return test;
            }

            return null;
        }
    }
}