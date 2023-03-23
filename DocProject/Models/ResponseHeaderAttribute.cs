using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace DocProject.Models
{
    public class ResponseHeaderAttribute:ActionFilterAttribute
    {
        private readonly string _name;
        private readonly string _value;

        public ResponseHeaderAttribute( string name, string value)
        {
            this._name = name;
            this._value = value;
        }
        int date1 = 0;
        int date2 = 0;
        public override void OnActionExecuted(ActionExecutedContext context)
        {
           date1 = DateTime.Now.Millisecond;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            date2= DateTime.Now.Millisecond;
        }
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            int time = date1- date2;

            context.HttpContext.Response.Headers.Add(_name,_value);
            context.HttpContext.Response.Headers.Add("Response-Time", time.ToString());
        }
    }
}
