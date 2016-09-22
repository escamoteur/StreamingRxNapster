using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StreamingRxCommons;

namespace StreamingRxNapster
{
    public class NapsterAlbums
    {
        public List<NapsterAlbum> albums;
    }

    public class NapsterAlbum : IAlbum
    {
        public string Name => name;
        public string Artist => artistName;


        public string type { get; set; }
        public string id { get; set; }
        public string upc { get; set; }
        public string shortcut { get; set; }
        public string href { get; set; }


        public string name { get; set; }
        public string released { get; set; }
        public string originallyReleased { get; set; }
        public string label { get; set; }
        public string copyright { get; set; }
        public List<string> tags { get; set; }
        public int discCount { get; set; }
        public int trackCount { get; set; }
        public bool @explicit { get; set; }
        public bool single { get; set; }
        public string accountPartner { get; set; }
        public string artistName { get; set; }
        public Dictionary<string,string> contributingArtists { get; set; }
        public Dictionary<string,List<string>> discographies { get; set; }
        public Links links { get; set; }
    }



    public class ContributingArtists
    {
        public string primaryArtist { get; set; }
    }

    public class Discographies
    {
        public List<string> main { get; set; }
    }

    public class Images
    {
        public string href { get; set; }
    }

    public class Tracks
    {
        public string href { get; set; }
    }

    public class Posts
    {
        public string href { get; set; }
    }

    public class Artists
    {
        public List<string> ids { get; set; }
        public string href { get; set; }
    }

    public class Genres
    {
        public List<string> ids { get; set; }
        public string href { get; set; }
    }

    public class Links
    {
        public Images images { get; set; }
        public Tracks tracks { get; set; }
        public Posts posts { get; set; }
        public Artists artists { get; set; }
        public Genres genres { get; set; }
    }

}
