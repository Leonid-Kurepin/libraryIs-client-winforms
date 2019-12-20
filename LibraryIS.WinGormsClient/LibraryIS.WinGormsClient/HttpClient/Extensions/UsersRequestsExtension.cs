using System.Net.Http;
using System.Threading.Tasks;
using LibraryIS.WinFormsClient.Dto;

namespace LibraryIS.WinFormsClient.HttpClient.Extensions
{
    public static class UsersRequestsExtension
    {
        public static async Task<PagedCollectionResponse<UserDto>> GetUsersAsync(this LibraryIsHttpClient client)
        {
            //HTTP GET
            var response = await client.GetAsync("api/users");

            return  await response.Content.ReadAsAsync<PagedCollectionResponse<UserDto>>();
        }
    }
}
