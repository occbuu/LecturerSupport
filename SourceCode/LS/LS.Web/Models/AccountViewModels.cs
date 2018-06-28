using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using M = System.Web.Mvc;

namespace LS.Web.Models
{
    using Utility;

    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeVM
    {
        #region -- Methods --

        #region -- Constructor --
        /// <summary>
        /// Demo only
        /// </summary>
        public SendCodeVM() { }
        #endregion

        #region -- Convert --
        /// <summary>
        /// Convert from SendCodeDto to SendCodeVM
        /// </summary>
        /// <param name="m">SendCodeDto</param>
        /// <returns>Return the SendCodeVM</returns>
        public static SendCodeVM Convert(SendCodeDto m)
        {
            if (m == null)
            {
                return new SendCodeVM();
            }

            var res = new SendCodeVM
            {
                SelectedProvider = m.SelectedProvider,
                ReturnUrl = m.ReturnUrl,
                RememberMe = m.RememberMe
            };
            return res;
        }

        /// <summary>
        /// Convert from list SendCodeDto to list SendCodeVM
        /// </summary>
        /// <param name="m">List SendCodeDto</param>
        /// <returns>Return the list SendCodeVM</returns>
        public static List<SendCodeVM> Convert(List<SendCodeDto> list)
        {
            if (list == null)
            {
                return new List<SendCodeVM>();
            }

            var res = from m in list
                      select new SendCodeVM
                      {
                          SelectedProvider = m.SelectedProvider,
                          ReturnUrl = m.ReturnUrl,
                          RememberMe = m.RememberMe
                      };
            return res.ToList();
        }
        #endregion

        #endregion

        #region -- Properties --

        public string SelectedProvider { get; set; }

        public ICollection<M.SelectListItem> Providers { get; set; }

        public string ReturnUrl { get; set; }

        public bool RememberMe { get; set; }

        #endregion
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }

        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}