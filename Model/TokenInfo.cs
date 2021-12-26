using System;

namespace AdminJwtToken.Model
{
    public class TokenInfo
    {
        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}