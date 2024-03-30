using Blazor_School_Management_System.Models;
using System.Net.Http.Json;

namespace Blazor_School_Management_System.Services
{
    public class FeeTypeService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl = "https://localhost:7225/api/FeeTypes";

        public FeeTypeService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<List<FeeType>> GetFeeTypesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<FeeType>>(_apiUrl);
        }

        public async Task<FeeType> GetFeeTypeByIdAsync(int id)
        {
            var url = $"{_apiUrl}/{id}";
            return await _httpClient.GetFromJsonAsync<FeeType>(url);
        }

        public async Task<FeeType?> CreateFeeTypeAsync(FeeType feeTypeData)
        {
            var response = await _httpClient.PostAsJsonAsync<FeeType>(_apiUrl, feeTypeData);
            var data = await response.Content.ReadFromJsonAsync<FeeType>();
            return data;
        }

        public async Task<bool> UpdateFeeTypeAsync(int id, FeeType feeTypeData)
        {
            var url = $"{_apiUrl}/{id}";

            var response = await _httpClient.PutAsJsonAsync<FeeType>(url, feeTypeData);
            return response.IsSuccessStatusCode;
        }

        public async Task DeleteFeeTypeAsync(int id)
        {
            var url = $"{_apiUrl}/{id}";
            await _httpClient.DeleteAsync(url);
        }
    }
}
