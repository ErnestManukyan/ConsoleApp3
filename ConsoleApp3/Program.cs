using System;

namespace ConsoleApp3
{
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Net.Http;
    using System.Numerics;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.ConstrainedExecution;
    using System.Runtime.InteropServices;
    using System.Security.Claims;
    using System.Security.Cryptography;
    using System.Text.Json;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using System.Xml.Linq;


    class Location
    {
        public string State { get; set; }
        public string Region { get; set; }

        public List<string> Cities { get; set; }
    }


    class Program
    {
        static async Task Main(string[] args)
        {
            var houston = new Location()
            {
                State = "Houston",
                Cities = new List<string>()
                            {
                                 "Bellaire"
                                ,"City of Houston"
                                ,"Clear Lake"
                                ,"Cypress"
                                ,"Energy Corridor"
                                ,"Heights-Greater Heights"
                                ,"Katy"
                                ,"Medical Center Area"
                                ,"Memorial"
                                ,"Missouri City"
                                ,"River Oaks"
                                ,"Spring"
                                ,"Sugar Land"
                                ,"Tanglewood"
                                ,"The Woodlands"
                            }
            };

            await Get(houston);

            var dallas = new Location()
            {
                State = "Dallas",
                Cities = new List<string>()
                            {
            "Allen"
            ,"Argyle"
            ,"Arlington"
            ,"Bishop Arts District"
            ,"Bluffview"
            ,"City of Dallas"
            ,"Colleyville"
            ,"Denton"
            ,"Flower Mound"
            ,"Fort Worth"
            ,"Frisco"
            ,"Grapevine"
            ,"Highland Park"
            ,"Irving"
            ,"Keller"
            ,"Lake Highlands"
            ,"Lakewood"
            ,"Lewisville"
            ,"Lower-Upper Greenville"
            ,"McKinney"
            ,"Northlake"
            ,"Old East Dallas"
            ,"Plano"
            ,"Preston Hollow"
            ,"Prosper"
            ,"Richardson"
            ,"Rockwall"
            ,"Southlake"
            ,"Trophy Club"
            ,"University Park"
                            }
            };

            await Get(dallas);

            var austin = new Location()
            {
                State = "Austin",
                Cities = new List<string>()
                            {

            "Barton Creek"
            ,"Barton Hills"
            ,"Bee Cave"
            ,"Circle C"
            ,"Clarksville"
            ,"Colony Park"
            ,"Crestview"
            ,"East Austin"
            ,"Enfield"
            ,"Hancock"
            ,"Hyde Park"
            ,"Imperial Valley"
            ,"Lakeway"
            ,"Northwest Hills"
            ,"Pemberton Heights"
            ,"Rosedale"
            ,"South Austin"
            ,"Steiner Ranch"
            ,"Sunset Valley"
            ,"Tarrytown"
            ,"Travis Heights"
            ,"West Lake Hills"
            ,"Windsor Park"
            ,"Zilker"
                            }
            };

            await Get(austin);

            var westchester = new Location()
            {
                State = "Westchester",
                Cities = new List<string>()
                            {
            "Mahopac"
            ,"Cold Spring"
            ,"North Salem"
            ,"Bedford"
            ,"Pleasantville"
            ,"Scarsdale"
            ,"Rye"
            ,"New Rochelle"
            ,"Greenwich"
            ,"New Canaan"
            ,"Westport"
            ,"Ridgefield"
                            }
            };

            await Get(westchester);

            var massachusetts = new Location()
            {
                State = "Massachusetts",
                Cities = new List<string>()
                                {
                                "Boston"
                                ,"Quincy"
                                ,"Wellesley"
                                ,"Nantucket"
                                ,"Martha’s Vineyard"
                            }
            };

            await Get(massachusetts);

            var coloradoAspen = new Location()
            {
                State = "Colorado/Aspen",
                Cities = new List<string>()
                {
"McLain Flats"
,"Red Mountain"
,"Smuggler"
,"East End"
,"East Aspen"
,"West End"
,"West Aspen"
,"Central Core"
,"Smuggler"
,"Maroon"
,"Brush Creek Village"
,"Woody Creek"
                }
            };

            await Get(coloradoAspen);

            var coloradoSnowmass = new Location()
            {
                State = "Colorado/Snowmass",
                Cities = new List<string>()
                {
"Old Snowmass"
,"Snowmass Village"
                }
            };

            await Get(coloradoSnowmass);

            var coloradoDownValley = new Location()
            {
                State = "Colorado/Down Valley",
                Cities = new List<string>()
                {
"Basalt Proper"
,"El Jebel"
,"Emma-Sopris Creek"
,"Frying Pan-Ruedi"
,"Missouri Heights"
,"Carbondale Proper"
,"Carbondale Rural"
,"Glenwood Proper"
,"New Castle Proper"

                }
            };

            await Get(coloradoDownValley);

            var coloradoDenver = new Location()
            {
                State = "Colorado/Denver",
                Cities = new List<string>()
                {

                "Cherry Hills"
                ,"Cherry Creek"
                ,"University Hills"
                ,"Washington Park"
                ,"LoDo (Lower Downtown)"
                ,"Highlands Ranch"
                ,"Sloans Lake"
                ,"Wellshire"
                ,"Platte "
                ,"Congress Park"
                ,"Cherry Hills"
                ,"Cherry Creek"
                ,"University Hills"

                }
            };

            await Get(coloradoDenver);

            var coloradoBoulder = new Location()
            {
                State = "Colorado/Boulder",
                Cities = new List<string>()
                {

"East Pearl"
,"North Irish"
,"Mapleton Hill Historic District"
,"North Boulder"
,"Table Mesa"
,"Wonderland Hills"
,"Chautauqua"
,"East Chautauqua"

                }
            };

            await Get(coloradoBoulder);

            var nevadaLasVegas = new Location()
            {
                State = "Nevada/Las Vegas",
                Cities = new List<string>()
                {

"Centennial Hills"
,"Summerlin North"
,"Summerlin South"
,"Summerlin West"
,"Southwest"
,"The Strip"
,"Skye Canyon"
,"Spring Valley"

                }
            };

            await Get(nevadaLasVegas);

            var nevadaHenderson = new Location()
            {
                State = "Nevada/Henderson",
                Cities = new List<string>()
                {

"MacDonald Highlands"
,"Green Valley"
,"Lake Las Vegas"
,"Seven Hills"
,"Anthem"

                }
            };

            await Get(nevadaHenderson);


            var nevadaNorthLasVegas = new Location()
            {
                State = "Nevada/North Las Vegas",
                Cities = new List<string>()
                {

"City of North Las Vegas"
,"Sunrise"

                }
            };

            await Get(nevadaNorthLasVegas);


            var californiaGreaterLA = new Location()
            {
                Region = "California",
                State = "California/Greater LA",
                Cities = new List<string>()
                {
"Los Angeles"
,"Anaheim"
,"Burbank"
,"Carson"
,"Chino"
,"Costa Mesa"
,"Glendale"
,"Garden Grove"
,"Huntington Beach"
,"Irvine"
,"Laguna Beach"
,"Long Beach"
,"Mission Viejo"
,"Newport Beach"
,"Pasadena"
,"Pomona"
,"Santa Ana"
,"Santa Clarita"
,"Santa Monica"
,"Thousand Oaks"
,"Torrance"
,"West Covina"
,"Malibu"


                }
            };

            await Get(californiaGreaterLA);

            var californiaLAWestside = new Location()
            {
                State = "California/LA Westside",
                Cities = new List<string>()
                {
"Beverly Hills"
,"Studio CIty"
,"Malibu"
,"Westwood"
,"Brentwood"
,"Culver City"


                }
            };

            await Get(californiaLAWestside);

            var californiaLASouthbay = new Location()
            {
                State = "California/LA Southbay",
                Cities = new List<string>()
                {

                "Playa Del Ray"
                ,"Manhattan Beach"
                ,"Redondo Beach"
                ,"Hermosa Beach"
                ,"Torrance"
                ,"Gardena"
                ,"Rancho Palos Verdes"
                ,"Rolling Hills"
                ,"Palos Verdes Estates"
                ,"Rolling Hills Estates"


                }
            };

            await Get(californiaLASouthbay);



            var californiaOrangeCounty = new Location()
            {
                State = "California/Orange County",
                Cities = new List<string>()
                {

                    "Aliso Viejo"
                    ,"Anaheim"
                    ,"Costa Mesa"
                    ,"Cypress"
                    ,"Dana Point"
                    ,"Huntington Beach"
                    ,"Irvine"
                    ,"Laguna Beach"
                    ,"Laguna Hills"
                    ,"Laguna Niguel"
                    ,"Laguna Woods"
                    ,"Los Alamitos"
                    ,"Mission Viejo"
                    ,"Newport Beach"
                    ,"San Clemente"
                    ,"San Juan Capistrano"
                    ,"Santa Ana"
                    ,"Seal Beach"
                    ,"Westminster"


                }
            };

            await Get(californiaOrangeCounty);


            var californiaSanDiego = new Location()
            {
                State = "California/San Diego",
                Cities = new List<string>()
                {
                    "San Diego County"
                }
            };

            await Get(californiaSanDiego);
        }

