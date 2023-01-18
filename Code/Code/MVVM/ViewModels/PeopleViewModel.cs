using System;
using Code.MVVM.Models;
namespace Code.MVVM.ViewModels
{
    public class PeopleViewModel
    {
        public List<PersonModel> People { get; set; }

        public PeopleViewModel()
        {
            People = new List<PersonModel>
            {
                new PersonModel(){ Name= "John", Age = 42, Weight = 70, Married = true, BirthDate = new DateTime(2000, 02, 18), Lunchtime = new TimeSpan(10,30,00) },
                new PersonModel(){ Name= "Daniel", Age = 21, Weight = 80, Married = false, BirthDate = new DateTime(2000, 02, 18), Lunchtime = new TimeSpan(10,30,00) },
                new PersonModel(){ Name= "Pedro", Age = 55, Weight = 75, Married = false, BirthDate = new DateTime(2000, 02, 18), Lunchtime = new TimeSpan(10,30,00) },
                new PersonModel(){ Name= "Maria", Age = 23, Weight = 70, Married = true, BirthDate = new DateTime(2000, 02, 18), Lunchtime = new TimeSpan(10,30,00) },
                new PersonModel(){ Name= "Camila", Age = 27, Weight = 65, Married = true, BirthDate = new DateTime(2000, 02, 18), Lunchtime = new TimeSpan(10,30,00) },
            };

        }
    }
}

