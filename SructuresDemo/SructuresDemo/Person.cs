using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SructuresDemo
{
    struct Human
    {
        public int id;
        public string firstName;
        public string lastName;
        public string middleName;

        public Human(int id, string firstName, string lastName, string middleName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.middleName = middleName;
        }
        public override string ToString()
        {
            return $"\n Human: \n {id,4}{firstName,10}{lastName,10}{middleName,10}\n";
        }
    }

    struct Birth
    {
        public int birthYear;
        public int birthMonth;
        public int birthDay;
        public override string ToString()
        {
            return $" Birth Date: {birthDay}.{birthMonth}.{birthYear}\n";
        }
        public Birth(int birthYear, int birthMonth, int birthDay)
        {
            this.birthYear = birthYear;
            this.birthMonth = birthMonth;
            this.birthDay = birthDay;
        }
    }

    struct Address
    {
        public string country;
        public string region;
        public string city;
        public string district;
        public string street;
        public string house;
        public string flat;
        public override string ToString()
        {
            return string.Format(" Adress:\n{0}{1,10}{2,10}{3,10}{4,10}{5,5}{6,7}", country, region, city, district, street, house, flat);
        }
        public Address(string country, string region, string city, string district, string street, string house, string posltaCode)
        {
            this.country = country;
            this.region = region;
            this.city = city;
            this.district = district;
            this.street = street;
            this.house = house;
            this.flat = posltaCode;
        }
    }

    struct Contacts
    {
        public string phone;
        public string email;
        public string telegram;
        public string viber;
        public string facebook;
        public string instagram;
        public override string ToString()
        {
            return string.Format(" Contacts:\n{0,10}{1,10}{2,10}{3,10}{4,10}{5,10}", phone, email, telegram, viber, facebook, instagram);
        }
        public Contacts(string phone, string email, string telegram, string viber, string facebook, string instagram)
        {
            this.phone = phone;
            this.email = email;
            this.telegram = telegram;
            this.viber = viber;
            this.facebook = facebook;
            this.instagram = instagram;
        }
    }

    struct Education
    {
        public string school;
        public string university;
        public string faculty;
        public string speciality;
        public string occupation;
        public override string ToString()
        {
            return string.Format(" Education:\n{0,10}{1,10}{2,10}{3,10}{4,10}", school, university, faculty, speciality, occupation);
        }
        public Education (string school, string university, string faculty, string speciality, string occupation)
        {
            this.school = school;
            this.university = university;
            this.faculty = faculty;
            this.speciality = speciality;
            this.occupation = occupation;
        }
    }


    internal class Person
    {
        protected Human human;
        protected Birth birth;
        protected Address address;
        protected Contacts contacts;
        protected Education education;

        public Person(Human human, Birth birth, Address address, Contacts contacts, Education education)
        {
            this.human = human;
            this.birth = birth;
            this.address = address;
            this.contacts = contacts;
            this.education = education;
        }

        public override string ToString()
        {
            return human.ToString() + birth.ToString() + address.ToString() +
                contacts.ToString() + education.ToString();
        }
    }
}
