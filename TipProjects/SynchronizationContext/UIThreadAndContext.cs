﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CShapAdvancedTips.SynchronizationContext
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
    }
}