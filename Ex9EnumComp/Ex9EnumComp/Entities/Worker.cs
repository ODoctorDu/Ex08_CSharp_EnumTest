using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex9EnumComp.Entities.Enums;

namespace Ex9EnumComp.Entities
{
    class Worker
    {
        //--------------------[AUTO IMPLEMENTED PROPERTIES]
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }  //My prop "Level" is from Enums Type "WorkerLevel";
        public double BaseSalary { get; set; }
        public Department Department { get; set; } //I Have a Composition/Association between "Worker" class and "Department" class, so here in "Worker" i need a "Department" type prop. This is how you do the association between two different classes.
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); //Here I have a Composition/Association between "Worker" class and "HourContrat" class. I already did the instantiation to prevent possible issues with a null List.

        //--------------------[CONSTRUCTOR]
        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
            //Isn't usual to include a List parameter in a Constructor. This is the reason for not include "Contracts" atribute here.
        }

        //--------------------[METHODS]
        public void AddContract(HourContract contract)  //My Method "AddContract" will receive a parameter HourContract type called contract and add it on the Contracts list. 
        {
            Contracts.Add(contract);
        }
        public void RemoveConcract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)   //Income is how much a worker earns
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue(); //TotalValue() returns with contract value.
                }
            }

            return sum;  
        }
    }
}
