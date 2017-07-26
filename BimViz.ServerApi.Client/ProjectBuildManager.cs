using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BimViz.ServerApi.Client.Model;
using RestSharp;
using RestSharp.Extensions.MonoHttp;

namespace BimViz.ServerApi.Client
{
    public class ProjectBuildManager
    {
        string mToken;
        RestClient mRestClient;

        public ProjectBuildManager(RestClient client, string token)
        {
            mToken = token;
            mRestClient = client;
        }

        public RebuildState GetRebuildSceneState(string userName, string projId)
        {
            RestRequest request = new RestRequest("/api/projectbuild/GetRebuildSceneState", Method.GET);
            request.AddHeader("Authorization", "bearer " + mToken);
            request.AddParameter("username", userName);
            request.AddParameter("projid", projId);
            var res = mRestClient.Execute<RebuildState>(request);
            if (res.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            return res.Data;
        }

        public ResultModel RebuildScene(string userName, string projId, string cmd)
        {
            RestRequest request = new RestRequest("/api/projectbuild/RebuildScene", Method.GET);
            request.AddHeader("Authorization", "bearer " + mToken);
            request.AddParameter("username", userName);
            request.AddParameter("projid", projId);
            request.AddParameter("cmd", cmd);
            var res = mRestClient.Execute<ResultModel>(request);
            if (res.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            return res.Data;
        }

        public ResultModel SetSceneState(string userName, string projId, int sceneStatus)
        {
            RestRequest request = new RestRequest("/api/projectbuild/SetSceneState", Method.GET);
            request.AddHeader("Authorization", "bearer " + mToken);
            request.AddParameter("username", userName);
            request.AddParameter("projid", projId);
            request.AddParameter("scenestatus", sceneStatus);
            var res = mRestClient.Execute<ResultModel>(request);
            if (res.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            return res.Data;
        }
    }
}
