using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Diagnostics;
using System.Net;

namespace DigiKala.WebAPI.HelperClassess.StandardOutput
{
    public class ApiResultFilterAttribute : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            if (context.Result is OkObjectResult okObjectResult)
            {
                var apiResult = new ApiResult<object>(true, ApiResultStatusCode.Success, okObjectResult.Value);
                context.Result = new JsonResult(apiResult) { StatusCode = okObjectResult.StatusCode };
            }
            else if (context.Result is OkResult okResult)
            {
                var apiResult = new ApiResult(true, ApiResultStatusCode.Success);
                context.Result = new JsonResult(apiResult) { StatusCode = okResult.StatusCode };
            }
            else if (context.Result is BadRequestResult badRequestResult)
            {
                var apiResult = new ApiResult(false, ApiResultStatusCode.BadRequest);
                context.Result = new JsonResult(apiResult) { StatusCode = badRequestResult.StatusCode };
            }
            if (context.Result is BadRequestObjectResult badRequest && !context.ModelState.IsValid)
            {
                var dic = new Dictionary<string, List<string>>();
                List<string> errors = new List<string>();
                foreach (var variable in context.ModelState.Values)
                    foreach (var error in variable.Errors)
                        errors.Add(error.ErrorMessage);
                dic.Add("errors", errors);
                // var message = context.ModelState.Values;
                // var apiResult = new ApiResult(false, ApiResultStatusCode.Success, message);
                var apiResult = new ApiResult<object>(false, ApiResultStatusCode.BadRequest, dic, "Validation error");
                context.Result = new JsonResult(apiResult) { StatusCode = (int)HttpStatusCode.UnprocessableEntity };
            }
            else if (context.Result is BadRequestObjectResult badRequestObjectResult)
            {
                var message = badRequestObjectResult.Value.ToString();
                if (badRequestObjectResult.Value is SerializableError errors)
                {
                    var errorMessages = errors.SelectMany(p => (string[])p.Value).Distinct();
                    message = string.Join(" | ", errorMessages);
                }
                var apiResult = new ApiResult(false, ApiResultStatusCode.BadRequest, message);
                context.Result = new JsonResult(apiResult) { StatusCode = (int)HttpStatusCode.UnprocessableEntity };
            }
            else if (context.Result is ContentResult contentResult)
            {
                var apiResult = new ApiResult(true, ApiResultStatusCode.Success, contentResult.Content);
                context.Result = new JsonResult(apiResult) { StatusCode = contentResult.StatusCode };
            }
            else if (context.Result is NotFoundResult notFoundResult)
            {
                var apiResult = new ApiResult(false, ApiResultStatusCode.NotFound);
                context.Result = new JsonResult(apiResult) { StatusCode = notFoundResult.StatusCode };
            }
            else if (context.Result is NotFoundObjectResult notFoundObjectResult)
            {
                var apiResult = new ApiResult(false, ApiResultStatusCode.NotFound, notFoundObjectResult.Value.ToString());
                context.Result = new JsonResult(apiResult) { StatusCode = notFoundObjectResult.StatusCode };
            }
            else if (context.Result is ObjectResult objectResult && objectResult.StatusCode == null
                && !(objectResult.Value is ApiResult))
            {
                var apiResult = new ApiResult<object>(true, ApiResultStatusCode.Success, objectResult.Value);
                context.Result = new JsonResult(apiResult) { StatusCode = objectResult.StatusCode };
            }

            base.OnResultExecuting(context);
        }
    }

    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ApiResult
    {
        public bool IsSuccess { get; set; }
        public ApiResultStatusCode StatusCode { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ReferenceId { get; set; }


        public ApiResult(bool isSuccess, ApiResultStatusCode statusCode, string message = null)
        {
            IsSuccess = isSuccess;
            StatusCode = statusCode;
            Message = message ?? statusCode.ToDisplay();
            //ReferenceId = Activity.Current.GetTraceId();
        }

        #region Implicit Operators
        public static implicit operator ApiResult(OkResult result)
        {
            return new ApiResult(true, ApiResultStatusCode.Success);
        }

        public static implicit operator ApiResult(BadRequestResult result)
        {
            return new ApiResult(false, ApiResultStatusCode.BadRequest);
        }

        public static implicit operator ApiResult(BadRequestObjectResult result)
        {
            var message = result.Value.ToString();
            if (result.Value is SerializableError errors)
            {
                var errorMessages = errors.SelectMany(p => (string[])p.Value).Distinct();
                message = string.Join(" | ", errorMessages);
            }
            return new ApiResult(false, ApiResultStatusCode.BadRequest, message);
        }

        public static implicit operator ApiResult(ContentResult result)
        {
            return new ApiResult(true, ApiResultStatusCode.Success, result.Content);
        }

        public static implicit operator ApiResult(NotFoundResult result)
        {
            return new ApiResult(false, ApiResultStatusCode.NotFound);
        }
        #endregion
    }
}
