using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpyTrail.Services.Interfaces
{
    public interface IAuthenticationService
    {
        bool IsLoggedIn();
        Task<bool> Login();
    }
}
