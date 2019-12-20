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

            return await response.Content.ReadAsAsync<PagedCollectionResponse<UserDto>>();
        }

        public static async Task<bool> AddUserAsync(this LibraryIsHttpClient client, UserDto userDto)
        {

            var postTask = client.PostAsJsonAsync<UserDto>("api/users", userDto);
            postTask.Wait();

            var result = postTask.Result;

            if (result.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }

        public static async Task<bool> DeleteUserAsync(this LibraryIsHttpClient client, int userId)
        {
            var deleteTask = client.DeleteAsync("api/users/" + userId);
            deleteTask.Wait();

            var result = deleteTask.Result;

            if (result.IsSuccessStatusCode)
            {
                return true;

            }

            return false;
        }
    }
}
