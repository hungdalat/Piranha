﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Manager.Comment
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.WebPages.Html;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Comment/Index.cshtml")]
    public class Index : Piranha.WebPages.ContentPage<Piranha.Manager.Models.CommentListModel>
    {

                // Resolve package relative syntax
                // Also, if it comes from a static embedded resource, change the path accordingly
                public override string Href(string virtualPath, params object[] pathParts) {
                    virtualPath = ApplicationPart.ProcessVirtualPath(GetType().Assembly, VirtualPath, virtualPath);
                    return base.Href(virtualPath, pathParts);
                }
        public Index()
        {
        }
        public override void Execute()
        {


WriteLiteral("\r\n\r\n");



            
            #line 4 "..\..\Comment\Index.cshtml"
  
    Page.Title = Piranha.Manager.Resources.Comment.ListTitle ;
    Layout = "~/Manager/Shared/_Layout.cshtml" ;


            
            #line default
            #line hidden

DefineSection("Head", () => {

WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            // Setup list
            var options = {
                listClass:  'list-js',
                searchId: 'search',
                valueNames: ['title', 'author', 'status', 'created']
            };
            new List('list', options);
        });
    </script>
");


});

WriteLiteral("\r\n");


DefineSection("Toolbar", () => {

WriteLiteral(" \r\n<div class=\"toolbar\">\r\n    <div class=\"inner\">\r\n        <ul>\r\n            <li>" +
"<a href=\"");


            
            #line 25 "..\..\Comment\Index.cshtml"
                    Write(Href("~/manager/comment"));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"refresh\">");


            
            #line 25 "..\..\Comment\Index.cshtml"
                                                                Write(Piranha.Manager.Resources.Toolbar.Reload);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n        </ul>\r\n        <button class=\"search\" title=\"");


            
            #line 27 "..\..\Comment\Index.cshtml"
                                 Write(Piranha.Manager.Resources.Toolbar.Search);

            
            #line default
            #line hidden
WriteLiteral("\"></button>");


            
            #line 27 "..\..\Comment\Index.cshtml"
                                                                                     Write(Html.TextBox("search"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div class=\"clear\"></div>\r\n    </div>\r\n</div>\r\n");


});

WriteLiteral("\r\n<div class=\"grid_12\">\r\n    <table id=\"list\" class=\"list\">\r\n        <thead>\r\n   " +
"         <tr>\r\n                <th><span class=\"sort asc\" data-sort=\"title\">");


            
            #line 36 "..\..\Comment\Index.cshtml"
                                                        Write(Piranha.Manager.Resources.Global.Title);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th><span class=\"sort\" data-sort=\"status\">");


            
            #line 37 "..\..\Comment\Index.cshtml"
                                                     Write(Piranha.Manager.Resources.Comment.Author);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th><span class=\"sort\" data-sort=\"author\">");


            
            #line 38 "..\..\Comment\Index.cshtml"
                                                     Write(Piranha.Manager.Resources.Global.Status);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th class=\"date\"><span class=\"sort\" data-sort=\"crea" +
"ted\">");


            
            #line 39 "..\..\Comment\Index.cshtml"
                                                                   Write(Piranha.Manager.Resources.Global.Created);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th class=\"one\"></th>\r\n            </tr>\r\n        <" +
"/thead>\r\n        <tbody class=\"list-js\">\r\n");


            
            #line 44 "..\..\Comment\Index.cshtml"
             foreach (var comment in Model.Comments) {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td class=\"title\"><a href=\"");


            
            #line 46 "..\..\Comment\Index.cshtml"
                                      Write(Href("~/manager/comment/edit/" + comment.Id));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 46 "..\..\Comment\Index.cshtml"
                                                                                     Write(comment.Title);

            
            #line default
            #line hidden
WriteLiteral("</a></td>\r\n                <td class=\"author\"><a href=\"mailto:");


            
            #line 47 "..\..\Comment\Index.cshtml"
                                              Write(comment.AuthorEmail);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 47 "..\..\Comment\Index.cshtml"
                                                                    Write(comment.AuthorName);

            
            #line default
            #line hidden
WriteLiteral("</a></td>\r\n                <td class=\"status\">");


            
            #line 48 "..\..\Comment\Index.cshtml"
                              Write(comment.StatusName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"created\">");


            
            #line 49 "..\..\Comment\Index.cshtml"
                               Write(comment.Created.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"buttons\">\r\n                    <a href=\"");


            
            #line 51 "..\..\Comment\Index.cshtml"
                        Write(Href("~/manager/comment/edit/delete/" + comment.Id));

            
            #line default
            #line hidden
WriteLiteral("\" title=\"");


            
            #line 51 "..\..\Comment\Index.cshtml"
                                                                                     Write(Piranha.Manager.Resources.Comment.Delete);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"icon delete\"></a></td>\r\n            </tr>\r\n");


            
            #line 53 "..\..\Comment\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");


        }
    }
}
#pragma warning restore 1591
