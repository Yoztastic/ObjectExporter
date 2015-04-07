﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ObjectExporter.Core.Templates
{
    using System.Linq;
    using System.Text;
    using EnvDTE;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class CSharpGenerator : CSharpGeneratorBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            
            #line 9 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"

    if(CanBeExpressedAsSingleType(objectExpression.Type) || objectExpression.DataMembers.Count == 0)
    {
        ExportMembers(objectExpression, 0, true);
    }
    else
    {
        
            
            #line default
            #line hidden
            this.Write("var ");
            
            #line 16 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratorHelper.ResolveReservedNames(objectExpression.Name)));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 16 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"

        ExportMembers(objectExpression, 0, true);
    }

            
            #line default
            #line hidden
            this.Write(";\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 20 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"

    bool isFirstElement = true;

    public void ExportMembers(Expression expression, int recursionLevel, bool isLast)
    {
        //resolved reserved keywords such as class, this becomes @class.
        string expressionName = GeneratorHelper.ResolveReservedNames(expression.Name);

        if(!GeneratorHelper.IsSerializable(expressionName))
        {
            return;
        }
        else if(CanBeExpressedAsSingleType(expression.Type))
        {
            WriteLine("");
            
        
        #line default
        #line hidden
        
        #line 35 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(expressionName));

        
        #line default
        #line hidden
        
        #line 35 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"
this.Write(" = ");

        
        #line default
        #line hidden
        
        #line 35 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(GetSingleTypeValue(expression) + GeneratorHelper.WriteCommaIfNotLast(isLast)));

        
        #line default
        #line hidden
        
        #line 35 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"

        }
        else if (expression.DataMembers.Count == 0)
        {
            WriteLine("");
            if(expressionName.Contains("<") || expressionName.Contains(">") || expressionName.Contains("[") || expressionName.Contains("]"))
            {
                
        
        #line default
        #line hidden
        
        #line 42 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(expression.Value + GeneratorHelper.WriteCommaIfNotLast(isLast)));

        
        #line default
        #line hidden
        
        #line 42 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"

            }
            else
            {   
                
        
        #line default
        #line hidden
        
        #line 46 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(expressionName));

        
        #line default
        #line hidden
        
        #line 46 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"
this.Write(" = ");

        
        #line default
        #line hidden
        
        #line 46 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(expression.Value + GeneratorHelper.WriteCommaIfNotLast(isLast)));

        
        #line default
        #line hidden
        
        #line 46 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"

            }
        }
        else if (expression.DataMembers.Count > 0 && recursionLevel <= maxDepth)
        {
            //used for the very first object (top most) to be completed as var objName = new objType, without a space in between.
            if(isFirstElement)
            {
                isFirstElement = false;
            }
            else
            {
                WriteLine("");
            }

            if(GeneratorHelper.IsTypeOfCollection(expression.Type))
            {
                
        
        #line default
        #line hidden
        
        #line 63 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(expressionName));

        
        #line default
        #line hidden
        
        #line 63 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"
this.Write(" = new ");

        
        #line default
        #line hidden
        
        #line 63 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(expression.Type));

        
        #line default
        #line hidden
        
        #line 63 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"
 
                WriteLine(""); 
        
        #line default
        #line hidden
        
        #line 64 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"
this.Write("{");

        
        #line default
        #line hidden
        
        #line 64 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"

            }
            else
            {
                
        
        #line default
        #line hidden
        
        #line 68 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"
this.Write("new ");

        
        #line default
        #line hidden
        
        #line 68 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(expression.Type));

        
        #line default
        #line hidden
        
        #line 68 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"

                WriteLine(""); 
        
        #line default
        #line hidden
        
        #line 69 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"
this.Write("{");

        
        #line default
        #line hidden
        
        #line 69 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"

            }

            var expressionList = new List<Expression>();
            foreach(Expression exp in expression.DataMembers)
            {
                string resolvedExpressionName = GeneratorHelper.ResolveReservedNames(exp.Name);
                if(GeneratorHelper.IsSerializable(exp.Name)
                    && _propertyAccessibilityChecker.IsAccessiblePropertyOrField(resolvedExpressionName, expression.Type))                  
                {
                    expressionList.Add(exp);
                }
            }

            foreach(Expression exp in expressionList)
            {
                PushIndent("\t");
                bool isLastItem = expressionList.IsLast(exp);
                ExportMembers(exp, recursionLevel + 1, isLastItem);
                PopIndent();
            }

            WriteLine("");
            
        
        #line default
        #line hidden
        
        #line 92 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"
this.Write("}");

        
        #line default
        #line hidden
        
        #line 92 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"

            
        
        #line default
        #line hidden
        
        #line 93 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(GeneratorHelper.WriteCommaIfNotLast(isLast)));

        
        #line default
        #line hidden
        
        #line 93 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"

        }
    }

        
        #line default
        #line hidden
        
        #line 1 "C:\Users\Arel\Documents\GitHub\ObjectExporter\ObjectExporter.Core\Templates\CSharpGenerator.tt"

private global::EnvDTE.Expression _objectExpressionField;

/// <summary>
/// Access the objectExpression parameter of the template.
/// </summary>
private global::EnvDTE.Expression objectExpression
{
    get
    {
        return this._objectExpressionField;
    }
}

private int _maxDepthField;

/// <summary>
/// Access the maxDepth parameter of the template.
/// </summary>
private int maxDepth
{
    get
    {
        return this._maxDepthField;
    }
}


/// <summary>
/// Initialize the template
/// </summary>
public virtual void Initialize()
{
    if ((this.Errors.HasErrors == false))
    {
bool objectExpressionValueAcquired = false;
if (this.Session.ContainsKey("objectExpression"))
{
    this._objectExpressionField = ((global::EnvDTE.Expression)(this.Session["objectExpression"]));
    objectExpressionValueAcquired = true;
}
if ((objectExpressionValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("objectExpression");
    if ((data != null))
    {
        this._objectExpressionField = ((global::EnvDTE.Expression)(data));
    }
}
bool maxDepthValueAcquired = false;
if (this.Session.ContainsKey("maxDepth"))
{
    this._maxDepthField = ((int)(this.Session["maxDepth"]));
    maxDepthValueAcquired = true;
}
if ((maxDepthValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("maxDepth");
    if ((data != null))
    {
        this._maxDepthField = ((int)(data));
    }
}


    }
}


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class CSharpGeneratorBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
