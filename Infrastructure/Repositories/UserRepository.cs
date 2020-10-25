using AutoMapper;
using Domain.Models;
using Domain.Repositories;
using Infrastructure.Data;
using Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly CanteenContext _db;
        private readonly IMapper _mapper;

        public UserRepository(
            CanteenContext db,
            IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public void Create(User user)
        {
            UserEntity userEntity = _mapper.Map<UserEntity>(user);
            _db.Users.Add(userEntity);
            _db.SaveChanges();
        }
    }
}
