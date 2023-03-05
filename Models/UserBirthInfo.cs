using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Tomenko.Models
{
    class UserBirthInfo
    {
        #region Fields
        private DateTime _birthDate;
		private string _westernZodiac;
		private string _chineseZodiac;
        #endregion

        #region Properties
        public DateTime BirthDate
		{
			get { return _birthDate; }
			set 
            { 
                _birthDate = value;
            }
		}

        public string WesternZodiac
        {
            get 
            { return _westernZodiac; }
        }
        public string ChineseZodiac
        {
            get { return _chineseZodiac; }
        }
        #endregion

        #region Constructors
        public UserBirthInfo()
        {

        }

        public UserBirthInfo(DateTime birthDate)
        {
            _birthDate = birthDate;
            _westernZodiac = CalcWesternZodiac(birthDate);
            _chineseZodiac = CalcChineseZodiac(birthDate);
        }
        #endregion

        #region Zodiacs Calculation
        private string CalcWesternZodiac(DateTime birthDate)
        {
            string zodiacSign = "";

            switch (birthDate.Month)
            {
                case 1: // January
                    if (birthDate.Day <= 19)
                        zodiacSign = "Capricorn";
                    else
                        zodiacSign = "Aquarius";
                    break;
                case 2: // February
                    if (birthDate.Day <= 18)
                        zodiacSign = "Aquarius";
                    else
                        zodiacSign = "Pisces";
                    break;
                case 3: // March
                    if (birthDate.Day <= 20)
                        zodiacSign = "Pisces";
                    else
                        zodiacSign = "Aries";
                    break;
                case 4: // April
                    if (birthDate.Day <= 19)
                        zodiacSign = "Aries";
                    else
                        zodiacSign = "Taurus";
                    break;
                case 5: // May
                    if (birthDate.Day <= 20)
                        zodiacSign = "Taurus";
                    else
                        zodiacSign = "Gemini";
                    break;
                case 6: // June
                    if (birthDate.Day <= 20)
                        zodiacSign = "Gemini";
                    else
                        zodiacSign = "Cancer";
                    break;
                case 7: // July
                    if (birthDate.Day <= 22)
                        zodiacSign = "Cancer";
                    else
                        zodiacSign = "Leo";
                    break;
                case 8: // August
                    if (birthDate.Day <= 22)
                        zodiacSign = "Leo";
                    else
                        zodiacSign = "Virgo";
                    break;
                case 9: // September
                    if (birthDate.Day <= 22)
                        zodiacSign = "Virgo";
                    else
                        zodiacSign = "Libra";
                    break;
                case 10: // October
                    if (birthDate.Day <= 22)
                        zodiacSign = "Libra";
                    else
                        zodiacSign = "Scorpio";
                    break;
                case 11: // November
                    if (birthDate.Day <= 21)
                        zodiacSign = "Scorpio";
                    else
                        zodiacSign = "Sagittarius";
                    break;
                case 12: // December
                    if (birthDate.Day <= 21)
                        zodiacSign = "Sagittarius";
                    else
                        zodiacSign = "Capricorn";
                    break;
            }
            return zodiacSign;
        }

        private string CalcChineseZodiac(DateTime birthDate)
        {
            int zodiacYear = (birthDate.Year - 4) % 12; 
            string zodiacSign = "";

            switch (zodiacYear)
            {
                case 0:
                    zodiacSign = "Rat";
                    break;
                case 1:
                    zodiacSign = "Ox";
                    break;
                case 2:
                    zodiacSign = "Tiger";
                    break;
                case 3:
                    zodiacSign = "Rabbit";
                    break;
                case 4:
                    zodiacSign = "Dragon";
                    break;
                case 5:
                    zodiacSign = "Snake";
                    break;
                case 6:
                    zodiacSign = "Horse";
                    break;
                case 7:
                    zodiacSign = "Sheep";
                    break;
                case 8:
                    zodiacSign = "Monkey";
                    break;
                case 9:
                    zodiacSign = "Rooster";
                    break;
                case 10:
                    zodiacSign = "Dog";
                    break;
                case 11:
                    zodiacSign = "Pig";
                    break;
            }
            return zodiacSign;
        }
        #endregion
    }
}
