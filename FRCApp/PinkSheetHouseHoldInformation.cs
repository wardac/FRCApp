using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRCApp
{
    class PinkSheetHouseHoldInformation
    {
        private String firstName;

        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private String lastName;

        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private String last4DigitsOfSsn;

        public String Last4DigitsOfSsn
        {
            get { return last4DigitsOfSsn; }
            set { last4DigitsOfSsn = value; }
        }
        private String birthDate;

        public String BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private String RelationshipToApplicant;

        public String RelationshipToApplicant1
        {
            get { return RelationshipToApplicant; }
            set { RelationshipToApplicant = value; }
        }


        private String HealthCoverage;

        public String HealthCoverage1
        {
            get { return HealthCoverage; }
            set { HealthCoverage = value; }
        }


        public String ToString()
        {
            return firstName + " "
                + lastName + " " 
                + last4DigitsOfSsn + " "
                + birthDate + " "
                + age.ToString() + " "
                + RelationshipToApplicant + " "
                + HealthCoverage;

        }

    }
}
