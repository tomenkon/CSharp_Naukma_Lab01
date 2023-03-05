using Lab1_Tomenko.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Tomenko.ViewModels
{
    class BirthDateAndZodiacsViewModel
    {
        private UserBirthInfo _birthInfo;

        public DateTime BirthDate
        {
            get { return _birthInfo.BirthDate; }
            set
            {
                _birthInfo.BirthDate = value;
            }
        }
        public string WesternZodiac
        {
            get { return _birthInfo.WesternZodiac; }
        }
        public string ChineseZodiac
        {
            get { return _birthInfo.ChineseZodiac; }
        }
    }
}
