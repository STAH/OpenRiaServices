﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace OpenRiaServices.DomainServices.Tools.TextTemplate.CSharpGenerators
{
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Code\Repos\openriaservices\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpClientCodeGenerator.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class CSharpClientCodeGenerator : OpenRiaServices.DomainServices.Tools.TextTemplate.ClientCodeGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\n\n");
            
            #line 1 "C:\Code\Repos\openriaservices\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpClientCodeGenerator.tt"
 this.GenerateProxyClass(); 
            
            #line default
            #line hidden
            this.Write("\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
