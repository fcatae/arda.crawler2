﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Arda.Crawler.Controllers
{
    [Route("api/[controller]")]
    public class ReceiverController : Controller
    {
        static List<string> _messages = new List<string>();

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _messages;
        }

        [HttpGet("add")]
        public void Get([FromQuery]string value)
        {
            _messages.Add(value);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]object obj)
        {
            string value = JsonConvert.SerializeObject(obj);

            _messages.Add(value);
        }
       
    }
}
