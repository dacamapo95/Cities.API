namespace CityInfo.API.Entities.Security
{
    public class AuthenticationRequestBody
    {
        public string? UserName { get; set; }

        public string? Password { get; set; }
    }
}
