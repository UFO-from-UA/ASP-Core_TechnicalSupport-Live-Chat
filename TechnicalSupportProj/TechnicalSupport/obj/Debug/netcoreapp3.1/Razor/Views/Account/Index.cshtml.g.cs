#pragma checksum "C:\Users\Lv\Documents\Kraken\ASP-Core_TechnicalSupport-Live-Chat\TechnicalSupportProj\TechnicalSupport\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ff9e78a9653b2dc784f8e15987bef643816e005"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
#line 1 "C:\Users\Lv\Documents\Kraken\ASP-Core_TechnicalSupport-Live-Chat\TechnicalSupportProj\TechnicalSupport\Views\_ViewImports.cshtml"
using TechnicalSupport;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lv\Documents\Kraken\ASP-Core_TechnicalSupport-Live-Chat\TechnicalSupportProj\TechnicalSupport\Views\_ViewImports.cshtml"
using TechnicalSupport.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ff9e78a9653b2dc784f8e15987bef643816e005", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa7be1d9acbcd8199cee5ef8d8ecf1148067c343", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Account/Logout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Account/Login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Lv\Documents\Kraken\ASP-Core_TechnicalSupport-Live-Chat\TechnicalSupportProj\TechnicalSupport\Views\Account\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ff9e78a9653b2dc784f8e15987bef643816e0054220", async() => {
                WriteLiteral("Выйти");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Lv\Documents\Kraken\ASP-Core_TechnicalSupport-Live-Chat\TechnicalSupportProj\TechnicalSupport\Views\Account\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ff9e78a9653b2dc784f8e15987bef643816e0055551", async() => {
                WriteLiteral("Войти");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Lv\Documents\Kraken\ASP-Core_TechnicalSupport-Live-Chat\TechnicalSupportProj\TechnicalSupport\Views\Account\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"userNameBlock\">\r\n    Введите ник:<br />\r\n    <input id=\"userName\" type=\"text\" />\r\n    <input id=\"loginBtn\" type=\"button\" value=\"Установить\" />\r\n</div>\r\n<br />\r\n\r\n<div id=\"header\"></div>\r\n\r\n\r\n");
#nullable restore
#line 20 "C:\Users\Lv\Documents\Kraken\ASP-Core_TechnicalSupport-Live-Chat\TechnicalSupportProj\TechnicalSupport\Views\Account\Index.cshtml"
 if (User.IsInRole("admin"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br /><div id=\"notifyForm\">\r\n        <input type=\"text\" id=\"idDialog\" />\r\n        <input type=\"text\" id=\"notify\" />\r\n\r\n        <input type=\"button\" id=\"notifyBtn\" value=\"Уведомление\" />\r\n    </div>\r\n");
#nullable restore
#line 28 "C:\Users\Lv\Documents\Kraken\ASP-Core_TechnicalSupport-Live-Chat\TechnicalSupportProj\TechnicalSupport\Views\Account\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <div id=\"inputForm\">\r\n        <input type=\"text\" id=\"message\" />\r\n        <input type=\"button\" id=\"sendBtn\" value=\"Отправить\" />\r\n    </div>\r\n");
#nullable restore
#line 37 "C:\Users\Lv\Documents\Kraken\ASP-Core_TechnicalSupport-Live-Chat\TechnicalSupportProj\TechnicalSupport\Views\Account\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""messageInput"" hidden>
    <input type=""text"" id=""connectionStatus"" hidden />
    <input type=""button"" id=""sendButton"" value=""Отправить"" hidden />
</div>

<div id=""chatroom""></div>


<script>
    const hubConnection = new signalR.HubConnectionBuilder()
        .withUrl(""/chat"")
        .withAutomaticReconnect()
        .build();


    let userName = """";
  ;
    // получение сообщения от сервера
    hubConnection.on(""Receive"", function (mes) {

        // создаем элемент <b> для имени пользователя
        let userNameElem = document.createElement(""b"");
        userNameElem.appendChild(document.createTextNode(mes.dialogId + "": ""));

        // создает элемент <p> для сообщения пользователя
        let elem = document.createElement(""p"");
        elem.appendChild(userNameElem);
        elem.appendChild(document.createTextNode(mes.text));

        var firstElem = document.getElementById(""chatroom"").firstChild;
        document.getElementById(""chatroom"").insertBefore(elem, firs");
            WriteLiteral(@"tElem);

    });
    hubConnection.serverTimeoutInMilliseconds = 100000; // 100 second

    
    hubConnection.onreconnecting((error) => {
        const status = `Connection lost due to error ""${error}"". Reconnecting.`;
        document.getElementById(""messageInput"").disabled = true;
        document.getElementById(""sendButton"").disabled = true;
        document.getElementById(""connectionStatus"").innerText = status;
    });

    hubConnection.onreconnected((connectionId) => {
        const status = `Connection reestablished. Connected.`;
        document.getElementById(""messageInput"").disabled = false;
        document.getElementById(""sendButton"").disabled = false;
        document.getElementById(""connectionStatus"").innerText = status;
    });

    // установка имени пользователя
    document.getElementById(""loginBtn"").addEventListener(""click"", function (e) {
        userName = document.getElementById(""userName"").value;
        document.getElementById(""header"").innerHTML = ""<h3>Welcome ");
            WriteLiteral("\" + userName + \"</h3>\";\r\n\r\n        hubConnection.invoke(\"SendTechnical\", {\"Name\": userName });\r\n\r\n\r\n    });\r\n\r\n    // если администратор добавляем блок\r\n");
#nullable restore
#line 100 "C:\Users\Lv\Documents\Kraken\ASP-Core_TechnicalSupport-Live-Chat\TechnicalSupportProj\TechnicalSupport\Views\Account\Index.cshtml"
     if (User.IsInRole("admin"))
    {
        // отправка сообщения от администратора
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        document.getElementById(""notifyBtn"").addEventListener(""click"", function(e) {
            let message = document.getElementById(""notify"").value;
            let idDialog = document.getElementById(""idDialog"").value;

            hubConnection.invoke(""SendAdmin"", { ""Text"": message, ""Name"": message, ""DialogId"": idDialog});
        });
        ");
#nullable restore
#line 110 "C:\Users\Lv\Documents\Kraken\ASP-Core_TechnicalSupport-Live-Chat\TechnicalSupportProj\TechnicalSupport\Views\Account\Index.cshtml"
               
    }
    else
    {
        // отправка сообщения от простого пользователя
          

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      \r\n        document.getElementById(\"sendBtn\").addEventListener(\"click\", function(e) {\r\n            let text = document.getElementById(\"message\").value;\r\n            hubConnection.invoke(\"Send\", { \"Text\":text, \"Name\":text });\r\n        });\r\n      ");
#nullable restore
#line 121 "C:\Users\Lv\Documents\Kraken\ASP-Core_TechnicalSupport-Live-Chat\TechnicalSupportProj\TechnicalSupport\Views\Account\Index.cshtml"
             
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    hubConnection.start();\r\n</script>");
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
