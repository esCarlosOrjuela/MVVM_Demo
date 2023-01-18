using System;
using Code.MVVM.Models;

namespace Code.MVVM.ViewModels
{
    public class PersonViewModel
    {
        public PersonModel Person { get; set; }

        public PersonViewModel()
        {
            Person = new PersonModel
            {
                Name = "Carlos",
                Age = 32,
                Weight = 100,
                Married = true,
                Lunchtime = new TimeSpan(10, 0, 0),
                BirthDate = new DateTime(1991, 09, 27)
            };
        }
    }
}

