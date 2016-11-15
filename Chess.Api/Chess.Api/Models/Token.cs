using System;
using System.Runtime.Serialization;

namespace Chess.Api.Models
{
    [DataContract]
    public class Token
    {
        [DataMember(Name = "access_token")]
        public string AccessToken { get; set; }

        [DataMember(Name = "token_type")]
        public string TokenType { get; set; }

        [DataMember(Name = ".issued")]
        public DateTime IssuedUtc { get; set; }

        [DataMember(Name = ".expires")]
        public DateTime ExpiresUtc { get; set; }

        public bool IsExpired => ExpiresUtc.AddMinutes(-5) < DateTime.UtcNow;
    }

    public static class TokenExtentions
    {
        public static bool IsValid(this Token token) => !token?.IsExpired ?? false;
    }
}