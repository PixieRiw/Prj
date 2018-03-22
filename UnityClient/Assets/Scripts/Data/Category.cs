﻿using Newtonsoft.Json;
using System.Collections.Generic;

public class Category
{
    [JsonProperty("category_id")]
    public int id;
    public string name;
    [JsonProperty("start_point")]
    public int startPoint;

    public List<TimepointData> timeline;
}
