namespace GraphQL.API.Schema
{
    public class Query
    {
        private readonly IEnumerable<CourseType> _courses;

        public Query()
        {
            _courses = new List<CourseType>
            {
                new CourseType
                {
                    Id = Guid.NewGuid(),
                    Name = "Test",
                    Subject = Subject.Mathematics,
                    Instructor = new InstructorType
                    {
                        Id= Guid.NewGuid(),
                        FirstName = "Caioba",
                        LastName = "Ramos",
                        Salary = 1.0
                    },
                    Students = new List<StudentType>
                    {
                        new StudentType
                        {
                            Id= Guid.NewGuid(),
                            FirstName = "Nina",
                            LastName = "Amaral",
                            GPA = 1.2
                        },
                        new StudentType
                        {
                            Id= Guid.NewGuid(),
                            FirstName = "Miguelitos",
                            LastName = "Amaral",
                            GPA = 1.56
                        }
                    }
                }
            };
        }

        public IEnumerable<CourseType> GetCourses() => _courses;

        public CourseType? GetCourseById(Guid id) => _courses.FirstOrDefault(course => course.Id == id);

        [GraphQLDeprecated("This is just a test")]
        public string Instruction => "Qualquer coisa aqui apenas para ver funcionando";
    }
}
