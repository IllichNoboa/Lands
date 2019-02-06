namespace Lands.Models
{
    using System;
    using Newtonsoft.Json;
    using SQlite.Net.Attributes;

    public class TokenResponse
    {
        #region properties
        [JsonProperty(PropertyName ="access_token")]
        public String AccessToken { get; set; }

        [JsonProperty(PropertyName = "token_type")]
        public String TokenType { get; set; }

        [JsonProperty(PropertyName = "expire_in")]
        public String ExpireIn { get; set; }

        [JsonProperty(PropertyName = "userName")]
        public String UserName { get; set; }

        [JsonProperty(PropertyName = ".issued")]
        public String Issued { get; set; }

        [JsonProperty(PropertyName = ".expires")]
        public String Expires { get; set; }

        [JsonProperty(PropertyName = "error_description")]
        public String ErrorDescription { get; set; }

        public bool IsRemembered
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }
        #endregion

        #region Methods
        public override int GetHashCode()
        {
            return TokenResponseId;
        }
        #endregion

    }
}
