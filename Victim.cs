public class Victim
{
    public Victim()
    {
        
    }
    public string Name { get; set; } = "Stuart McCormick";
    public int Age { get; set; } = 42;
    public string Occupation { get; set; } = "Sr. Software Engineer";
    public string CauseOfDeath { get; set; } = "Lycorine Poisoning via Daffodils";
    public List<Crime> Crimes { get; set; } = new List<Crime>
                                                {new Crime("Check Fraud","Felony",new DateTime(2022,1,09),"Middle Park","Colorado"),
                                                new Crime("Public Nuisance","Misdemeanor",new DateTime(2021,10,04),"Middle Park","Colorado"),
                                                new Crime("Public Intoxication","Misdemeanor",new DateTime(2021,10,04),"Middle Park","Colorado"),
                                                new Crime("DUI","Felony",new DateTime(2020,03,19),"South Park","Colorado"),
                                                new Crime("Public Intoxication","Misdemeanor",new DateTime(2019,03,20),"South Park","Colorado"),
                                                new Crime("DUI","Felony",new DateTime(2018,05,05),"South Park","Colorado"),
                                                new Crime("Public Intoxication","Misdemeanor",new DateTime(2017,12,31),"South Park","Colorado")};
}