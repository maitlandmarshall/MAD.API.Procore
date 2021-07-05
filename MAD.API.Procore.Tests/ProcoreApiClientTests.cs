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
        private const string SandboxAccessToken = "eyJhbGciOiJFUzUxMiJ9.eyJhaWQiOiJkODkwOTI4MDUxMjMyNmIwMGE2YjBlNTcwMzU3YjAzOWQyNzY5MDI4OTQ5ZDRhMzAwZDAwYjBmOGVkZWY2M2JkIiwiZXhwIjoxNTk2MTgzODEzLCJ1aWQiOjIxMjEyLCJ1dWlkIjoiZTlmY2IwOTktZDdmMi00YTJlLTg5OWEtMzAxZDNkY2JmYWMwIn0.AWsb3BXtb3vGE_I4iAD1RXN9O2kzUMv5qkAE502pS_H6AZUlKmg1gHSCwCNPGMScTgBIiGT7coQFT1ULT58-0SStAVmeT7n_tByeh5nIngIvzXnsJs4in4qMs2dk65GkZRH_200Sx8N2bXC0gPeIHb_cVXXCH9v5EEg9Dm3kNZGYpRw8";

        private ProcoreApiClient GetApiClient()
        {
            return new DefaultProcoreApiClientFactory().Create(new ProcoreApiClientOptions
            {
                RefreshToken = SandboxAccessToken,
                IsSandbox = true
            });
        }

        [TestMethod]
        public async Task CompaniesTest()
        {
            ProcoreApiClient apiClient = this.GetApiClient();

            var companies = await apiClient.GetResponseAsync(new ListCompaniesRequest());
        }

        [TestMethod]
        public async Task ProjectsTest()
        {
            ProcoreApiClient apiClient = this.GetApiClient();

            var companies = await apiClient.GetResponseAsync(new ListCompaniesRequest());

            foreach (var c in companies.Result)
            {
                var projectResponse = await apiClient.GetResponseAsync(new ListProjectsRequest { CompanyId = c.Id });
            }
        }

        [TestMethod]
        public async Task IncidentsTest()
        {
            ProcoreApiClient apiClient = this.GetApiClient();

            var companies = await apiClient.GetResponseAsync(new ListCompaniesRequest());

            foreach (var c in companies.Result)
            {
                var projectResponse = await apiClient.GetResponseAsync(new ListProjectsRequest { CompanyId = c.Id });

                foreach (var p in projectResponse.Result)
                {
                    var incidents = await apiClient.GetResponseAsync(new ListIncidentsRequest
                    {
                        ProjectId = p.Id
                    });
                }
            }
        }


        [TestMethod]
        public async Task CompanyUsersTest()
        {
            ProcoreApiClient apiClient = this.GetApiClient();

            var companies = await apiClient.GetResponseAsync(new ListCompaniesRequest());

            foreach (var c in companies.Result)
            {
                var usersResponse = await apiClient.GetResponseAsync(new ListCompanyUsersRequest { CompanyId = c.Id });
            }
        }

        [TestMethod]
        public async Task InspectionChecklistTest()
        {
            ProcoreApiClient apiClient = this.GetApiClient();

            var companies = await apiClient.GetResponseAsync(new ListCompaniesRequest());

            foreach (var c in companies.Result)
            {
                var projectResponse = await apiClient.GetResponseAsync(new ListProjectsRequest { CompanyId = c.Id });

                foreach (var p in projectResponse.Result)
                {
                    var inspectionChecklistResponse = await apiClient.GetResponseAsync(new ListChecklistsRequest
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

            var companies = await apiClient.GetResponseAsync(new ListCompaniesRequest());

            foreach (var c in companies.Result)
            {
                var projectResponse = await apiClient.GetResponseAsync(new ListProjectsRequest { CompanyId = c.Id });

                foreach (var p in projectResponse.Result)
                {
                    var inspectionChecklistResponse = await apiClient.GetResponseAsync(new ListChecklistTemplatesRequest
                    {
                        ProjectId = p.Id
                    });
                }
            }
        }
    }
}
