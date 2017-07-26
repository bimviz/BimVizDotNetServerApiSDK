using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using BimViz.ServerApi.Client.Model;
using RestSharp;
using RestSharp.Extensions.MonoHttp;

namespace BimViz.ServerApi.Client
{
    public class ModelProjectManager
    {
        string mToken;
        RestClient mRestClient;

        public ModelProjectManager(RestClient client, string token)
        {
            mToken = token;
            mRestClient = client;
        }

        public List<ProjectInfo> ListAll(string userName)
        {
            RestRequest request = new RestRequest("/api/project/ListAll", Method.GET);
            request.AddHeader("Authorization", "bearer " + mToken);
            request.AddParameter("username", userName);
            var res = mRestClient.Execute<List<ProjectInfo>>(request);
            if (res.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            return res.Data;
        }

        public ResultModel AddProject(string userName, ProjectInfo projectInfo)
        {
            RestRequest request = new RestRequest("/api/project/Add?username=" + userName, Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Authorization", "bearer " + mToken);
            request.AddBody(projectInfo);
            var res = mRestClient.Execute<ResultModel>(request);
            if (res.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            return res.Data;
        }

        public ResultModel DeleteProject(string userName, string projectId)
        {
            RestRequest request = new RestRequest("/api/project/Delete", Method.DELETE);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Authorization", "bearer " + mToken);
            request.AddParameter("username", userName);
            request.AddParameter("projid", projectId);
            var res = mRestClient.Execute<ResultModel>(request);
            if (res.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            return res.Data;
        }

        public ResultModel UploadProjectFiles(string userName, string projectId, List<string> files)
        {
            string parameters = string.Format("?username={0}&projid={1}", userName, projectId);
            RestRequest request = new RestRequest("/api/project/UploadProjectFiles" + parameters, Method.POST);
            request.AddHeader("Authorization", "bearer " + mToken);
            foreach(string file in files)
            {
                request.AddFile(Path.GetFileName(file), file, "application/octet-stream");
            }
            
            var res = mRestClient.Execute<ResultModel>(request);
            if (res.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            return res.Data;
        }

        public ResultModel RemoveProjectFile(string userName, string projectId, string fileName)
        {
            RestRequest request = new RestRequest("/api/project/RemoveProjectFile", Method.GET);
            request.AddHeader("Authorization", "bearer " + mToken);
            request.AddParameter("username", userName);
            request.AddParameter("projid", projectId);
            request.AddParameter("filename", fileName);
            var res = mRestClient.Execute<ResultModel>(request);
            if (res.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            return res.Data;
        }

        public ResultModel UpdateSceneSettings(string userName, string projectId, ProjectSettings settings)
        {
            string parameters = string.Format("?username={0}&projid={1}", userName, projectId);
            RestRequest request = new RestRequest("/api/project/UpdateSceneSettings" + parameters, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Authorization", "bearer " + mToken);
            request.AddBody(settings);
            var res = mRestClient.Execute<ResultModel>(request);
            if (res.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            return res.Data;
        }

        public ResultModel UpdateProjectInfo(string userName, string projectId, string name, string description, string thrumbnailFile)
        {
            string parameters = string.Format("?username={0}&projid={1}&name={2}&description={3}", userName, projectId, name, description);
            RestRequest request = new RestRequest("/api/project/UpdateProjectInfo" + parameters, Method.PUT);
            request.AddHeader("Authorization", "bearer " + mToken);
            request.AddFile(Path.GetFileName(thrumbnailFile), thrumbnailFile, "application/octet-stream");
            var res = mRestClient.Execute<ResultModel>(request);
            if (res.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            return res.Data;
        }
    }
}
