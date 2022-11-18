using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace PSC.Blazor.Components.ScrollTabs
{
    public partial class ScrollTabs
    {
        // Create an object reference for JS
        private DotNetObjectReference<ScrollTabs>? dotNetHelper;
        private string ThemeValue = "scroll_tabs_theme_light";

        /// <summary>
        /// Gets or sets the CSS class.
        /// </summary>
        /// <value>The CSS class.</value>
        [Parameter]
        public string? CSSClass { get; set; }

        /// <summary>
        /// Gets or sets the tab identifier.
        /// </summary>
        /// <value>The tab identifier.</value>
        [Parameter]
        public string? TabId { get; set; }

        /// <summary>
        /// Gets or sets the theme.
        /// </summary>
        /// <value>The theme.</value>
        [Parameter]
        public Theme Theme
        {
            get => _theme;
            set
            {
                _theme = value;
                switch (_theme)
                {
                    case Theme.Grey:
                        ThemeValue = "scroll_tabs_theme_grey";
                        break;
                    case Theme.Dark:
                        ThemeValue = "scroll_tabs_theme_dark";
                        break;
                    case Theme.Light:
                        ThemeValue = "scroll_tabs_theme_light";
                        break;
                    default:
                        ThemeValue = "";
                        break;
                }
            }
        }
        private Theme _theme = Theme.Light;

        /// <summary>
        /// Gets or sets the content of the child.
        /// </summary>
        /// <value>The content of the child.</value>
        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        /// <summary>
        /// Gets or sets the on tab changed.
        /// </summary>
        /// <value>The on tab changed.</value>
        [Parameter]
        public EventCallback<Tab> OnTabChanged { get; set; }

        /// <summary>
        /// Gets or sets the active page.
        /// </summary>
        /// <value>The active page.</value>
        public Tab? ActivePage { get; set; }

        List<Tab> Pages = new List<Tab>();

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                dotNetHelper = DotNetObjectReference.Create(this);
                await JSRuntime.InvokeVoidAsync("Helpers.setDotNetHelper", dotNetHelper);
                // Setup the tabs
                await JSRuntime.InvokeVoidAsync("setupScrollTabs", TabId);
            }
        }

        /// <summary>
        /// Adds the page.
        /// </summary>
        /// <param name="tabPage">The tab page.</param>
        internal void AddPage(Tab tabPage)
        {
            Pages.Add(tabPage);
            if (Pages.Count == 1)
                ActivePage = tabPage;

            StateHasChanged();
        }

        /// <summary>
        /// Gets the tab CSS.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <returns>System.String.</returns>
        string GetTabCSS(Tab page)
        {
            if (!page.Enabled)
                return "tab-disabled";
            return page == ActivePage ? "tab_selected" : "";
        }

        /// <summary>
        /// Activates the page.
        /// </summary>
        /// <param name="text">The text.</param>
        void ActivatePage(string text)
        {
            var active = Pages.Where(p => p?.Text?.Trim() == text).FirstOrDefault();
            if (active != null)
                ActivatePage(active);
        }

        /// <summary>
        /// Activates the page.
        /// </summary>
        /// <param name="page">The page.</param>
        void ActivatePage(Tab page)
        {
            if (page.Enabled)
            {
                ActivePage = page;
                OnTabChanged.InvokeAsync(page);
            }
        }

        /// <summary>
        /// Changes the tab.
        /// </summary>
        /// <param name="val">The value.</param>
        [JSInvokable("ChangeTab")]
        public async Task ChangeTab(string val)
        {
            ActivatePage(val);
        }

        /// <summary>
        /// Disposes this instance.
        /// </summary>
        public void Dispose()
        {
            dotNetHelper?.Dispose();
        }
    }
}