﻿using System.Threading.Tasks;
using Expenses.Api.Models.Login;
using Expenses.Data.Model;
using Expenses.Queries.Models;

namespace Expenses.Queries.Queries
{
    public interface ILoginQueryProcessor
    {
        UserWithToken Authenticate(string username, string password);
        Task<User> Register(RegisterModel model);
    }
}