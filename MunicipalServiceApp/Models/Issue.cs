using System;

namespace MunicipalServicesApp.Models
{
    public class Issue
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string MediaPath { get; set; }
        public DateTime Submitted { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Submitted";
    }
}