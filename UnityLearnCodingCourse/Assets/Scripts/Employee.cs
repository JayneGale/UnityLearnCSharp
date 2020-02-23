using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Employee : MonoBehaviour
{
    public static string companyName = "BonChance";
    public string employeeName;

    [HideInInspector]
    public float monthlySalary;

    public abstract void CalculateMonthlySalary();
}




