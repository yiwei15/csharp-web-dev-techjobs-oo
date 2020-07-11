﻿using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Job job3 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));
            Job job4 = new Job(null, new Employer(""), new Location(""), new PositionType(""), new CoreCompetency("")) ;
            Job job5 = new Job("Ice cream tester", new Employer(""), new Location(""), new PositionType("UX"), new CoreCompetency("Tasting ability"));
            Job job6 = new Job();
            List<Job> jobs = new List<Job>();

            jobs.Add(job1);
            jobs.Add(job2);
            jobs.Add(job3);
            jobs.Add(job4);
            jobs.Add(job5);
            jobs.Add(job6);

            foreach (Job job in jobs)
            {
                Console.WriteLine(job); 
            }

            //Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            //Console.WriteLine(job1.Name);
            //Console.WriteLine(job1);
            //Console.WriteLine(job1.Name + "***");
            //Console.WriteLine(0);
            //Console.WriteLine(job1.ToString());
        }
    }
}
