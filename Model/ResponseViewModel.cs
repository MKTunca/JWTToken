using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminJwtToken.Model
{
    public class ResponseViewModel
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public TokenInfo TokenInfo { get; set; }
    }
}
