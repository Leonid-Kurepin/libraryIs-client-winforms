using System.Net.Http;
using System.Threading.Tasks;
using LibraryIS.WinFormsClient.Dto;
using LibraryIS.WinFormsClient.HttpClient;

namespace LibraryIS.WinFormsClient.Requests
{
    public static class MembersRequests
    {
        public static async Task<PagedCollectionResponse<MemberDto>> GetMembersAsync(this LibraryIsHttpClient client)
        {
            //HTTP GET
            var response = await client.GetAsync("api/members");

            return await response.Content.ReadAsAsync<PagedCollectionResponse<MemberDto>>();
        }
    }
}
