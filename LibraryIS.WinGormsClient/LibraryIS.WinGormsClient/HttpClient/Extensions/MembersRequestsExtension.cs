using System.Net.Http;
using System.Threading.Tasks;
using LibraryIS.WinFormsClient.Dto;

namespace LibraryIS.WinFormsClient.HttpClient.Extensions
{
    public static class MembersRequests
    {
        public static async Task<PagedCollectionResponse<MemberDto>> GetMembersAsync(this LibraryIsHttpClient client)
        {
            //HTTP GET
            var response = await client.GetAsync("api/members");

            return await response.Content.ReadAsAsync<PagedCollectionResponse<MemberDto>>();
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
