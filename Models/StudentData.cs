namespace ACiS.Models
{
    public class StudentData
    {
        public int Id { get; set; }

        public Student? student { get; set; }

        public Status? status { get; set; }

        public Stage? stage { get; set; }

        public Department? Department { get; set; }

        public Division? division { get; set; }


        public DateTime RegstrationDate { get; set; }



    }
}
