using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is JobField jobField &&
                   Id == jobField.Id;
        }

        public override int GetHashCode()   
        {
            return HashCode.Combine(Id);
        }

        //public override/virtual string ToString()      //ToString inheritated from Object class, do not need virtual/override ToString
        //{
        //    return Value;
        //}

        public override string ToString()   
        {
            if (Value != null && Value.Length !=0)
            {
                return Value;
            }   else
            {
                return "Data not available";
            }
        }
    }
}
