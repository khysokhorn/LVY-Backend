using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace LVY-Backend.Localization;

public static class LVY-BackendLocalizationConfigurer
{
    public static void Configure(ILocalizationConfiguration localizationConfiguration)
    {
        localizationConfiguration.Sources.Add(
            new DictionaryBasedLocalizationSource(LVY-BackendConsts.LocalizationSourceName,
                new XmlEmbeddedFileLocalizationDictionaryProvider(
                    typeof(LVY-BackendLocalizationConfigurer).GetAssembly(),
                    "LVY-Backend.Localization.SourceFiles"
                )
            )
        );
    }
}
