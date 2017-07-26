using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BimViz.ServerApi.Client.Model;
using RestSharp;

namespace BimViz.ServerApi.Client
{
    public class BimVizServerApiClient
    {
        string mUrl;
        string mToken;
        RestClient restClient;
        ProjectBuildManager mProjectBuildManager;
        ModelProjectManager mModelProjectManager;
        
        public ProjectBuildManager ProjectBuildManager
        {
            get
            {
                return mProjectBuildManager;
            }
        }

        public ModelProjectManager ModelProjectManager
        {
            get
            {
                return mModelProjectManager;
            }
        }

        public BimVizServerApiClient(string url, string devkey)
        {
            mUrl = url;
            restClient = new RestClient(url);
            mToken = GetToken(devkey);
            
            mProjectBuildManager = new ProjectBuildManager(restClient, mToken);
            mModelProjectManager = new ModelProjectManager(restClient, mToken);
        }

        private string GetToken(string devkey)
        {
            RestRequest request = new RestRequest("/api/user/token", Method.GET);
            request.AddParameter("devkey", devkey);
            var res = restClient.Execute<TokenInfo>(request);
            if (res.StatusCode != System.Net.HttpStatusCode.OK)
                return "";

            return res.Data == null ? "" : res.Data.token;
        }
    }
}
