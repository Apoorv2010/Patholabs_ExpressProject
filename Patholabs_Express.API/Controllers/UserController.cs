﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Patholabs_Express.BuisnessLogic.DTOs;
using Patholabs_Express.BuisnessLogic.Services;
using Patholabs_Express.DataAccess.Entities;
using System.Web.Http.Cors;

namespace Patholabs_Express.API.Controllers
{
    //[EnableCors(origins: "http://www.example.com", headers: "*", methods: "*")]
    //[DisableCors]
    public class UserController : ApiController
    {
        private readonly UserService userService;
        private readonly User_ApplicationService userAppService;

        public UserController()
        {
            userService = new UserService();
            userAppService = new User_ApplicationService();
        }
        [HttpPost]
        public IHttpActionResult Add([FromBody] UserDto obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
               if( userService.Add(obj))
                {
                    userAppService.Add(obj);
                    return Ok(new Responce() { Success = true, Message = "User Registered Successfully" });
                }
               else
                return Ok(new Responce() { Success = false, Message = "User Registered Successfully" });



            }

        }

        [HttpPut]
        public IHttpActionResult UpdateUserDetails([FromBody] UserDto obj)

        {
            var item = userService.UpdateUserDetails(obj);
            if (item == true)
            {
                return Ok(new Responce() { Success = true, Message = "User details updated successfully" });
            }
            else
                return BadRequest();
        }


        [HttpGet]
        public IHttpActionResult Get()
        {

            return Ok(new Responce() { Success = true, Message = "User Details Fetched Successfully", Result = userService.getall() });

        }
    }
}
