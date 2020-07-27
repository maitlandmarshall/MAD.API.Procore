using MAD.API.Procore.Models;
using MAD.API.Procore.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace MAD.API.Procore.Tests
{
    [TestClass]
    public class ProcoreApiClientTests
    {
        private const string SandboxAccessToken = "eyJhbGciOiJFUzUxMiJ9.eyJhaWQiOiJkODkwOTI4MDUxMjMyNmIwMGE2YjBlNTcwMzU3YjAzOWQyNzY5MDI4OTQ5ZDRhMzAwZDAwYjBmOGVkZWY2M2JkIiwiZXhwIjoxNTk1ODI5NTk0LCJ1aWQiOjIxMjEyLCJ1dWlkIjoiZTlmY2IwOTktZDdmMi00YTJlLTg5OWEtMzAxZDNkY2JmYWMwIn0.AZiKCGfiSYyf3HerQACsNSZo4Lhx8i-HbdAJQLNk4LF5J-t0sB7_gWJauJnaFyw0Cmh9WBf01rh96lAxrIaTkfiNATvqUMRz5IY7vVju_aYCNTFhCsNnD74ibeo0p4qjs1GUgjah7T-f4qyoMpABXvw8vDofdLEN-qAHRcgpAX0JSCO7";

        private ProcoreApiClient GetApiClient()
        {
            return new DefaultProcoreApiClientFactory().Create(new ProcoreApiClientOptions
            {
                AccessToken = SandboxAccessToken,
                IsSandbox = true
            });
        }

        [TestMethod]
        public async Task CompaniesTest()
        {
            ProcoreApiClient apiClient = this.GetApiClient();

            ProcoreResponse<Company> companies = await apiClient.GetResponseAsync(new CompanyRequest());
        }

        [TestMethod]
        public async Task ProjectsTest()
        {
            ProcoreApiClient apiClient = this.GetApiClient();

            ProcoreResponse<Company> companies = await apiClient.GetResponseAsync(new CompanyRequest());

            foreach (var c in companies.Items)
            {
                var projectResponse = await apiClient.GetResponseAsync(new ProjectsRequest { CompanyId = c.Id });
            }
        }

        [TestMethod]
        public async Task CompanyUsersTest()
        {
            ProcoreApiClient apiClient = this.GetApiClient();

            ProcoreResponse<Company> companies = await apiClient.GetResponseAsync(new CompanyRequest());

            foreach (var c in companies.Items)
            {
                var usersResponse = await apiClient.GetResponseAsync(new CompanyUserRequest { CompanyId = c.Id });
            }
        }
    }
}
