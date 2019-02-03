using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Type = ConsoleApp3.app.Type;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            using ( StreamReader r = new StreamReader("json1.json") )
            {
                List<string> vaList = new List<string>()
                {
                    "13066YTY5", "BPM0X08D7", "BPM19UKK6", "BPM0GMXN8", "7443M3HT4", "912796NV7", "BPM1MDLV4",
                    "BPM0TZLH1", "BPM1CL065", "05357HAA8", "05526QAE6", "Z923SFWP2", "00123Q104", "63946CAE8",
                    "BRSBY2CY7", "BPM04VEE2", "963CQM904", "BPM1DZUN3", "GZ8201887", "A5Q820183", "BPM11MWT0",
                    "BPM12PU72", "B0A0EAEB1", "B06734907", "912828LA6", "BRT82HVN8", "BMS03QU56", "BPM05SN73",
                    "BPM13SXW7", "BMS03PUN9", "BMS03YS03", "BMS03PXA4", "BPM13P7G7", "BMS03PUM1", "BPM13P7H5",
                    "026874156"
                };
                List<BlackRockData> BlackRockDataset=new List<BlackRockData>();
                string json = r.ReadToEnd();
                var content = JObject.Parse(json);
                foreach (var item in vaList)
                {
                    if (content.SelectToken("assetByAssetId." + item) !=null && content.SelectToken("assetByAssetId." + item).HasValues)
                    {
                        var s = content.SelectToken("assetByAssetId." + item).Values();
                        if (s.Any())
                        {
                            foreach (var v in s.AsJEnumerable())
                            {
                                if (v.HasValues)
                                {
                                    v.ToString().Replace("{{", "{");
                                    v.ToString().Replace("}}", "}");
                                    var y = JsonConvert.DeserializeObject<BlackRockData>(v.ToString());
                                    BlackRockDataset.Add(y);
                                }
                            }
                        }
                    }
                }

                Dictionary<string,ConsoleApp3.app.Type> ErrorLists=new Dictionary<string, Type>();
                if (content.SelectToken("errors") != null &&
                    content.SelectToken("errors").Parent.Children().Values().AsJEnumerable().Any())
                {
                    var errors = content.SelectToken("errors").Parent.Children().Values();
                    foreach (var error in errors.AsJEnumerable())
                    {
                        if (error.HasValues)
                        {
                            var instrumentCode = error.Path.Replace("errors.", "");
                            error?.First?.ToString()?.Replace("{{", "{");
                            error?.First?.ToString()?.Replace("}}", "}");
                            ErrorLists.Add(instrumentCode, JsonConvert.DeserializeObject<ConsoleApp3.app.Type>(error?.First?.ToString()));
                        }
                    }
                }
            }
        }
    }
}
