using MAD.API.Procore.Models;

namespace MAD.API.Procore.Requests
{
    public class InspectionChecklistSignatureRequestRequest : ProcoreRequest<ChecklistSignatureRequest>
    {
        public override string Resource
        {
            get => $"checklist/lists/{this.ListId}/signature_requests";
        }

        public long ListId { get; set; }

        [RequestParameter("project_id")]
        public long ProjectId { get; set; }
    }
}
