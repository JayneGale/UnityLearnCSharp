using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullTime : Employee
{
    public int annualSalary;

    public override void CalculateMonthlySalary()
    {
        monthlySalary = annualSalary / 12;
    }
}
