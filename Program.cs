using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.TeamFoundation.SourceControl.WebApi;
using Microsoft.VisualStudio.Services.WebApi;
using System.Collections.Generic;
using System.Linq;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.TeamFoundation.Core.WebApi;

namespace AzureGitAPI
{
  class Program
  {
    const string c_collectionUri = "https://dev.azure.com/";
    static void Main(string[] args)
    {
      IServiceProvider services = ServiceProviderBuilder.GetServiceProvider(args);
      IOptions<APIKeys> options = services.GetRequiredService<IOptions<APIKeys>>();

      //use the httpclient
      VssCredentials creds = new VssBasicCredential(string.Empty, options.Value.PAT);

      // Connect to Azure DevOps Services
      VssConnection connection = new VssConnection(new Uri(c_collectionUri + options.Value.OrgName), creds);

      var workItemTracking = connection.GetClient<WorkItemTrackingHttpClient>();

      Microsoft.TeamFoundation.Core.WebApi.ProjectHttpClient projClient = connection.GetClientAsync<Microsoft.TeamFoundation.Core.WebApi.ProjectHttpClient>().Result;
      var projects = projClient.GetProjects().Result;
      DateTime minCompletedDate = DateTime.Now.AddDays(-10);
      // Get a GitHttpClient to talk to the Git endpoints
      using (GitHttpClient gitClient = connection.GetClient<GitHttpClient>())
      {
        foreach (TeamProjectReference p in projects)
        {
          GitPullRequestSearchCriteria searches = new GitPullRequestSearchCriteria();
          searches.Status = PullRequestStatus.Completed;
          List<GitPullRequest> pulls = gitClient.GetPullRequestsByProjectAsync(p.Name, searches).Result;

          List<GitPullRequest> pullsLastWeek = pulls.Where(x => x.ClosedDate >= minCompletedDate).ToList<GitPullRequest>();
          Console.WriteLine(p.Name);
          Console.WriteLine(pullsLastWeek.Count().ToString());

          foreach (GitPullRequest pull in pullsLastWeek)
          {
            List<GitCommitRef> commits = gitClient.GetPullRequestCommitsAsync(pull.Repository.Id, pull.PullRequestId).Result;

            foreach (GitCommitRef commit in commits)
            {
              Console.WriteLine("{0} - {1} - {2}", commit.CommitId.Substring(0, 8), commit.Comment, commit.Author);
              GitCommitChanges changes = gitClient.GetChangesAsync(p.Name, commit.CommitId, p.Name).Result;

              foreach (var change in changes.Changes)
                Console.WriteLine("{0}: {1}", change.ChangeType, change.Item.Path);
            }
          }
        }

      }

    }

  }
}
