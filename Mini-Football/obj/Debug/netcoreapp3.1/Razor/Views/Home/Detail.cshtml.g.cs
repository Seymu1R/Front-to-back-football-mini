#pragma checksum "C:\Users\Seymur\Desktop\Projects\BackEnd_Projects\FRONT_TO_BACK\Mini-Football\Mini-Football\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a7aa2d3d521547796da04a33d18a2f6bfc5f5dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
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
#line 2 "C:\Users\Seymur\Desktop\Projects\BackEnd_Projects\FRONT_TO_BACK\Mini-Football\Mini-Football\Views\_ViewImports.cshtml"
using Mini_Football.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Seymur\Desktop\Projects\BackEnd_Projects\FRONT_TO_BACK\Mini-Football\Mini-Football\Views\_ViewImports.cshtml"
using Mini_Football.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a7aa2d3d521547796da04a33d18a2f6bfc5f5dd", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b7ca46080eeeb68fea390645a662fe95f3e0132", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlayerNews>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-box"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Seymur\Desktop\Projects\BackEnd_Projects\FRONT_TO_BACK\Mini-Football\Mini-Football\Views\Home\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"page-title blog-page-title\">\r\n    <div class=\"bg-overlay bg-black opacity-6\"></div>\r\n    <div class=\"container\">\r\n        <h2 class=\"hide-cursor\">");
#nullable restore
#line 10 "C:\Users\Seymur\Desktop\Projects\BackEnd_Projects\FRONT_TO_BACK\Mini-Football\Mini-Football\Views\Home\Detail.cshtml"
                           Write(Model.Player.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <ul class=\"page-breadcrumb link\">\r\n            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a7aa2d3d521547796da04a33d18a2f6bfc5f5dd5995", async() => {
                WriteLiteral("<span class=\"icon fas fa-home\"></span>Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n            <li>");
#nullable restore
#line 13 "C:\Users\Seymur\Desktop\Projects\BackEnd_Projects\FRONT_TO_BACK\Mini-Football\Mini-Football\Views\Home\Detail.cshtml"
           Write(Model.Player.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
        </ul>
    </div>
</section>
<!--Banner End-->

<!-- Blog Detail starts -->
<section class=""text-left"">
    <div class=""container"">
        <div class=""row"">
            <!-- Blog Left Listing -->
            <div class=""col-lg-8 col-md-7"">
                <div class=""blog-box heading-space m-md-0"">
                    <!-- Blog List Inner -->
                    <div class=""blog-listing-inner news_item"">
                        <div class=""news_desc"">
                            <h3 class=""text-capitalize font-weight-500""><a href=""blog-detail.html"" class=""color-black"">");
#nullable restore
#line 29 "C:\Users\Seymur\Desktop\Projects\BackEnd_Projects\FRONT_TO_BACK\Mini-Football\Mini-Football\Views\Home\Detail.cshtml"
                                                                                                                  Write(Model.News.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h3>
                            <ul class=""meta-tags mt-20px mb-20px"">
                                <li><a href=""javascript:void(0)""><i class=""fa fa-calendar""></i>Feb 14</a></li>
                                <li><a href=""javascript:void(0)""> <i class=""fa fa-user""></i> peter </a></li>
                                <li><a href=""javascript:void(0)""><i class=""fa fa-comments""></i>5</a></li>
                                <li><a href=""javascript:void(0)""><i class=""fa fa-tag""></i>work</a></li>
                            </ul>
                            <p class=""mb-3 text-grey alt-font"">");
#nullable restore
#line 36 "C:\Users\Seymur\Desktop\Projects\BackEnd_Projects\FRONT_TO_BACK\Mini-Football\Mini-Football\Views\Home\Detail.cshtml"
                                                          Write(Model.News.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            <p class=""mb-4"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis nec facilisis nullano volutpat justo. Nulla tempus ultricies feugiat. Duis magna risus, luctus id urna dapibus condimentum dui. Maecenas tempor non ex eu vehicula. Sed sit placerat velit.</p>
                            <blockquote class=""mb-5 blockquote font-italic font-weight-light color-black""><i class=""ti ti-quote-left font-30 pr-2""></i>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley</blockquote>
                            <ul class=""rounded heading-space"">
                                <li>Lorem Ipsum has been the industry's standard dummy text ever</li>
                                <li>Lorem Ipsum has been the industry's standard dummy text ever</li>
                                <li>Lorem Ipsum has been the industry's standard dummy text e");
            WriteLiteral(@"ver</li>
                                <li>Lorem Ipsum has been the industry's standard dummy text ever</li>
                                <li>Lorem Ipsum has been the industry's standard dummy text ever</li>
                            </ul>

                            <!-- Comments -->
                            <div class=""agency-author"">
                                <div class=""author-avatar"">
                                    <img alt=""image""");
            BeginWriteAttribute("src", " src=\"", 3202, "\"", 3228, 1);
#nullable restore
#line 50 "C:\Users\Seymur\Desktop\Projects\BackEnd_Projects\FRONT_TO_BACK\Mini-Football\Mini-Football\Views\Home\Detail.cshtml"
WriteAttributeValue("", 3208, Model.Player.ImgUrl, 3208, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""avatar""></div>
                                <div class=""author-content"">
                                    <span class=""text-small"">Written By</span>
                                    <h6><a href=""javascript:void(0);"">Steve Austin</a></h6>
                                    <div class=""alt-font text-grey"">
                                        <p>Maecenas sit amet purus eget ipsum elementum venenatis. Aenean maximus urna magna, quis rutrum mi semper non.</p>
                                    </div>
                                </div>
                            </div>
                            <div class=""agency-author mb-5"">
                                <div class=""author-avatar"">
                                    <img alt=""image"" src=""../corporate-finance/images/post2.jpg"" class=""avatar""></div>
                                <div class=""author-content"">
                                    <span class=""text-small"">Written By</span>
                                ");
            WriteLiteral(@"    <h6><a href=""javascript:void(0);"">Ellie Smith</a></h6>
                                    <div class=""alt-font text-grey"">
                                        <p>Maecenas sit amet purus eget ipsum elementum venenatis. Aenean maximus urna magna, quis rutrum mi semper non.</p>
                                    </div>
                                </div>
                            </div>

                            <!-- Add-Comments -->
                            <div class=""text-center text-md-left w-100 mb-3"">
                                <h4 class=""color-black text-capitalize mt-2 mb-2""> add comments</h4>
                            </div>
                            <div class=""col-sm-12 p-0"" id=""result1""></div>
                            <div class=""company-contact-form"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a7aa2d3d521547796da04a33d18a2f6bfc5f5dd13520", async() => {
                WriteLiteral(@"
                                    <div class=""row"">
                                        <!-- Submission Popup -->
                                        <div class=""col-12"">
                                            <div class=""col-sm-12 px-0"" id=""result""></div>
                                        </div>

                                        <div class=""col-12 col-md-6"">
                                            <div class=""form-group"">
                                                <input class=""form-control"" type=""text"" placeholder=""First Name:""");
                BeginWriteAttribute("required", " required=\"", 5735, "\"", 5746, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""first_name"" name=""firstName"">
                                            </div>
                                        </div>
                                        <div class=""col-12 col-md-6"">
                                            <div class=""form-group"">
                                                <input class=""form-control"" type=""text"" placeholder=""Last Name:""");
                BeginWriteAttribute("required", " required=\"", 6136, "\"", 6147, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""last_name"" name=""lastName"">
                                            </div>
                                        </div>
                                        <div class=""col-12 col-md-6"">
                                            <div class=""form-group"">
                                                <input class=""form-control"" type=""email"" placeholder=""Email:""");
                BeginWriteAttribute("required", " required=\"", 6532, "\"", 6543, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""email"" name=""userEmail"">
                                            </div>
                                        </div>
                                        <div class=""col-12 col-md-6"">
                                            <div class=""form-group"">
                                                <input class=""form-control"" type=""tel"" placeholder=""Phone:"" id=""phone"" name=""userPhone"">
                                            </div>
                                        </div>
                                        <div class=""col-12"">
                                            <div class=""form-group"">
                                                <textarea class=""form-control"" placeholder=""Message"" id=""message"" name=""userMessage""></textarea>
                                            </div>
                                        </div>
                                        <div class=""col-12"">
                                            <button type=""button"" class=""b");
                WriteLiteral("tn btn-large green-long-btn rounded-pill w-100 btn-hvr-up btn-hvr-blue mt-4 contact_btn\" id=\"submit_btn\">SUBMIT REQUEST</button>\r\n                                        </div>\r\n                                    </div>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Blog Widgets -->
            <div class=""col-lg-4 col-md-5"">
                <div class=""text-left widget-blog"">
                    <!-- Search Box -->
                    <div class=""widget heading-space wow fadeIn"" data-wow-delay=""300ms"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a7aa2d3d521547796da04a33d18a2f6bfc5f5dd18591", async() => {
                WriteLiteral(@"
                            <div class=""input-group"">
                                <input type=""search"" class=""form-control"" placeholder=""Search..."" required>
                                <button type=""submit"" class=""search-addon""><i class=""fa fa-search line-height-35px""></i> </button>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>

                    <!-- Recent Post -->
                    <div class=""widget heading-space wow fadeIn"" data-wow-delay=""350ms"">
                        <h5 class=""color-black font-weight-600 text-capitalize mb-4"">Recent Posts</h5>
                        <div class=""single-post mb-3"">
                            <a href=""javascript:void(0)"" class=""post""><img src=""images/post1.jpg"" alt=""image""></a>
                            <div class=""text"">
                                <a href=""javascript:void(0)"" class=""color-grey"">Corporate Studio Management</a>
                                <span>July 15,2018</span>
                            </div>
                        </div>
                        <div class=""single-post mb-3"">
                            <a href=""javascript:void(0)"" class=""post""><img src=""images/post2.jpg"" alt=""image""></a>
                            <div class=""text"">
                                <a href=""javascript:void(0)"" class=""color-gr");
            WriteLiteral(@"ey"">Board of Directors Conference</a>
                                <span>November 09,2018</span>
                            </div>
                        </div>
                    </div>

                    <!-- Categories -->
                    <div class=""widget heading-space wow fadeIn"" data-wow-delay=""400ms"">
                        <h5 class=""color-black font-weight-600 text-capitalize"">Categories</h5>
                        <div>
                            <div class=""categories-name"">
                                <a href=""javascript:void(0)"">
                                    <p class=""font-16 color-grey text-capitalize"">Business  <span>198</span> </p>
                                </a>
                            </div>
                            <div class=""categories-name"">
                                <a href=""javascript:void(0)"">
                                    <p class=""font-16 color-grey text-capitalize"">Corporate <span>119</span> </p>
                 ");
            WriteLiteral(@"               </a>
                            </div>
                            <div class=""categories-name"">
                                <a href=""javascript:void(0)"">
                                    <p class=""font-16 color-grey text-capitalize"">Creative  <span>132</span> </p>
                                </a>
                            </div>
                            <div class=""categories-name"">
                                <a href=""javascript:void(0)"">
                                    <p class=""font-16 color-grey text-capitalize"">Finance  <span>37</span> </p>
                                </a>
                            </div>
                            <div class=""categories-name mb-2"">
                                <a href=""javascript:void(0)"">
                                    <p class=""font-16 color-grey text-capitalize"">Marketing  <span>30</span> </p>
                                </a>
                            </div>
                        </div>");
            WriteLiteral(@"
                    </div>

                    <!-- Tags -->
                    <div class=""widget mb-0 wow fadeIn"" data-wow-delay=""450ms"">
                        <h5 class=""text-black font-weight-600 mb-4 text-capitalize"">Trending tags</h5>
                        <div>
                            <ul class=""tags"">
                                <li>
                                    <p class=""font-13 text-capitalize"">Business</p>
                                </li>
                                <li>
                                    <p class=""font-13 text-capitalize"">Corporate</p>
                                </li>
                                <li>
                                    <p class=""font-13"">SEO</p>
                                </li>
                                <li>
                                    <p class=""font-13 text-capitalize"">Creative</p>
                                </li>
                                <li>
                             ");
            WriteLiteral(@"       <p class=""font-13 text-capitalize"">Finance</p>
                                </li>
                                <li>
                                    <p class=""font-13 text-capitalize"">Marketing</p>
                                </li>
                                <li>
                                    <p class=""font-13 text-capitalize"">Envato</p>
                                </li>
                                <li>
                                    <p class=""font-13 text-capitalize"">Theme Development</p>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlayerNews> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
