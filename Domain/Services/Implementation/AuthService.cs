﻿using DataTransfer.DTO.Auth;
using Domain.Models;
using Domain.Repositories;
using Domain.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.Implementation
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;

        public AuthService(
            IUserRepository userRepository,
            IPasswordHasher passwordHasher)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
        }
        public User Register(RegisterUserDTO dto, string password)
        {
            _passwordHasher.CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
            User user = new User
            {
                RegisteredDate = DateTime.UtcNow,
                Role = Role.Customer,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Login = dto.Login,
            };
            _userRepository.Create(user);
            return user;
        }

        public User SignIn()
        {

        }
    }
}
