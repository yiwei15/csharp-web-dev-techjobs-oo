using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.


        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            if ((Name == null || Name.Length == 0) && (EmployerName== null ||EmployerName.Value == null|| EmployerName.Value.Length == 0)
                 && (EmployerLocation == null ||  EmployerLocation.Value == null || EmployerLocation.Value.Length == 0)
                 && (JobCoreCompetency == null || JobCoreCompetency.Value == null || JobCoreCompetency.Value.Length == 0))
            {
                return "\n" + "ID: " + Id+ "\nOOPS! This job does not seem to exist." + "\n";
            }

            else
            {

                string tempName;
            if (Name != null && Name.Length != 0)
            {
                tempName = Name;
            }
            else
            {
                tempName = "Data not available";
            }

            return "\n" + "ID: " + Id + "\nName: " + tempName + "\nEmployer: " + EmployerName
                + "\nLocation: " + EmployerLocation + "\nPosition Type: " + JobType
                + "\nCore Competency: " + JobCoreCompetency + "\n";

            }

            //if (
            //    Name.Length == 0)
            //{
            //    Name = "Data not available";
            //}

            //if (EmployerName.Value.Length == 0)
            //{
            //    EmployerName.Value = "Data not available";
            //}

            //if (EmployerLocation.Value.Length == 0)
            //{
            //    EmployerLocation.Value = "Data not available";
            //}

            //if (JobType.Value.Length == 0)
            //{
            //    JobType.Value = "Data not available";
            //}

            //if (JobCoreCompetency.Value.Length == 0)
            //{
            //    JobCoreCompetency.Value = "Data not available";
            //}

            //return "\n" + "ID: " + Id + "\nName: " + Name + "\nEmployer: " + EmployerName.Value
            //    + "\nLocation: " + EmployerLocation.Value + "\nPostion Type: " + JobType.Value
            //    + "\nCore Competency: " + JobCoreCompetency + "\n";

        }

    }
}
