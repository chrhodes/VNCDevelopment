﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;

namespace VNC.Core.Net
{
    public class RequestResponseInfo
    {
        private string _uri;

        public string Uri
        {
            get => _uri;
            set => _uri = value;
        }

        public ObservableCollection<KeyValuePair<string, IEnumerable<string>>> RequestHeaders { get; set; }
            = new ObservableCollection<KeyValuePair<string, IEnumerable<string>>>();

        private HttpResponseMessage _Response;

        public HttpResponseMessage Response
        {
            get => _Response;
            set => _Response = value;
        }

        private Int32 _ResponseStatusCode;

        public Int32 ResponseStatusCode
        {
            get => _ResponseStatusCode;
            set => _ResponseStatusCode = value;
        }

        public ObservableCollection<KeyValuePair<string, IEnumerable<string>>> ResponseHeaders { get; set; }
            = new ObservableCollection<KeyValuePair<string, IEnumerable<string>>>();

        public ObservableCollection<KeyValuePair<string, IEnumerable<string>>> ResponseContentHeaders { get; set; }
            = new ObservableCollection<KeyValuePair<string, IEnumerable<string>>>();
    }
}
