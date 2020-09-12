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
using AzureGitAPI.Art;

namespace AzureGitAPI
{
  class Program
  {
    const string c_collectionUri = "https://dev.azure.com/";
    static void Main(string[] args)
    {
      IServiceProvider services = ServiceProviderBuilder.GetServiceProvider(args);
      IOptions<APIKeys> options = services.GetRequiredService<IOptions<APIKeys>>();
      asciiArtClass asciiArt = new asciiArtClass();

      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("\n\n");
      foreach (string line in asciiArt.azureArtArr)
        Console.WriteLine(line);

      //use the httpclient
      VssCredentials creds = new VssBasicCredential(string.Empty, options.Value.PAT);

      // Connect to Azure DevOps Services
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("\nConnecting...");
      VssConnection connection = new VssConnection(new Uri(c_collectionUri + options.Value.OrgName), creds);

      WorkItemTrackingHttpClient workItemTracking = connection.GetClient<WorkItemTrackingHttpClient>();

      ProjectHttpClient projClient = connection.GetClientAsync<ProjectHttpClient>().Result;
      IPagedList<TeamProjectReference> projects = projClient.GetProjects().Result;

      // Get a GitHttpClient to talk to the Git endpoints
      using (GitHttpClient gitClient = connection.GetClient<GitHttpClient>())
      {
        foreach (TeamProjectReference p in projects)
        {
          Console.WriteLine("\n\nProject --- " + p.Name);
          List<GitRepository> repoList = gitClient.GetRepositoriesAsync(p.Name).Result;

          GitRepository masterRepo = repoList.Where(x => x.Name == "master" || x.Name == p.Name).FirstOrDefault();
          Console.WriteLine("Repo Name --- " + masterRepo.Name);

          //set a filter to only return commits within the last 16 days
          GitQueryCommitsCriteria searches = new GitQueryCommitsCriteria();
          searches.FromDate = DateTime.Now.AddDays(-3).ToShortDateString();
          
          List<GitCommitRef> commits = gitClient.GetCommitsBatchAsync(searches, masterRepo.Id).Result;

          foreach (GitCommitRef cmt in commits)
          {
            Console.WriteLine("\n\nProject --- " + p.Name);
            Console.WriteLine("Repo Name --- " + masterRepo.Name);
            Console.WriteLine("\nCommit ID - #{0}\nBy - {1}\nEmail - {2}\nOn - {3}", cmt.CommitId, cmt.Author.Name, cmt.Author.Email, cmt.Author.Date.ToLongDateString(), cmt.Comment);
            GitCommitChanges changes = gitClient.GetChangesAsync(p.Name, cmt.CommitId, p.Name).Result;

            foreach (GitChange change in changes.Changes)
            {
              Console.WriteLine("{0}: {1}", change.ChangeType, change.Item.Path);
            }
          }
        }
      }

      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("\n\n");
      foreach (string line in asciiArt.tieFArtArr)
        Console.WriteLine(line);

    }

  }
}
