using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BasicWMS.AutoMapper;

namespace BasicWMS
{
    public static class Bootstrapper
    {
        public static void Run()
        {
            AutoMapperConfiguration.Configure();
        }
    }
}