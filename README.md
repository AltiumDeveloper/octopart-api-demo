# Octopart API Demo

Supply queries powered by [Octopart API](https://www.altium.com/documentation/altium-developer-center/octopart/api).

Live demo: https://octopart-api-demo.intdev.altium.com/

## How to use
If you have not done this, please enrol at [Altium Developer Center](https://developer.altium.com/).

See [Octopart API Quick Start Guide](https://www.altium.com/documentation/altium-developer-center/quick-starts/octopart-api) 
for details on retrieving Octopart API access token.

Having got an API token, copy it to the clipboard and open the app in a browser.
Paste the token at the `Connect` page and click `CONNECT`. The browser keeps
and restores the token on next runs. The token may be used until it expires.

After that the following page links are shown in the navigation menu:

- Search
- Attributes
- Categories
- Manufactures
- Sellers

## Building blocks

[Blazor]: https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor
[MudBlazor]: https://github.com/Garderoben/MudBlazor
[Octopart API]: https://www.altium.com/documentation/altium-developer-center/octopart/api

The app is built with [Blazor] using [MudBlazor] components.

The Supply domain data are provided by [Octopart API].

The package [HotChocolate StrawberryShake](https://github.com/ChilliCream/hotchocolate)
is used for generating strongly typed C# client code for invoking GraphQL queries.
See the source queries in [Resources](Altium.Client/Resources).
