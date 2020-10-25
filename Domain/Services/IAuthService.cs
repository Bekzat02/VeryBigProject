using DataTransfer.DTO.Auth;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
    public interface IAuthService
    {
        User Register(RegisterUserDTO dto);
        User SignIn();
    }
}
