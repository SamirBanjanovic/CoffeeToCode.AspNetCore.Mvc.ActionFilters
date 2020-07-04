using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CoffeeToCode.AspNetCore.Mvc.ActionFilters
{
    public class ContentInjector
        : TypeFilterAttribute
    {
        public ContentInjector(string parameter, string source, string path)
            : base(typeof(ContentInjectorImpl))
        {
            Arguments = new object[] { parameter, source, path };
        }

        private class ContentInjectorImpl
        {
            private readonly string _parameter;
            private readonly string _source;
            private readonly string _path;

            public ContentInjectorImpl(string parameter, string source, string path)
            {
                _parameter = parameter;
                _source = source;
                _path = path;
            }

            public void OnActionExecuting(ActionExecutingContext context)
            {

            }

            public void OnActionExecuted(ActionExecutedContext context)
            {
            }
        }
    }
}
