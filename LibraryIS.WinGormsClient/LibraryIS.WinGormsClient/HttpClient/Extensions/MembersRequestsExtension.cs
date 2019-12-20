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

        public static async Task<bool> DeleteMemberAsync(this LibraryIsHttpClient client, int memberId)
        {
            var deleteTask = client.DeleteAsync("api/members/" + memberId);
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
