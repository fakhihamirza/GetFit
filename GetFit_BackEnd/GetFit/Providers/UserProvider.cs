using DataAccessLayer;
using DataAccessLayer.DTO;
using GetFit.Contracts;
using GetFit.DB_Context;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace GetFit.Providers
{
    public class UserProvider : UserContract
    {
        private readonly dbcontext db_context;
        private readonly string Private_Key;
        
        public UserProvider(dbcontext obj)
        {
            db_context = obj;
            Private_Key = "randomrandomrandomiptisshitiptisshitiwannadieiwannadie";
        }
        public User GetUser(int Id)
        {
            return db_context.User.FirstOrDefault(x => x.UserID == Id);
        }
        public void CreateUser(User _User)
        {
            if (_User == null)
            {
                throw new ArgumentNullException(nameof(_User));
            }
            db_context.User.Add(_User);
        }
        public bool SaveChanges()
        {
            return (db_context.SaveChanges() >= 0); //if changes then save
        }

        public string LoginUser(Login_user is_user)
        {
            User User = db_context.User.FirstOrDefault(user => user.UserName == is_user.UserName);
            string Provided_Password_Hash = BCrypt.Net.BCrypt.HashPassword(is_user.password);
            bool IsCorrect = BCrypt.Net.BCrypt.Verify(is_user.password, Provided_Password_Hash);
            if (User == null || !IsCorrect)
            {
                return null;
            }
            else
            {
                var Token_Handler = new JwtSecurityTokenHandler();
                var Token_Key = Encoding.ASCII.GetBytes(Private_Key);
                var Token_Descriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                    new Claim("UserID", User.UserID.ToString()),
                    new Claim("UserName", User.UserName),
                    new Claim("Name" , User.FirstName + " " + User.LastName)
                    }
                    ),

                    Expires = DateTime.UtcNow.AddDays(1),

                    SigningCredentials =
                    new SigningCredentials(new SymmetricSecurityKey(Token_Key),
                    SecurityAlgorithms.HmacSha256Signature)
                };
                var Initialized_Token = Token_Handler.CreateToken(Token_Descriptor);
                var Final_Token = Token_Handler.WriteToken(Initialized_Token);
                return Final_Token;
            }
        }
    }
}
