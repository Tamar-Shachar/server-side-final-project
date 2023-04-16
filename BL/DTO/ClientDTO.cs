﻿namespace BL.DTO
{
    public class ClientDTO
    {
        //public string Code { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string EmailAddress { get; set; } = null!;

        public string? Gender { get; set; }

        //public DateTime? BornDate { get; set; }

        //public double Height { get; set; }

        public double Weight { get; set; }
        public int Age { get; set; }
        //public int FitnessLevel { get; set; }

        //public Route Route { get; set; }
        public int Route { get; set; }

        public DateTime StartDate { get; set; }

        //public int Duration { get; set; }

        //public double[] Progress { get; set; }

        public Dictionary<string, int> Food { get; set; }
        
    }
}
