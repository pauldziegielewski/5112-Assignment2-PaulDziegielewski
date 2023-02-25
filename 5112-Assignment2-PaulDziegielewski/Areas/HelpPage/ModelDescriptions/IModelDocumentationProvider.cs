using System;
using System.Reflection;

namespace _5112_Assignment2_PaulDziegielewski.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}