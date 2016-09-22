using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using System.Text;
using System.Threading.Tasks;

using Refit;
using StreamingRxCommons;

namespace StreamingRxNapster
{
    public class StreamingProviderNapster : IStreamingProvider
    {
        private INapsterApi NapsterAPI;
        private string apiKey;

        public StreamingProviderNapster(string apiKey)
        {
            this.apiKey = apiKey;
            NapsterAPI = RestService.For<INapsterApi>("http://api.napster.com");
            
        }

        public IObservable<IEnumerable<IAlbum>> GetNewReleases(int limit, int offset = 0)
        {
            return NapsterAPI.GetNewReleases(limit, offset, apiKey).Select(albumsContainer => albumsContainer.albums);
        }
    }
}
