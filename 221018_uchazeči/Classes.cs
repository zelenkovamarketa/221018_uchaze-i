using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221018_uchazeči
{
    class SurnameValidator :IStringValidator
    {
        public bool IsValid(string s)
        {
            if (s.Length != 0 && char.IsUpper(s[0]))
                return true;
            return false;
        }
    }

    class AgeValidator:IIntValidator
    {
        public bool IsValid(string s, out int age)
        {
            if (int.TryParse(s, out age) == false)
                return false;
            if (age >= 18 || age < 70)
                return true;
            return false;
        }
    }

    class WaiterAgeValidator : IIntValidator
    {
        public bool IsValid(string s, out int age)
        {
            if (int.TryParse(s, out age) == false)
                return false;
            if (age >= 15 || age < 50)
                return true;
            return false;
        }
    }

    class LicenseValidator : ILicenceValidator
    {
        public bool HasLicense(string s)
        {
            if (s == "ano" || s == "Ano")
                return true;
            return false;
        }
    }

    class ExperienceValidator : IExperienceValidator
    {
        public bool HasExperience(string s)
        {
            if (s == "ano" || s == "Ano")
                return true;
            return false;
        }
    }

    class CriminalRecordValidator : ICriminalRecordValidator
    {
        public bool HasCleanCriminalRecord(string s)
        {
            if (s == "ano" || s == "Ano")
                return true;
            return false;
        }
    }
}
