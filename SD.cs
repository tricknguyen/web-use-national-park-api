using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_App
{
    public static class SD
    {
        public static string APIBaseUrl = "https://localhost:44377/";
        public static string NationalParkAPIPath = APIBaseUrl + "api/v1/NationalParks/";
        public static string TrailAPIPath = APIBaseUrl + "api/v1/trails/";
        public static string AccountAPIPath = APIBaseUrl + "api/v1/Users/";
    }
}
