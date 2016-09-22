using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace StreamingRxNapster
{
    interface INapsterApi
    {
        [Get("/v2.0/albums/new?apikey={api_key}&limit={limit}&offset={offset}")]
        IObservable<NapsterAlbums> GetNewReleases(int limit, int offset, string api_key);


    }
}
