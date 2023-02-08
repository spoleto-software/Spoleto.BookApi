using Microsoft.Extensions.Configuration;
using Spoleto.BookApi.Client;

namespace Spoleto.FastPayments.AlfaBank.Tests
{
    internal static class ConfigurationHelper
    {
        private static readonly IConfigurationRoot _config;

        static ConfigurationHelper()
        {
            _config = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", optional: true)
               .AddUserSecrets("0f327e73-544b-4ddf-abd0-65eaf8cb2f42")
               .Build();
        }

        public static PersistentProviderOption GetSettings()
        {
            var settings = _config.GetSection(nameof(PersistentProviderOption)).Get<PersistentProviderOption>();

            return settings;
        }
    }
}
