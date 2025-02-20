using Andrew.DemoApp.Application.UseCases.Appointments.Patients.Abstractions;
using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrew.DemoApp.Application.UseCases.Appointments.Patients.SmartEnums
{
    public class PatientCatagory : SmartEnum<PatientCatagory>
    {
        public static readonly PatientCatagory Vulnerable = new("Vulnerable", 0, new VulnerablePatient());
        public static readonly PatientCatagory Child = new("Child", 0, new ChildPatient());
        public static readonly PatientCatagory AbleBodied = new("AbleBodied", 0, new AbleBodiedPatient());
        public PatientCatagory(string name, int value, IPatient patient) : base(name, value)
        {

        }
    }
}
