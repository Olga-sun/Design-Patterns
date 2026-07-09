using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Handlers
{
    public abstract class BaseHandler
    {
        protected BaseHandler _nextHandler;
        public BaseHandler SetNext(BaseHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }
        public abstract void Handle();
    }
}
