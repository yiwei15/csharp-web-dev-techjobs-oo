using System;
namespace TechJobsOO
{
    public class CoreCompetency: JobField
    {
        public CoreCompetency(string value) : base(value)
        {
            //Value = value;    // CoreCompetency constructor invokes base class constructor and set value
        }

        //private int id { get; set; }
        //private static int nextId = 1;
        ////private string value { get; set; }
        //public string Value { get; set; }

        //// TODO: Change the fields to auto-implemented properties.

        //public CoreCompetency()
        //{
        //    id = nextId;
        //    nextId++;
        //}

        //public CoreCompetency(string value) : this()
        //{
        //    Value = value;
        //}

        //public override bool Equals(object obj)
        //{
        //    return obj is CoreCompetency competency &&
        //           id == competency.id;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(id);
        //}

        //public override string ToString()
        //{
        //    return Value;
        //}
    }

}
