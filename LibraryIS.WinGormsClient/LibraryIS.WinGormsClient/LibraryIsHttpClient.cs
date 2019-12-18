using System;
using System.Net.Http;
using System.Threading.Tasks;
using LibraryIS.WinFormsClient.Dto;

namespace LibraryIS.WinFormsClient
{
    public class LibraryIsHttpClient : HttpClient
    {
        public LibraryIsHttpClient(string urlString)
        {
            this.BaseAddress = new Uri(urlString);

        }
        public async Task<bool> TryAuthenticateAsync(string email, string password)
        {
            var user = new UserDto
            {
                Email = email,
                Password = password
            };

            var response = await this.PostAsJsonAsync<UserDto>("api/users/authenticate", user);

            if (response.IsSuccessStatusCode)
            {
                var authorizedUser = await response.Content.ReadAsAsync<UserDto>();

                var accessToken = "Bearer " + authorizedUser.Token;

                this.DefaultRequestHeaders.Add("Authorization", accessToken);
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(accessToken);

                return true;
            }

            return false;
        }
    }
}
