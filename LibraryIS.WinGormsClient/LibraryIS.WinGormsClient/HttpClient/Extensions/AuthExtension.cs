using System.Net.Http;
using System.Threading.Tasks;
using LibraryIS.WinFormsClient.Dto;

namespace LibraryIS.WinFormsClient.HttpClient.Extensions
{
    public static class AuthExtension
    {
        public static async Task<bool> TryAuthenticateAsync(this LibraryIsHttpClient client, string email, string password)
        {
            var user = new UserDto
            {
                Email = email,
                Password = password
            };

            var response = await client.PostAsJsonAsync<UserDto>("api/users/authenticate", user);

            if (response.IsSuccessStatusCode)
            {
                var authorizedUser = await response.Content.ReadAsAsync<UserDto>();

                var accessToken = "Bearer " + authorizedUser.Token;

                client.DefaultRequestHeaders.Add("Authorization", accessToken);
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(accessToken);

                return true;
            }

            return false;
        }
    }
}
