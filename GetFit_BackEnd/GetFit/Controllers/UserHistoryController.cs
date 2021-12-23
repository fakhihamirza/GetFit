using AutoMapper;
using DataAccessLayer;
using DataAccessLayer.DTO;
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
    public class UserHistoryController : Controller
    {
        private UserHistoryContract user_contract;
        private readonly IMapper _Mapper;
        public UserHistoryController(UserHistoryContract obj, IMapper Mapper)
        {
            user_contract = obj;
            _Mapper = Mapper;
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<ReadHistory>> getresults(int id)
        {
            var results = user_contract.GetHistory(id);
            return Ok(_Mapper.Map<IEnumerable<ReadHistory>>(results));
        }



        [Route("~/api/addresult")]
        [HttpPost]
        public ActionResult Addresult(WriteHistory result)
        {
            var new_result = (UserHistory)_Mapper.Map<UserHistory>(result);
            user_contract.Add(new_result);
            user_contract.SaveChanges();
            return Ok();
        }
    }
    }
