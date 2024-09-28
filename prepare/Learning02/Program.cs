using System;
class Program {

static void Main(string[] args)
{
    Job job1 = new Job();
    job1._jobTitle = "Carpenter";
    job1._company = "Francovich";
    job1._startYear = 2018;
    job1._endYear = 2020;


    Job job2 = new Job();
    job2._jobTitle = "Administrative Assistant";
    job2._company = "Coto";
    job2._startYear = 2020;
    job2._endYear = 2024;

    Resume MyResume = new Resume();
    MyResume._name = "Mauro Villaba";
    MyResume._jobs.Add(job1);
    MyResume._jobs.Add(job2);

    MyResume.DisplayResume();
    
}
}