using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.ScrollTabs
{
    public interface ITab
    {
        RenderFragment ChildContent { get; }
    }
}
