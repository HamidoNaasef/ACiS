using System.Diagnostics.Metrics;
using System.Security.Cryptography;

namespace ACiS.Models
{
    public class Student: Person
    {

        public string? MiltaryStatus { get; set; } = string.Empty;

        public string? MiltaryId { get; set; } = string.Empty;

        public string Qualification { get; set; } = string.Empty;

        public Faculity? QualificationFaculity { get; set; }

        public string QualificationYear { get; set; } = string.Empty;

        public string? Notes { get; set; } = string.Empty;


    }
}
