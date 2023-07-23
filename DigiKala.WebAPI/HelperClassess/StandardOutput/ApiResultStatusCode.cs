using System.ComponentModel.DataAnnotations;

namespace DigiKala.WebAPI.HelperClassess.StandardOutput
{
    public enum ApiResultStatusCode
    {
        //[Display(Name = "عملیات با موفقیت انجام شد")]
        [Display(Name = "Your operation successfully done")]
        Success = 0,

        //[Display(Name = "خطایی در سرور رخ داده است")]
        [Display(Name = "Internal server error")]
        ServerError = 1,

        //[Display(Name = "پارامتر های ارسالی معتبر نیستند")]
        [Display(Name = "Error in parameters")]
        BadRequest = 2,

        //[Display(Name = "یافت نشد")]
        [Display(Name = "Not found")]
        NotFound = 3,

        [Display(Name = "Empty list")]
        ListEmpty = 4,

        //[Display(Name = "خطایی در پردازش رخ داد")]
        [Display(Name = "Logical error")]
        LogicError = 5,

        //[Display(Name = "خطای احراز هویت")]
        [Display(Name = "UnAuthorized")]
        UnAuthorized = 6,

        [Display(Name = "Max Attempts Faild")]
        MaxAttemptsFaild = 7,
    }
}
