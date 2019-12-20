using System;
using System.Net.Http;
using System.Threading.Tasks;
using LibraryIS.WinFormsClient.Dto;

namespace LibraryIS.WinFormsClient.HttpClient
{
    public class LibraryIsHttpClient : System.Net.Http.HttpClient
    {
        public LibraryIsHttpClient(string urlString)
        {
            this.BaseAddress = new Uri(urlString);

        }
        
       

    }
}
