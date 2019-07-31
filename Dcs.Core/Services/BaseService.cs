using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Dcs.Core.Services
{
    public class BaseService: IBaseService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public BaseService(
            IHttpContextAccessor httpContextAccessor
        )
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string UserId()
        {
            var claim = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
            var userId = claim?.Value;
            return userId;
        }
    }
}
