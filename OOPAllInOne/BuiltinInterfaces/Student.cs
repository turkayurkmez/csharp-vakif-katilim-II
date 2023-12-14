using System.Collections;

namespace BuiltinInterfaces
{
    public class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Score { get; set; }

        public int CompareTo(Student? other)
        {
            if (this.Score > other.Score)
            {
                return 1;
            }
            else if (this.Score < other.Score)
            {
                return -1;
            }
            return 0;
        }

        public override string ToString()
        {
            return $"{Name} - {Score}";
        }
    }

    public class ClassRoom : IEnumerable<Student>
    {
        private List<Student> students;

        public void AddStudent(Student student)
        {

            //if (students is null)
            //{
            //    students = new List<Student>();
            //}
            students = students ?? new List<Student>();
            students.Add(student);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            foreach (var student in students)
            {
                yield return student;
            }
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public List<Student> SortStudents()
        {
            students = students ?? throw new ArgumentNullException("students");
            students.Sort();
            return students;

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
