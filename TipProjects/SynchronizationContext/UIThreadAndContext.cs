using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CShapAdvancedTips.Context
{
    public class UIThreadAndContext
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private static dynamic btn;
        public void DownloadAndUpdateTheButtonText()
        {
            ///This is when for example you want to update the contect of 
            ///a button in the UI thered so you have to do like this;
            _httpClient.GetStringAsync("http://time.com/currentTime")
                .ContinueWith(downlaodTask => 
                {
                    btn.Contect = downlaodTask.Result;
                }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        /// <summary>
        /// Using the SynchronizationContext post method. 
        /// </summary>
        public void DownloadAndUpdateTheButtonTextDirectSc()
        {
            SynchronizationContext sc = SynchronizationContext.Current;
            ///This is when for example you want to update the contect of 
            ///a button in the UI thered so you have to do like this;
            _httpClient.GetStringAsync("http://time.com/currentTime")
                .ContinueWith(downlaodTask =>
                {
                    sc.Post(delegate
                    {
                        btn.Contect = downlaodTask.Result;
                    }, null);
                });
        }

        /// <summary>
        /// This approach will use pure Await and Async, by default the 
        /// the async/await capture current context;
        /// </summary>
        public void DownloadAndUpdateTheButtonTextUsingAwaitAsync()
        {
            var text = _httpClient.GetStringAsync("http://time.com/currentTime");
            btn.Contect = text;
        }

        public void DownloadAndUpdateTheButtonTextUsingAwaitAsyncContextFalse()
        {
            var text = _httpClient.GetStringAsync("http://time.com/currentTime")
                       .ConfigureAwait(false);
            btn.Contect = text;
        }
    }
}
