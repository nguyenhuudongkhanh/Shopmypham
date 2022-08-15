using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangOnline.Models;

namespace WebBanHangOnline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {// GET: api/GetAllStudents
        private readonly BanHangOnlineContext _context;
        [HttpGet]
        public IEnumerable<Account> GetAllStudents()
        {
            List<Account> students = new List<Account>
           {
           new Account{
               Phone="123",
               Email="Khanh@gmail.com",
               Password="12345568",
               Salt="22360",


        },
           new Account{
               Phone="123",
               Email="Khanh@gmail.com",
               Password="12345568",
               Salt="22360",
                             },
           };
            return students;
        }
    }
}
