using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStore.Helper
{
    public static class Utilities
    {
        //DateTime Extention Method to Calculate Age
        public static int CalculateAge(this DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }
    }
}
