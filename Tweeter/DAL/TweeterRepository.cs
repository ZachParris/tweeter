﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tweeter.DAL
{
    public class TweeterRepository
    {
        public TweeterContext Context { get; set; }
        public TweeterRepository(TweeterContext _context)
        {
            Context = _context;
        }

        public TweeterRepository() {}

        internal bool UsernameExists(string candidate)
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<string> GetUserNames()
        {
            throw new NotImplementedException();
        }
    }
}