# Octopart API Demo

Supply queries powered by Octopart API.

## How to use

[altium.com]: https://altium.com/t

In order to use the app you need an organization at [altium.com] and one of its
applications with Supply enabled. Use this application client ID and secret as
credentials for Altium.Supply.

At the sign in page enter your client ID and secret and click `SIGN IN`.
Save the password when prompted, to allow auto completion next time.


If you have not done this, please enroll at Altium Developer Center to get 
access to Octopart API.

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

The app is built with [Blazor] using [MudBlazor] components.

The Supply domain data are provided by Octopart API: <https://api.nexar.com/graphql>.
This is the endpoint for GraphQL queries and also the GraphQL IDE.

The package [HotChocolate StrawberryShake](https://github.com/ChilliCream/hotchocolate)
is used for generating strongly typed C# client code for invoking GraphQL queries.
See the source queries in [Resources](Altium.Client/Resources).
