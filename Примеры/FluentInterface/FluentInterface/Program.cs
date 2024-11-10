namespace FluentInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = PersonBuilder
                .Create()
                    .WithName("Bob")
                    .HavingJob(builder => builder
                        .WithSalary(1000)
                        .WithCompanyName("Intel"))
                    .HavingJob(builder => builder
                        .WithSalary(2000)
                        .WithCompanyName("Google"))
               .Build();
        }

        public class Person
        {
            public string Name { get; set; }
            public IList<Job> Jobs { get; set; } = new List<Job>();
            public IList<Phone> Phones { get; set; } = new List<Phone>();
        }

        public class Phone
        {
            public string Number { get; set; }
            public string Usage { get; set; }
        }

        public class Job
        {
            public string CompanyName { get; set; }
            public int Salary { get; set; }
        }

        public interface IJobBuilder
        {
            IJobBuilder WithCompanyName(string companyName);
            IJobBuilder WithSalary(int salary);
        }

        public class JobBuilder : IJobBuilder
        {
            private readonly Job job;

            public JobBuilder()
            {
                job = new Job();
            }

            public IJobBuilder WithCompanyName(string companyName)
            {
                job.CompanyName = companyName;
                return this;
            }

            public IJobBuilder WithSalary(int salary)
            {
                job.Salary = salary;
                return this;
            }

            public Job Build() => job;
        }

        public class PersonBuilder
        {
            private readonly Person person;

            public PersonBuilder()
            {
                person = new Person();
            }

            public static PersonBuilder Create() => new PersonBuilder();

            public PersonBuilder WithName(string name)
            {
                person.Name = name;
                return this;
            }

            public PersonBuilder HavingJob(Action<IJobBuilder> configure)
            {
                var builder = new JobBuilder();

                configure(builder);

                person.Jobs.Add(builder.Build());

                return this;
            }

            public Person Build() => person;
        }
    }
}
