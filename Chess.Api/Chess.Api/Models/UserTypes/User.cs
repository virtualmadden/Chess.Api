using System;

namespace Chess.Api.Models.UserTypes
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string HashedPassword { get; set; }

        public static User Create(string userName)
        {
            throw new NotImplementedException();
        }

        public static User Retrieve()
        {
            throw new NotImplementedException();
        }
    }
}