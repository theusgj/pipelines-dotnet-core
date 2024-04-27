using System;

namespace pipelines_dotnet_core.Models
{
    //first change
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}