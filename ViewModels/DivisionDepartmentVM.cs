using ACiS.Models;

namespace ACiS.ViewModels
{
    public class DivisionDepartmentVM
    {
        public int Id { get; set; }

        public int AcademicCode { get; set; }

        public string ArabicName { get; set; } = string.Empty;

        public string EnglishName { get; set; } = string.Empty;

        public int DepartmentId { get; set; }

        public IList<Department>? Departments { get; set; }
    }
}
