using System;
using System.Linq.Expressions;
using System.Reflection;
using CodeCampServer.UI.Models.AutoMap;
using StructureMap;
using Tarantino.Core.Commons.Services.Security;

namespace CodeCampServer.UI.ViewPage
{
    public class BaseViewPage : System.Web.Mvc.ViewPage
    {
        private readonly IInputBuilderFactory _inputBuilderFactory;
        private readonly ISecurityContext _securityContext;

        public BaseViewPage()
        {
            _inputBuilderFactory = ObjectFactory.GetInstance<IInputBuilderFactory>();
            _securityContext = ObjectFactory.GetInstance<ISecurityContext>();
        }

        protected ISecurityContext SecurityContext
        {
            get { return _securityContext; }
        }

        protected IInputBuilder InputFor<TDto>(Expression<Func<TDto, object>> expression)
        {
            PropertyInfo property = ReflectionHelper.FindDtoProperty(expression);

            return new InputBuilder(property, Html, _inputBuilderFactory);
        }
    }
}