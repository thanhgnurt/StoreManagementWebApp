using StoreManager.ENTITIES;
using System;

namespace StoreManager.Pages._Common
{
    public static class HandleDate
    {
        public static string ToStringDate(DateTime date)
        {
            string stringDate = date.Day.ToString().ConCatNumber0(2) + "/" + date.Month.ToString().ConCatNumber0(2) + "/"+date.Year.ToString();
            return stringDate;
        }
    }
}