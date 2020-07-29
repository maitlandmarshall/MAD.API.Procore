using MAD.API.Procore.Models;
using MAD.API.Procore.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MAD.API.Procore.Tests
{
    [TestClass]
    public class ProcoreApiClientTests
    {
        private const string SandboxAccessToken = "eyJhbGciOiJFUzUxMiJ9.eyJhaWQiOiJkODkwOTI4MDUxMjMyNmIwMGE2YjBlNTcwMzU3YjAzOWQyNzY5MDI4OTQ5ZDRhMzAwZDAwYjBmOGVkZWY2M2JkIiwiZXhwIjoxNTk1OTM5NTE3LCJ1aWQiOjIxMjEyLCJ1dWlkIjoiZTlmY2IwOTktZDdmMi00YTJlLTg5OWEtMzAxZDNkY2JmYWMwIn0.ATpmI3vtzHsBSf0Zfw7icIf8PRdrVqqYsb9F0ESS_Q5sWh_na0AfjImAKwN3xzOmF4EXcSuHDhxbWsY4XZNHVTawAc6221Vw3VCYzMe_3V-KeZ_eSE7Y5ikjMA8UWUriOXjnG1xxMo3Hh_buWQjjTT2lh-sBR7TrcjiBO2Pj2qXmef86";

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

        [TestMethod]
        public async Task InspectionChecklistTest()
        {
            ProcoreApiClient apiClient = this.GetApiClient();

            ProcoreResponse<Company> companies = await apiClient.GetResponseAsync(new CompanyRequest());

            foreach (var c in companies.Items)
            {
                var projectResponse = await apiClient.GetResponseAsync(new ProjectsRequest { CompanyId = c.Id });

                foreach (var p in projectResponse.Items)
                {
                    var inspectionChecklistResponse = await apiClient.GetResponseAsync(new InspectionChecklistRequest
                    {
                        ProjectId = p.Id
                    });
                }
            }
        }

        [TestMethod]
        public async Task InspectionChecklistTemplateTest()
        {
            ProcoreApiClient apiClient = this.GetApiClient();
            ProcoreResponse<Company> companies = await apiClient.GetResponseAsync(new CompanyRequest());

            foreach (var c in companies.Items)
            {
                var projectResponse = await apiClient.GetResponseAsync(new ProjectsRequest { CompanyId = c.Id });

                foreach (var p in projectResponse.Items)
                {
                    var response = await apiClient.GetResponseAsync(new InspectionChecklistTemplateRequest
                    {
                        ProjectId = p.Id
                    });
                }
            }
        }
    }
}
