using System.Collections.Generic;

namespace VoKino;

public class Details
{
    public string id { get; set; }
    public string title { get; set; }
    public string poster { get; set; }
    public string air_date { get; set; }
    public int duration { get; set; }
}

public class EmbedModel
{
    public bool IsEmpty { get; set; }
    public Channel[] menu { get; set; }
    public Channel[] channels { get; set; }
    public List<Similar> similars { get; set; }
}

public class RootObject
{
    public Channel[] menu { get; set; }
    public Channel[] channels { get; set; }
}

public class Similar
{
    public string title { get; set; }
    public string balancer { get; set; }
}

public class Channel
{
    public string title { get; set; }
    public string subtitle { get; set; }
    public string ident { get; set; }
    public string playlist_url { get; set; }
    public string data_url { get; set; }
    public bool selected { get; set; }
    public Channel[] submenu { get; set; }
    public string stream_url { get; set; }
    public string subtitles_url { get; set; }
    public string quality_full { get; set; }
    public string voice_name { get; set; }
    public string translation { get; set; }
    public Dictionary<string, string> extra { get; set; }
    public Details details { get; set; }
}
