using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreBackpack.Services
{
    public interface IAuthenticationService
    {
        long GetUserId();
    }

    public class AuthenticationService : IAuthenticationService
    {
        readonly IHttpContextAccessor httpContextAccessor;

        public long GetUserId()
        {
            return Convert.ToInt64(httpContextAccessor.HttpContext.User.FindFirst("sub").Value);
        }
    }
}
