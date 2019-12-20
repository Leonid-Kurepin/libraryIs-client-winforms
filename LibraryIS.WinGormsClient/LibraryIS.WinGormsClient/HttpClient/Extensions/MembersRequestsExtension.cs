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
    }
}
