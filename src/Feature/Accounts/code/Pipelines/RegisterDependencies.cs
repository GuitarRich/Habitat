namespace Sitecore.Feature.Accounts.Pipelines
{
  using Microsoft.Extensions.DependencyInjection;
  using Services;
  using Sitecore.Feature.Accounts.Repositories;
  using Sitecore.Foundation.DependencyInjection;
  using Sitecore.Foundation.DependencyInjection.Pipelines.InitializeDepdencyInjection;

  public class RegisterDependencies
  {
    public void Process(InitializeDependencyInjectionArgs args)
    {
      args.ServiceCollection.AddScoped<IAccountRepository, AccountRepository>();
      args.ServiceCollection.AddScoped<IAccountsSettingsService, AccountsSettingsService>();
      args.ServiceCollection.AddScoped<IAccountTrackerService, AccountTrackerService>();
      args.ServiceCollection.AddScoped<IContactProfileService, ContactProfileService>();
      args.ServiceCollection.AddScoped<INotificationService, NotificationService>();
      args.ServiceCollection.AddScoped<IProfileSettingsService, ProfileSettingsService>();
      args.ServiceCollection.AddScoped<IUserProfileProvider, UserProfileProvider>();
      args.ServiceCollection.AddScoped<IUserProfileService, UserProfileService>();

      args.ServiceCollection.AddMvcControllersInCurrentAssembly();
    }
  }
}