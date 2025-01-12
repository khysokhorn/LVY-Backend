using LVY-Backend.Debugging;

namespace LVY-Backend;

public class LVY-BackendConsts
{
    public const string LocalizationSourceName = "LVY-Backend";

    public const string ConnectionStringName = "Default";

    public const bool MultiTenancyEnabled = true;


    /// <summary>
    /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
    /// </summary>
    public static readonly string DefaultPassPhrase =
        DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "7d6e7531837649a2aac6a13e07d5178a";
}
