using DataConnection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningAJAX.Models
{
    public class IndexModel
    {
        public IEnumerable<User> users { get; set; }    
    }
}