        static async Task Get(Location location)
        {
            for (int i = 0; i < location.Cities.Count; i++)
            {
                await GetDataAndCreateFile(location.State, location.Cities[i], location.Region);
            }
        }

        static async Task GetDataAndCreateFile(string folderName, string location, string region)
        {
            FacebookApi facebookApi = new FacebookApi();
            string accessToken = "EAAGGzHk3fQIBAKNbQqGYhtZBUNrNwZAci7MRhauY76hZARx0QyZBkiZBzBU1gzP4mj9mUZAmlXRchudfMYXZCLOUJC0D4drTZCIi2NayZCKXHHk6n6vb3B4E8kVrzw0lYr6MtbtRkfHOXwHQxHhitV5MQjbVlM1ZB7qWixHdBMq7VBAjxf7vhT0TUD"; // Replace this with the actual access token
            string response = await facebookApi.GetFacebookData(location, accessToken);
            var jsonObject = JObject.Parse(response);

            if (jsonObject["data"] is JArray jsonData)
            {
                foreach (JToken item in jsonData)
                {
                    if (item["region"].ToString() == region)
                    {
                        if (!Directory.Exists(folderName))
                        {
                            Directory.CreateDirectory(folderName);
                        }

                        string jsonFilePath = Path.Combine(folderName, $"{location}.json");

                        File.WriteAllText(jsonFilePath, jsonData.ToString());
                    }

                }
            }





        }
    }

    public class FacebookApi
    {
        private const string FacebookGraphApiUrl = "https://graph.facebook.com/v16.0/search";

        public async Task<string> GetFacebookData(string location, string accessToken)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var queryParams = new System.Collections.Generic.Dictionary<string, string>
            {
                { "location_types", "[\"city\"]" },
                { "type", "adgeolocation" },
                { "q", location },
                { "access_token", accessToken }
            };

                var queryString = new System.Text.StringBuilder();
                foreach (var param in queryParams)
                {
                    queryString.Append($"{param.Key}={System.Web.HttpUtility.UrlEncode(param.Value)}&");
                }

                queryString.Length -= 1;

                var url = $"{FacebookGraphApiUrl}?{queryString}";

                HttpResponseMessage response = await httpClient.GetAsync(url);

                response.EnsureSuccessStatusCode();

                string result = await response.Content.ReadAsStringAsync();

                return result;
            }
        }
    }

}
