﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Jimu.Client
{
    public class RemoteCallerContext
    {
        public JimuServiceRoute Service { get; }
        public IDictionary<string, object> Paras { get; }

        public string Token { get; }
        public JimuPayload PayLoad { get; set; }

        public JimuAddress ServiceAddress { get; set; }


        public RemoteCallerContext(JimuServiceRoute service, IDictionary<string, object> paras, string token, JimuAddress jimuAddress)
        {
            if (paras == null) paras = new ConcurrentDictionary<string, object>();
            this.Service = service;
            this.Paras = paras;
            this.Token = token;
            this.ServiceAddress = jimuAddress;
        }
    }
}
