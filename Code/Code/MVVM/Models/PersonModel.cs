using System;
namespace Code.MVVM.Models
{
    public class PersonModel
    {
        public int Age { get; set; }
        public int Weight { get; set; }
        public string Name { get; set; }
        public bool Married { get; set; }
        public TimeSpan Lunchtime { get; set; }
        public DateTime BirthDate { get; set; }
    }
}

