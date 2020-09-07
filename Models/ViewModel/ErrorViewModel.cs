using System;


namespace ProjetoWebApplication.Models.ViewModel
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string Message  { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}