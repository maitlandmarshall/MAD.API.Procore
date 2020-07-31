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
        private const string SandboxAccessToken = "eyJhbGciOiJFUzUxMiJ9.eyJhaWQiOiJkODkwOTI4MDUxMjMyNmIwMGE2YjBlNTcwMzU3YjAzOWQyNzY5MDI4OTQ5ZDRhMzAwZDAwYjBmOGVkZWY2M2JkIiwiZXhwIjoxNTk2MTY3NTAwLCJ1aWQiOjIxMjEyLCJ1dWlkIjoiZTlmY2IwOTktZDdmMi00YTJlLTg5OWEtMzAxZDNkY2JmYWMwIn0.AcYBUYmOS2L-f4C2F05kOwVvMetqI9A2sudejqyTk3T2GVN-k_7n7QpxpY5_qky8gcTf2VbJHRT0l2tBIyB4aptaAWqedTZcLKoIWOhYH_seNCi2PV14RbHaLa5_507cdSzTdQGh4attiLtbrMde_Rrchhy4_fTlqE-VDVkjtJ4owZLr";

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
