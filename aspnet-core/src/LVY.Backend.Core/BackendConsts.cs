using LVY.Backend.Debugging;

namespace LVY.Backend;

public class BackendConsts
{
    public const string LocalizationSourceName = "Backend";

    public const string ConnectionStringName = "Default";

    public const bool MultiTenancyEnabled = true;


    /// <summary>
    /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
    /// </summary>
    public static readonly string DefaultPassPhrase =
        DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "e0c2adfbe56f4f8a90df5b31b9947e6f";
}
