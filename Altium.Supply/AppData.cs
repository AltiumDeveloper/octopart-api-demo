using System;

namespace Altium.Supply;

/// <summary>
/// The application parameters and state.
/// </summary>
public static class AppData
{
    /// <summary>
    /// The GraphQL API endpoint.
    /// </summary>
    public const string ApiEndpoint = "https://api.nexar.com/graphql";

    /// <summary>
    /// The Altium home page.
    /// </summary>
    public const string AltiumDotCom = "https://altium.com";

    /// <summary>
    /// The current session token.
    /// </summary>
    public static string? Token
    {
        get => _token;
        set
        {
            _token = value;
            OnChange?.Invoke();
        }
    }
    private static string? _token;

    /// <summary>
    /// This event is triggered on changes.
    /// </summary>
    public static event Action? OnChange;
}
