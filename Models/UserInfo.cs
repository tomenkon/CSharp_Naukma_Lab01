using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Models
{
    class UserInfo
    {
        #region Fields
        private DateTime _birthDate;
        private string _westernZodiac;
        private string _chineseZodiac;
        #endregion

        #region Properties
        public string WesternZodiac
        {
            get { return _westernZodiac; }
            set { _westernZodiac = value; }
        }

        public string ChineseZodiac
        {
            get { return _chineseZodiac; }
            set { _chineseZodiac = value; }
        }

        public DateTime BirthDate
		{
			get { return _birthDate; }
			set 
            { 
                _birthDate = value;
            }
		}
        #endregion


    }
}
