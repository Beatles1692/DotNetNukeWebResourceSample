using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyModule
{
    public class ApiModule:IHttpModule
    {
        static ApiModule()
        {
            
        }

        static void Execute()
        {
            
        }

        public void Init(HttpApplication context)
        {
            Execute();
        }

        public void Dispose()
        {
            
        }
    }
}