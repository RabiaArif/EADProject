#pragma checksum "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\Controls\SignUpForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb764033d00a4e7e5a82da55c28dc909d58b3120"
// <auto-generated/>
#pragma warning disable 1591
namespace FinalProjectNew.Client.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\_Imports.razor"
using FinalProjectNew.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\_Imports.razor"
using FinalProjectNew.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\_Imports.razor"
using FinalProjectNew.Client.Controls;

#line default
#line hidden
#nullable disable
    public partial class SignUpForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-login-form");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 2 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\Controls\SignUpForm.razor"
                      person

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 2 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\Controls\SignUpForm.razor"
                                        FormSubmitted

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "class", "login-form");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "input-icon");
                __builder2.AddAttribute(11, "style", "display:inline;");
                __builder2.AddMarkupContent(12, "<i class=\"fas fa-user\"></i>\r\n                ");
                __builder2.AddMarkupContent(13, "<label for=\"Name\">Name : </label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "id", "name");
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "name", "email");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\Controls\SignUpForm.razor"
                                                  person.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => person.Name = __value, person.Name))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => person.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "input-icon");
                __builder2.AddAttribute(26, "style", "display:inline;");
                __builder2.AddMarkupContent(27, "<i class=\"far fa-envelope\"></i>\r\n                ");
                __builder2.AddMarkupContent(28, "<label for=\"Email\">Email : </label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(29);
                __builder2.AddAttribute(30, "id", "email");
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "name", "email");
                __builder2.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\Controls\SignUpForm.razor"
                                                   person.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => person.Email = __value, person.Email))));
                __builder2.AddAttribute(35, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => person.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n        ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "input-icon");
                __builder2.AddAttribute(41, "style", "display:inline;");
                __builder2.AddMarkupContent(42, "<i class=\"fas fa-lock\"></i>\r\n                ");
                __builder2.AddMarkupContent(43, "<label for=\"password\">Password : </label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "id", "email");
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "name", "password");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\Controls\SignUpForm.razor"
                                                   person.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => person.Password = __value, person.Password))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => person.Password));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n        \r\n        \r\n        <input class=\"btn btn-common log-btn\" type=\"submit\" value=\"Register\">");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n");
            __builder.AddMarkupContent(53, @"<style>
.checkbox-item {
  display: inline-block;
  width: 100%;
}
.checkbox-item .checkbox {
  float: left;
  margin: 0;
}
.checkbox-item a {
  float: right;
}
    .log-btn {
  width: 100%;
  padding: 12px 22px;
  margin: 0px 0px 20px;
  letter-spacing: 1;
  text-transform: capitalize;
  font-size: 16px;
}
    .btn-common {
      background-color: #ff4f57;
      border: none;
      border-radius: 20px;
      text-transform: uppercase;
      overflow: hidden;
      position: relative;
    }
    .page-login-form {
  padding: 15px;
  background: #fff;
  box-shadow: 3px 3px 9px rgba(0, 0, 0, 0.075);
}
.page-login-form h3 {
  font-size: 18px;
  color: #444;
  line-height: 18px;
  padding: 15px 0 30px;
  text-transform: uppercase;
  text-align: center;
}
.page-login-form .login-form .form-control {
  background: #ffffff !important;
}
.page-login-form .log-btn {
  width: 100%;
  padding: 12px 22px;
  margin: 0px 0px 20px;
  letter-spacing: 1;
  text-transform: capitalize;
  font-size: 16px;
}
.login-form .input-icon i,
.cd-form .input-icon i {
  color: #444;
  opacity: 0.6;
  padding-right: 10px;
  margin-top: -3px;
}
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 92 "C:\Users\Home\Desktop\FinalProjectNew\FinalProjectNew\Client\Controls\SignUpForm.razor"
       
    string status = "Form is not submitted";
    void FormSubmitted() {
        status = "Form is submitted";
    }
    Person person = new Person {
        Name = "Ali",
        Email = "ali@gmail.com",
        Password = "abc"
    };

    public class Person {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
