using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebApplication5.Models;
using WebApplication5.Middleware;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IConfiguration configuration;
        private readonly RepoUser GetDataRepo;
        public UserController(IConfiguration config) {
            configuration = config;
            GetDataRepo = new RepoUser(config.GetSection("ConnectionString").Value);
        }
        // GET api/values
        [Route("GetUser")]
        [HttpGet]
        public ActionResult<dynamic> GetDataUser()
        {
            dynamic result;
            try
            {
                result = GetDataRepo.getUser("");    
                return result;
            }
            catch (Exception ex){
                result = new
                {
                    code = (int)HttpStatusCode.BadRequest,
                    message = ex.Message
                };
                return StatusCode(result.code, result);
            }
        }

        [Route("GetUserByID")]
        [HttpGet]
        public ActionResult<dynamic> GetDataUserByID([FromQuery] string ID)
        {
            dynamic result;
            DataTable table;
            try
            {
                table = GetDataRepo.getUser(ID);
                List<User> list = new List<User>();
                list = Func.ConvertDataTable<User>(table);
                return list;
            }
            catch (Exception ex){
                result = new
                {
                    code = (int)HttpStatusCode.BadRequest,
                    message = ex.Message
                };
                return StatusCode(result.code, result);
            }
        }

        [Route("Encrypt")]
        [HttpGet]
        public ActionResult<dynamic> Encrypt([FromQuery] string ID)
        {
            dynamic result;
            try
            {
                string text = Func.Encrypt(ID);
                result = new
                {
                    code = (int)HttpStatusCode.OK,
                    message = text
                };
            }
            catch (Exception ex)
            {
                result = new
                {
                    code = (int)HttpStatusCode.BadRequest,
                    message = ex.Message
                };
                
            }
            return StatusCode(result.code, result);
        }

        [Route("Decrypt")]
        [HttpGet]
        public ActionResult<dynamic> Decrypt([FromQuery] string ID)
        {
            dynamic result;
            try
            {
                string text = Func.Decrypt(ID);
                result = new
                {
                    code = (int)HttpStatusCode.OK,
                    message = text
                };
            }
            catch (Exception ex)
            {
                result = new
                {
                    code = (int)HttpStatusCode.BadRequest,
                    message = ex.Message
                };

            }
            return StatusCode(result.code, result);
        }

        [Route("CreateUser")]
        [HttpPost]
        public ActionResult<dynamic> CreateUser([FromQuery] CreateUser value)
        {
            bool create = false;
            dynamic result;
            try
            {
                create = GetDataRepo.createUser(value);
                result = new
                {
                    code = (int)HttpStatusCode.OK,
                    message = HttpStatusCode.OK.ToString()
                };
            }
            catch(Exception ex) {

                result = new
                {
                    code = (int)HttpStatusCode.BadRequest,
                    message = ex.Message
                };
            }
            return StatusCode(result.code, result);
        }

        // PUT api/values/5
        //[HttpPut("UpdateUser")]
        //public ActionResult<dynamic> Put([FromQuery] CreateUser value)
        //{
        //    bool create = false;
        //    dynamic result;
        //    try
        //    {
        //        create = GetDataRepo.createUser(value);
        //        result = new
        //        {
        //            code = (int)HttpStatusCode.OK,
        //            message = HttpStatusCode.OK.ToString()
        //        };
        //    }
        //    catch (Exception ex)
        //    {

        //        result = new
        //        {
        //            code = (int)HttpStatusCode.BadRequest,
        //            message = ex.Message
        //        };
        //    }
        //    return StatusCode(result.code, result);
        //}

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
