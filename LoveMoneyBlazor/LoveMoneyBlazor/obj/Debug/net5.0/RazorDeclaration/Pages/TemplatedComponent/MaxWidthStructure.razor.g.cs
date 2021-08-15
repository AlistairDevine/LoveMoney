// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LoveMoneyBlazor.Pages.TemplatedComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\alist\OneDrive\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\alist\OneDrive\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\alist\OneDrive\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\alist\OneDrive\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\alist\OneDrive\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\alist\OneDrive\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\alist\OneDrive\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\alist\OneDrive\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using LoveMoneyBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\alist\OneDrive\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using LoveMoneyBlazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\alist\OneDrive\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using LoveMoneyBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\alist\OneDrive\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using LoveMoneyBlazor.Shared.NavigationComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\Users\alist\OneDrive\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using LoveMoneyBlazor.Pages.TemplatedComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "c:\Users\alist\OneDrive\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using AdaptiveCards.Blazor.Templating;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "c:\Users\alist\OneDrive\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\_Imports.razor"
using AdaptiveCards.Blazor;

#line default
#line hidden
#nullable disable
    public partial class MaxWidthStructure : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 142 "c:\Users\alist\OneDrive\Documents\GitHub\LoveMoneyV1\LoveMoneyBlazor\LoveMoneyBlazor\Pages\TemplatedComponent\MaxWidthStructure.razor"
       
    Article[] articles;
    string scheme = "";

    protected override async Task OnInitializedAsync()
    {
        articles = await ArticlesService.GetArticlesAsync();
        scheme = System.IO.File.ReadAllText("AdaptiveCardsScheme.json");
    }

    private string SelectTemplate(object article)
    {
        var art = (Article)article;
        if (art.Title.Contains("Save"))
        {
            return ModelTemplateCatalog.Get("Alternative");
        }
        return ModelTemplateCatalog.Get(article.GetType().Name);
    }

    private List<(string, Func<int, object, object>)> AttributeFunctions = new List<(string, Func<int, object, object>)>()
{
("card-index", (i, model) => i.ToString())
};

    void SearchArticle()
    {
        //TODO : NavigationManager to attach to card attribute for search query to be place in url onclick event
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModelTemplateCatalog ModelTemplateCatalog { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ArticleService ArticlesService { get; set; }
    }
}
#pragma warning restore 1591
