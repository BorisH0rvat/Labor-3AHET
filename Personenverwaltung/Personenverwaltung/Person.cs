using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personenverwaltung
{
    internal class Person
    {
        private string name;
        private int birthday;
        private int birthmonth;
        private int birthyear;
        private string country;
        private string city;
        private string adress;
        private int postalCode;

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetBirthday(int birthday)
        {
            this.birthday = birthday;
        }

        public void SetBirthMonth(int birthmonth) { this.birthmonth = birthmonth; }

        public void SetBirthYear(int birhtyear) {  this.birthyear = birhtyear; }

        public void SetCountry(string country) { this.country = country; }
        
        public void SetCity(string city) { this.city = city; }

        public void SetPostalcode(int postalCode) { this.postalCode = postalCode; }

        public void SetAddress(string adress) { this.adress = adress; }

        public int GetBirthMonth() { return this.birthmonth; }

        public string GetName() { return this.name; }

        public int GetBirthDay() { return this.birthday; }

        public int GetBirthYear() { return this.birthyear; }

        public string GetCountry() { return this.country; }

        public string GetCity() { return this.city; }

        public int GetPostalcode() { return this.postalCode; }

        public string GetAdress() { return this.adress; }

    }
}
