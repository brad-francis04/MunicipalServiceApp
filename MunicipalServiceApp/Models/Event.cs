using System;

namespace MunicipalServicesApp.Models
{
    public class Event : IComparable<Event>
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }

        public int CompareTo(Event other) => Date.CompareTo(other.Date);
    }
}
