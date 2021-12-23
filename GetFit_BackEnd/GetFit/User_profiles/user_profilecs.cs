using AutoMapper;
using DataAccessLayer;
using DataAccessLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetFit.User_profiles
{
    public class user_profilecs : Profile 
    {
        public user_profilecs()
        {
            CreateMap<User, Register_user>();
            CreateMap<Register_user, User>();
            CreateMap<Get_User, User>();
            CreateMap<UserHistory, WriteHistory>();
            CreateMap<WriteHistory, UserHistory>();
            CreateMap<ReadHistory, UserHistory>();
            CreateMap<UserHistory, ReadHistory>();
            CreateMap<User, Get_User>();
            //CreateMap<WriteExternalEmployee, Employee>();
        }
    }
}
