using System;
using System.Collections.Generic;
using System.Text;

namespace Metrics
{
    public class User
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public List<Workout> Workouts { get; set; } = new List<Workout>();
        public User(int age, string name)
        {
            Name = name;
            Age = age;

        }
        public User()
        {
            Name = "anon";
            Age = 69;
        }
    }
}
