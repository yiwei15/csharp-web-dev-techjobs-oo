﻿using System;
namespace TechJobsOO
{
    public class PositionType: JobField
    {
        public PositionType(string value):base(value)
        {
            //Value = value;
        }


        //public int Id { get; }
        //private static int nextId = 1;
        //public string Value { get; set; }

        //public PositionType()
        //{
        //    Id = nextId;
        //    nextId++;
        //}

        //public PositionType(string value) : this()
        //{
        //    Value = value;
        //}

        //// TODO: Add custom Equals(), GetHashCode(), and ToString() methods.
        //public override string ToString()
        //{
        //    return Value;
        //}

        //public override bool Equals(object obj)
        //{
        //    return obj is PositionType positionType &&
        //        Id == positionType.Id;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Id);
        //}

        //public override string ToString()
        //{
        //    return Value;
        //}

    }
}
