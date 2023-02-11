using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication117.Models
{
    public class UserInfo
    {
        public UserModel User { get; set; }
        public List<CallbackModel> Callbacks { get; set; }
    }
}
