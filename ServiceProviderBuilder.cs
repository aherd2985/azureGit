using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AzureGitAPI
{
  public class ServiceProviderBuilder
  {
    public static IServiceProvider GetServiceProvider(string[] args)
    {

      IConfigurationRoot configuration = new ConfigurationBuilder()
          .AddUserSecrets(typeof(Program).Assembly)
          .AddCommandLine(args)
          .Build();
      ServiceCollection services = new ServiceCollection();

      services.Configure<APIKeys>(configuration.GetSection("APIKeys"));

      var mySection = configuration.GetSection("MySetting");
      services.Configure<APIKeys>(c => mySection.Bind(c));

      ServiceProvider provider = services.BuildServiceProvider();
      return provider;

    }
  }
}
