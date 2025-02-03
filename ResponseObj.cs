using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("bank")]
    public string bank { get; set; }

    [JsonProperty("ifsc")]
    public string ifsc { get; set; }

    [JsonProperty("branch")]
    public string branch { get; set; }

    [JsonProperty("address")]
    public string address { get; set; }

    [JsonProperty("contact")]
    public string contact { get; set; }

    [JsonProperty("city")]
    public string city { get; set; }

    [JsonProperty("district")]
    public string district { get; set; }

    [JsonProperty("state")]
    public string state { get; set; }

    [JsonProperty("imps")]
    public bool imps { get; set; }

    [JsonProperty("rtgs")]
    public bool rtgs { get; set; }

    [JsonProperty("neft")]
    public bool neft { get; set; }

    [JsonProperty("upi")]
    public bool upi { get; set; }

    [JsonProperty("micr")]
    public string micr { get; set; }

    [JsonProperty("swift")]
    public string swift { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
