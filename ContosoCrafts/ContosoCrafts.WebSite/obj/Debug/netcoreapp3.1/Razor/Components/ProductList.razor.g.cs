#pragma checksum "D:\Training\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "626208899b69d59a8b9a44675d1d6eec5af9aae3"
// <auto-generated/>
#pragma warning disable 1591
namespace ContosoCrafts.WebSite.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Training\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
using ContosoCrafts.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Training\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
using ContosoCrafts.WebSite.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Training\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class ProductList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 7 "D:\Training\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
     foreach (var product in ProductService.GetProducts())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-img");
            __builder.AddAttribute(9, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 10 "D:\Training\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                                 product.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-body");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "h5");
            __builder.AddAttribute(16, "class", "card-title");
#nullable restore
#line 13 "D:\Training\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
__builder.AddContent(17, product.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "card-footer");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "small");
            __builder.AddAttribute(24, "class", "text-muted");
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "D:\Training\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                                      (e => SelectProduct(product?.Id ?? string.Empty))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "data-toggle", "modal");
            __builder.AddAttribute(29, "data-target", "#productModal");
            __builder.AddAttribute(30, "class", "btn btn-primary");
            __builder.AddMarkupContent(31, "\r\n                        More Info\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 24 "D:\Training\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n\r\n");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "modal fade");
            __builder.AddAttribute(39, "id", "productModal");
            __builder.AddAttribute(40, "tabindex", "-1");
            __builder.AddAttribute(41, "role", "dialog");
            __builder.AddAttribute(42, "aria-labelledby", "productTitle");
            __builder.AddAttribute(43, "aria-hidden", "true");
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(47, "role", "document");
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 30 "D:\Training\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
         if (selectedProduct != null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "            ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "modal-content");
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "modal-header");
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.OpenElement(56, "h5");
            __builder.AddAttribute(57, "class", "modal-title");
            __builder.AddAttribute(58, "id", "productTitle");
#nullable restore
#line 34 "D:\Training\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
__builder.AddContent(59, selectedProduct.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.AddMarkupContent(61, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "modal-body");
            __builder.AddMarkupContent(65, "\r\n                    ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "card");
            __builder.AddMarkupContent(68, "\r\n                        ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "card-img");
            __builder.AddAttribute(71, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 41 "D:\Training\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                                             selectedProduct.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.AddMarkupContent(72, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                        ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "card-body");
            __builder.AddMarkupContent(76, "\r\n                            ");
            __builder.OpenElement(77, "p");
            __builder.AddAttribute(78, "class", "card-text");
#nullable restore
#line 44 "D:\Training\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
__builder.AddContent(79, selectedProduct.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "modal-footer");
            __builder.AddMarkupContent(86, "\r\n");
#nullable restore
#line 49 "D:\Training\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                     if (voteCount == 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(87, "                        ");
            __builder.AddMarkupContent(88, "<span>Be the first to vote!</span>\r\n");
#nullable restore
#line 52 "D:\Training\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(89, "                        ");
            __builder.OpenElement(90, "span");
#nullable restore
#line 55 "D:\Training\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
__builder.AddContent(91, voteCount);

#line default
#line hidden
#nullable disable
            __builder.AddContent(92, " ");
#nullable restore
#line 55 "D:\Training\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
__builder.AddContent(93, voteLabel);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
#nullable restore
#line 56 "D:\Training\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "D:\Training\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                     for (int i = 1; i < 6; i++)
                    {
                        var currentStar = i;
                        if (i <= currentRating)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(95, "                            ");
            __builder.OpenElement(96, "span");
            __builder.AddAttribute(97, "class", "fa fa-star checked");
            __builder.AddAttribute(98, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "D:\Training\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                                       (e => SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n");
#nullable restore
#line 63 "D:\Training\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(100, "                            ");
            __builder.OpenElement(101, "span");
            __builder.AddAttribute(102, "class", "fa fa-star");
            __builder.AddAttribute(103, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "D:\Training\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                               (e => SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n");
#nullable restore
#line 67 "D:\Training\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(105, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n");
#nullable restore
#line 71 "D:\Training\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(108, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">");
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "D:\Training\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
 
    Product? selectedProduct;
    string? selectedProductId;

    void SelectProduct(string productId)
    {
        selectedProductId = productId;
        selectedProduct = ProductService.GetProducts().First(x => x.Id == productId);
        GetCurrentRating();
    }

    int currentRating = 0;
    int voteCount = 0;
    string? voteLabel;

    void GetCurrentRating()
    {
        if (selectedProduct?.Ratings == null)
        {
            currentRating = 0;
            voteCount = 0;
        }
        else
        {
            voteCount = selectedProduct.Ratings.Count();
            voteLabel = voteCount > 1 ? "Votes" : "Vote";
            currentRating = selectedProduct.Ratings.Sum() / voteCount;
        }

        System.Console.WriteLine($"Current rating for {selectedProduct?.Id}: {currentRating}");
    }

    void SubmitRating(int rating)
    {
        System.Console.WriteLine($"Rating received for {selectedProduct?.Id}: {rating}");
        if (selectedProductId == null)
            return;
        ProductService.AddRating(selectedProductId, rating);
        SelectProduct(selectedProductId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
