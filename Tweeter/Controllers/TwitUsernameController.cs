using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tweeter.DAL;

namespace Tweeter.Controllers
{
    public class TwitUsernameController : ApiController
    {
        TweeterRepository repo = new TweeterRepository();

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return repo.GetUserNames();
        }

        // GET api/<controller>/5
        public bool Get(string candidate)
        {
            return repo.UsernameExists(candidate);
        }
    }
}