using AutoMapper;
using DataAccessLayer;
using GetFit.Contracts;
using GetFit.Providers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetFit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserHistoryController : Controller
    {
        private UserHistoryContract user_contract;
        private readonly IMapper _Mapper;
        public UserHistoryController(UserHistoryContract obj, IMapper Mapper)
        {
            user_contract = obj;
            _Mapper = Mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReadHistory>> getresults()
        {
            int JWT_Claim_User_Id = Int32.Parse(User.FindFirst("Id").Value);
            var Blogs = user_contract.GetHistory(JWT_Claim_User_Id);
            return Ok(_Mapper.Map<IEnumerable<ReadHistory>>(Blogs));
            //test aa = new test();
        }

        [Route("~/api/addresult")]
        [HttpPost]
        public ActionResult Addresult(WriteHistory result)
        {
            int JWT_Claim_User_Id = Int32.Parse(User.FindFirst("Id").Value);
            var new_result = Mapper.Map<UserHistory>(result);
            new_result.UserID = JWT_Claim_User_Id;
            user_contract.Add(new_result);
            user_contract.SaveChanges();
            var Read_Blog = _Mapper.Map<ReadHistory>(new_result);
            return Ok();
        }
    }
    }
