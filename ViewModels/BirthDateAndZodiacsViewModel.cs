using Lab1.Models;
using Lab1.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab1.ViewModels
{
    class BirthDateAndZodiacsViewModel: INotifyPropertyChanged
    {
        private UserInfo _birthInfo = new UserInfo();
        private RelayCommand<object> _pickDateCommand;

        #region Properties
        public DateTime BirthDate
        {
            get { return _birthInfo.BirthDate; }
            set
            {
                _birthInfo.BirthDate = value;
                OnPropertyChanged();
            }
        }
        public string WesternZodiac
        {
            get { return _birthInfo.WesternZodiac; }
            set
            {
                _birthInfo.WesternZodiac = value;
                OnPropertyChanged();
            }
        }
        public string ChineseZodiac
        {
            get { return _birthInfo.ChineseZodiac; }
            set
            {
                _birthInfo.ChineseZodiac = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand<object> PickDateCommand
        {
            get
            {
                return _pickDateCommand ??= (_pickDateCommand = new RelayCommand<object>(
                           ProccedWithDate, o => CanExecuteCommand()));
            }
        }

        #endregion

        private void ProccedWithDate(object obj)
        {
            TimeSpan difference = (DateTime.Today - BirthDate);
            int age = -1;
            try
            {
                age = (new DateTime(1, 1, 1) + difference).Year;
            }
            catch
            {
                MessageBox.Show("Impossible to set birth date in future");
                return;
            }


            if (age > 135)
            {
                MessageBox.Show("It's impossible to be that old...");
                return;
            }

            if (DateTime.Today.Month == BirthDate.Month && DateTime.Today.Day == BirthDate.Day)
            {
                MessageBox.Show("Happy Birthday!!!");
            }
            WesternZodiac = CalcWesternZodiac(BirthDate);
            ChineseZodiac = CalcChineseZodiac(BirthDate);
        }

        public bool CanExecuteCommand()
        {
            return !String.IsNullOrWhiteSpace(BirthDate.ToString("d"));
        }

        #region Calculate Zodiacs
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

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
