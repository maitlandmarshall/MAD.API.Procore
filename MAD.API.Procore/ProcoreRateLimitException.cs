using System;

namespace MAD.API.Procore
{
    public class ProcoreRateLimitException : Exception
    {
        public DateTimeOffset RefreshDate { get; set; }

        public ProcoreRateLimitException(DateTimeOffset refreshDate) : base($"Procore API rate limit exceeded. API rate limit will reset at {refreshDate.DateTime.ToLocalTime():dd/MM/yyyy HH:mm:ss}")
        {
            this.RefreshDate = refreshDate;
        }
    }
}
