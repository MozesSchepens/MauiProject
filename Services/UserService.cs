using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiProject.Services
{
    public enum UserRole { Admin, User }

    public static class UserService
    {
        public static UserRole CurrentUserRole { get; set; } = UserRole.Admin;
    }
}