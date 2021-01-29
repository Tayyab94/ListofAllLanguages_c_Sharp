using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AllCountryLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // This is Good and working well....
            //CultureInfo[] cinfo = CultureInfo.GetCultures(CultureTypes.AllCultures & ~CultureTypes.NeutralCultures);
            //CultureInfo[] cinfo = CultureInfo.GetCultures(CultureTypes.AllCultures & CultureTypes.NeutralCultures);


            //foreach (CultureInfo cul in cinfo.Distinct())
            //{

            //    //Console.WriteLine("Country Name =>  " + cul.DisplayName + " Short Code => " + cul.Name + "");
            //    if(cul.DisplayName.Contains("English")==false)
            //    {
            //        Console.WriteLine("Country Name =>  " + cul.DisplayName);

            //    }
            //    //else
            //    //{
            //    //    Console.WriteLine("Country Name =>  " + cul.DisplayName);

            //    //}

            //}

            //Console.WriteLine("total Languages" + cinfo.Distinct().Count());

            //Console.ReadKey();


            //CultureInfo[] cinfo = CultureInfo.GetCultures(CultureTypes.AllCultures & CultureTypes.NeutralCultures);


            //foreach (CultureInfo cul in cinfo.Distinct().OrderBy(s=>s.DisplayName))
            //{

            //    //Console.WriteLine("Country Name =>  " + cul.DisplayName + " Short Code => " + cul.Name + "");
            //    if (cul.DisplayName[^2..]!="??")
            //    {
            //        //Console.WriteLine("Country Name =>  " + cul.DisplayName);


            //        Console.WriteLine("Country Name =>  " + cul.DisplayName);
            //    }
            //    else
            //    {


            //    }

            //}

            //Console.WriteLine("total Languages" + cinfo.Distinct().Count());


            //List<CultureInfo> cinfo = CultureInfo.GetCultures(CultureTypes.AllCultures & CultureTypes.NeutralCultures).ToList();
            List<string> cinfo = CultureInfo.GetCultures(CultureTypes.AllCultures & CultureTypes.NeutralCultures).Select(s=>s.DisplayName).ToList();


            foreach (string cul in cinfo.Distinct().OrderBy(s =>s))
            {

                //Console.WriteLine("Country Name =>  " + cul.DisplayName + " Short Code => " + cul.Name + "");

                Console.WriteLine("Country Name =>  " + cul);

            }

            Console.WriteLine("total Languages" + cinfo.Distinct().Count());


            Console.ReadKey();

            //// Second atempt

            //var regionalLanguages = CultureInfo.GetCultures(CultureTypes.SpecificCultures).Select(c => c.DisplayName);

            //foreach (var name in regionalLanguages))
            //{
            //    Console.WriteLine("Country Name =>  " + name + "");
            //}

            //Console.WriteLine("total Languages" + regionalLanguages.Count());

            // Third attempt....

            //CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            //List<RegionInfo> countries = new List<RegionInfo>();
            //foreach (CultureInfo ci in cultures)
            //{
            //    RegionInfo regionInfo = new RegionInfo(ci.Name);
            //    if (countries.Count(x => x.EnglishName == regionInfo.EnglishName) <= 0)
            //        countries.Add(regionInfo);
            //}
            //foreach (RegionInfo regionInfo in countries.OrderBy(x => x.DisplayName))
            //    Console.WriteLine(regionInfo.DisplayName);


            //Console.WriteLine("Total Count " + countries.Count());

            Console.ReadKey();
        }
    }
}
