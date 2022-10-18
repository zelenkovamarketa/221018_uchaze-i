using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221018_uchazeči
{
    interface IIntValidator
    {
        bool IsValid(string s, out int i);
    }

    interface IStringValidator
    {
        bool IsValid(string s);
    }

    interface ILicenceValidator
    {
        bool HasLicense(string s);
    }
    interface IExperienceValidator
    {
        bool HasExperience(string s);
    }

    interface ICriminalRecordValidator
    {
        bool HasCleanCriminalRecord(string s);
    }
}
