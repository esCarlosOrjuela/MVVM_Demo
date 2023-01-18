using System;
using Code.MVVM.Models;

namespace Code.MVVM.ViewModels
{
    public class ConvertesViewModels
    {
        public DataModel Data { get; set; }

        public ConvertesViewModels()
        {
            Data = new DataModel
            {
                Married = "Yes"
            };
        }
    }
}

