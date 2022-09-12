using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Update.ViewModels
{
   
    public class BanCapNhat
    {
        public string articleName { get; set; }
        public string articleUrl { get; set; }
        public string downloadName { get; set; }
        public string rebootRequired { get; set; }
        public int ordinal { get; set; }
        public string fixedBuildNumber { get; set; }
        public string downloadUrl { get; set; }
        public string supercedence { get; set; }
        public string knownIssuesName { get; set; }
        public string knownIssuesUrl { get; set; }
    }

    public class Root
    {
        [JsonProperty("@odata.context")]
        public string OdataContext { get; set; }

        [JsonProperty("@odata.count")]
        public int OdataCount { get; set; }
        public IEnumerable<Value> value { get; set; }
    }

    public class Value
    {
        public string id { get; set; }
        public DateTime releaseDate { get; set; }
        public string releaseNumber { get; set; }
        public string product { get; set; }
        public int productId { get; set; }
        public string productFamily { get; set; }
        public int productFamilyId { get; set; }
        public int platformId { get; set; }
        public string cveNumber { get; set; }
        public int severityId { get; set; }
        public string severity { get; set; }
        public int impactId { get; set; }
        public string impact { get; set; }
        public string issuingCna { get; set; }
        public DateTime initialReleaseDate { get; set; }
        public string baseScore { get; set; }
        public string temporalScore { get; set; }
        public string vectorString { get; set; }
        public IEnumerable<BanCapNhat> kbArticles { get; set; }
    }



}