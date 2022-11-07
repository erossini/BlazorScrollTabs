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
