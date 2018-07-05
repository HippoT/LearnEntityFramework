using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudCodeFirst
{
    public static class ExtensionMethod
    {
        public static string ToTest(this string str)
        {
            return null;
        }

        public static void test()
        {
            string hello = "";
            hello.ToTest();
        }
    }
}
