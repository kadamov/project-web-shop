#pragma checksum "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e8b652ae510ff0140418d2728596b4de7f53dc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogue_Index), @"mvc.1.0.view", @"/Views/Catalogue/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
using MbmStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e8b652ae510ff0140418d2728596b4de7f53dc9", @"/Views/Catalogue/Index.cshtml")]
    public class Views_Catalogue_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e8b652ae510ff0140418d2728596b4de7f53dc93780", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>View</title>\r\n    <style>\r\n        \r\n        .flex{\r\n            display:inline-flex;\r\n        }\r\n        .flex div{\r\n            margin: 0 20px;\r\n        }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e8b652ae510ff0140418d2728596b4de7f53dc95014", async() => {
                WriteLiteral("\r\n    <div class=\"flex\">\r\n        <div>\r\n            <h1>The Movies</h1>\r\n");
#nullable restore
#line 27 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
             foreach (var movie in ViewBag.Movies)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div>\r\n                    <p><b>Title:</b>");
#nullable restore
#line 30 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                               Write(movie.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <p><b>Director:</b>");
#nullable restore
#line 31 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                                  Write(movie.Director);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <p><b>Price:</b>");
#nullable restore
#line 32 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                               Write(movie.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5e8b652ae510ff0140418d2728596b4de7f53dc96733", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 711, "~/Images/", 711, 9, true);
#nullable restore
#line 33 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
AddHtmlAttributeValue("", 720, movie.ImageFileName, 720, 20, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 33 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
AddHtmlAttributeValue("", 747, movie.ImageFileName, 747, 20, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 35 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n        <div>\r\n            <h1>The Books</h1>\r\n");
#nullable restore
#line 39 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
             foreach (var book in ViewBag.Books)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<div>\r\n                    <p><b>Title:</b> ");
#nullable restore
#line 41 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                                Write(book.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <p><b>Author:</b> ");
#nullable restore
#line 42 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                                 Write(book.Author);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <p><b>Price:</b> ");
#nullable restore
#line 43 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                                Write(book.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <p><b>Publisher:</b> ");
#nullable restore
#line 44 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                                    Write(book.Publisher);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <p><b>ISBN:</b> ");
#nullable restore
#line 45 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                               Write(book.ISBN);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 1247, "\"", 1279, 2);
                WriteAttributeValue("", 1253, "Images/", 1253, 7, true);
#nullable restore
#line 46 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
WriteAttributeValue("", 1260, book.ImageFileName, 1260, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1280, "\"", 1305, 1);
#nullable restore
#line 46 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
WriteAttributeValue("", 1286, book.ImageFileName, 1286, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"250\" />\r\n                </div>\r\n");
#nullable restore
#line 48 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n        <div>\r\n            <h1>The Music</h1>\r\n");
#nullable restore
#line 52 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
             foreach (var musicCD in ViewBag.MusicCDs)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div>\r\n                    <div>\r\n                        <p><b>Album:</b> ");
#nullable restore
#line 56 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                                    Write(musicCD.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <p><b>Artist:</b> ");
#nullable restore
#line 57 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                                     Write(musicCD.Artist);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <p><b>Price:</b> ");
#nullable restore
#line 58 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                                    Write(musicCD.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <p><b>Label:</b> ");
#nullable restore
#line 59 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                                    Write(musicCD.Label);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5e8b652ae510ff0140418d2728596b4de7f53dc914320", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1826, "~/Images/", 1826, 9, true);
#nullable restore
#line 60 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
AddHtmlAttributeValue("", 1835, musicCD.ImageFileName, 1835, 22, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 60 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
AddHtmlAttributeValue("", 1864, musicCD.ImageFileName, 1864, 22, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                    <div>\r\n                        <p><b>Tracks:</b></p>\r\n                        <ol>\r\n");
#nullable restore
#line 65 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                             foreach (var track in musicCD.Tracks)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li>");
#nullable restore
#line 67 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                               Write(track.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" (");
#nullable restore
#line 67 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                                             Write(track.Composer);

#line default
#line hidden
#nullable disable
                WriteLiteral(") ");
#nullable restore
#line 67 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                                                              Write(track.Length.Minutes);

#line default
#line hidden
#nullable disable
                WriteLiteral(":");
#nullable restore
#line 67 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                                                                                    Write(track.Length.Seconds);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 68 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </ol>\r\n                        <p><b>Total playing time:</b> ");
#nullable restore
#line 70 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                                                 Write(musicCD.GetPlayingTime());

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 74 "C:\Users\Jakob\Dropbox\Jakob Web's shared workspace\semester-1\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n        </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
