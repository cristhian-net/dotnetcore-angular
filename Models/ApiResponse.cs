using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace dotnetcore.Models
{
    public class ApiResponse
    {
        public bool Status { get; set; }
        public Customer Customer { get; set; }
        public ModelStateDictionary ModelState { get; set; }
    }
}