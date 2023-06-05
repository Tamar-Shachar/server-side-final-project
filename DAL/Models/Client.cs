﻿namespace DAL.Models;

public class Client
{
    #region properties
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string ObjectId { get; set; }
    [BsonElement("code")]
    public int Code { get; set; }
    [BsonElement("firstName")]
    public string FirstName { get; set; } = null!;
    [BsonElement("lastName")]
    public string LastName { get; set; } = null!;
    [BsonElement("emailAddress")]
    public string EmailAddress { get; set; } = null!;
    [BsonElement("gender")]
    public int Gender { get; set; }
    [BsonElement("bornDate")]
    public DateTime? BornDate { get; set; }
    [BsonElement("height")]
    public double Height { get; set; }
    [BsonElement("weight")]
    public double Weight { get; set; }
    [BsonElement("fitnessLevel")]
    public int FitnessLevel { get; set; }
    [BsonElement("route")]
    //public Route route { get; set; }
    public int Route { get; set; }
    [BsonElement("startDate")]
    public DateTime StartDate { get; set; }
    [BsonElement("activityLevel")]
    public int ActivityLevel { get; set; }
    [BsonElement("duration")]
    public int Duration { get; set; }
    [BsonElement("progress")]
    public double[] Progress { get; set; }
    [BsonElement("food")]
    public Dictionary<string, int> Foods { get; set; }
    #endregion

    /*        public Client(string id,string firstName, string lastName, string emailAddress, int gender, double weight
          *//* DateTime bornDate = DateTime.Now*//*, double height = 1.5,
          *//* Route route = Route.health,*//* int fitnessLevel = 50, int duration = 4)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailAddress = emailAddress;
            this.Gender = gender;
           // this.BornDate = bornDate;
            this.Height = height;
            this.Weight = weight;
            this.Route = 3;
            this.StartDate = DateTime.Now;
            this.FitnessLevel = fitnessLevel;
            this.Duration = duration;



        }*/
}
