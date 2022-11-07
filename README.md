# ScrollTabs for Blazor
Automatically adjusts to detect whether scrolling is needed, ideal for responsive interfaces. One of the greatest features for ScrollTabs is that you can have different right-and-left side styling depending on if scrolling is required. 
Here you can see that there are rounded corners for the right and left sides when it is not wide enough to scroll, however when scrolling there are right and left arrows accordingly.

![scrolltabs](https://user-images.githubusercontent.com/9497415/200393605-b8c6472e-b058-4caa-8710-ccac7916ad90.gif)

## Add the ScrollTabs

First, if your project is a Blazor WebAssemble, open the _index.html_ and add the following lines in the header of the page

```xml
<link href="_content/PSC.Blazor.Components.ScrollTabs/css/scrolltabs.css" rel="stylesheet" />
```

Then, before the `BODY` tag closed, add the following lines:

```xml
<script src="_content/PSC.Blazor.Components.ScrollTabs/js/jquery.mousewheel.js"></script>
<script src="_content/PSC.Blazor.Components.ScrollTabs/js/jquery.scrolltabs.js"></script>

<script src="_content/PSC.Blazor.Components.ScrollTabs/js/scrolltabs.js"></script>
```

> This component requires `jquery` and `bootstrap`. You can install those libraries for Visual Studio > Client-side library.

Finally, in the `_Imports.razor` add

```
@using PSC.Blazor.Components.ScrollTabs
```

## Use the Scrolltabs

In your `Razor` page, you can call the component like that

```xml
<ScrollTabs TabId="TabId1" OnTabChanged="OnTabChanged" Theme="Theme.Dark">
    <Tab Text="Tab 1" Value="Tab1">
        <h2>Content Tab 1</h2>
        <p>
            This is the content for the Tab 1. It is enabled.
        </p>
    </Tab>
    <Tab Text="Tab 2" Value="Tab2">
        <h2>Content Tab 2</h2>
        <p>
            This is the content for the Tab 2. It is enabled.
        </p>
    </Tab>
</ScrollTabs>
```

```csharp
@code {
    public async Task OnTabChanged(Tab tab)
    {
        Console.WriteLine($"Tab value: {tab.Value} - Tab text: {tab.Text}");
    }
}
```

### Themes

Embedded in the components, there are 3 theme options:

- Light
- Dark
- None

You can use `None` to use your custom implementation.

---
    
## Other Blazor components

| Component name | Forum | Description |
|---|---|---|
| [DataTable for Blazor](https://www.puresourcecode.com/dotnet/net-core/datatable-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/datatables/) | DataTable component for Blazor WebAssembly and Blazor Server |
| [Markdown editor for Blazor](https://www.puresourcecode.com/dotnet/blazor/markdown-editor-with-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/markdown-editor-for-blazor/) |  This is a Markdown Editor for use in Blazor. It contains a live preview as well as an embeded help guide for users. |
| [Browser Detect for Blazor](https://www.puresourcecode.com/dotnet/blazor/browser-detect-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/browser-detect-for-blazor/) | Browser detect for Blazor WebAssembly and Blazor Server |
| [CodeSnipper for Blazor](https://www.puresourcecode.com/dotnet/blazor/code-snippet-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/codesnippet-for-blazor/) | Add code snippet in your Blazor pages for 196 programming languages with 243 styles |
| [Copy To Clipboard](https://www.puresourcecode.com/dotnet/blazor/copy-to-clipboard-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/copytoclipboard/) | Add a button to copy text in the clipbord | 
| SVG Icons and flags for Blazor | [Forum](https://www.puresourcecode.com/forum/icons-and-flags-for-blazor/) | Library with a lot of SVG icons and SVG flags to use in your Razor pages |
| [Modal dialog for Blazor](https://www.puresourcecode.com/dotnet/blazor/modal-dialog-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/modal-dialog-for-blazor/) |  Simple Modal Dialog for Blazor WebAssembly |
| [PSC.Extensions](https://www.puresourcecode.com/dotnet/net-core/a-lot-of-functions-for-net5/) | [Forum](https://www.puresourcecode.com/forum/forum/psc-extensions/) |  A lot of functions for .NET5 in a NuGet package that you can download for free. We collected in this package functions for everyday work to help you with claim, strings, enums, date and time, expressions... |
| [Quill for Blazor](https://www.puresourcecode.com/dotnet/blazor/create-a-blazor-component-for-quill/) | [Forum](https://www.puresourcecode.com/forum/forum/quill-for-blazor/) |  Quill Component is a custom reusable control that allows us to easily consume Quill and place multiple instances of it on a single page in our Blazor application |
| [Segment for Blazor](https://www.puresourcecode.com/dotnet/blazor/segment-control-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/segments-for-blazor/) |  This is a Segment component for Blazor Web Assembly and Blazor Server |
| [Tabs for Blazor](https://www.puresourcecode.com/dotnet/blazor/tabs-control-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/tabs-for-blazor/) |  This is a Tabs component for Blazor Web Assembly and Blazor Server |
| [WorldMap for Blazor]() | [Forum](https://www.puresourcecode.com/forum/worldmap-for-blazor/) | Show world maps with your data |

## More examples and documentation
*   [Write a reusable Blazor component](https://www.puresourcecode.com/dotnet/blazor/write-a-reusable-blazor-component/)
*   [Getting Started With C# And Blazor](https://www.puresourcecode.com/dotnet/net-core/getting-started-with-c-and-blazor/)
*   [Setting Up A Blazor WebAssembly Application](https://www.puresourcecode.com/dotnet/blazor/setting-up-a-blazor-webassembly-application/)
*   [Working With Blazor Component Model](https://www.puresourcecode.com/dotnet/blazor/working-with-blazors-component-model/)
*   [Secure Blazor WebAssembly With IdentityServer4](https://www.puresourcecode.com/dotnet/blazor/secure-blazor-webassembly-with-identityserver4/)
*   [Blazor Using HttpClient With Authentication](https://www.puresourcecode.com/dotnet/blazor/blazor-using-httpclient-with-authentication/)
*   [InputSelect component for enumerations in Blazor](https://www.puresourcecode.com/dotnet/blazor/inputselect-component-for-enumerations-in-blazor/)
*   [Use LocalStorage with Blazor WebAssembly](https://www.puresourcecode.com/dotnet/blazor/use-localstorage-with-blazor-webassembly/)
*   [Modal Dialog component for Blazor](https://www.puresourcecode.com/dotnet/blazor/modal-dialog-component-for-blazor/)
*   [Create Tooltip component for Blazor](https://www.puresourcecode.com/dotnet/blazor/create-tooltip-component-for-blazor/)
*   [Consume ASP.NET Core Razor components from Razor class libraries | Microsoft Docs](https://docs.microsoft.com/en-us/aspnet/core/blazor/components/class-libraries?view=aspnetcore-5.0&tabs=visual-studio)
