using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartTime : Employee
{
    public float hoursWorked;
    public float hourlyRate;

    //float[] quiz = {0,0,0,0,0};
    //public float gradePAverage;

    //private void Start()
    //{
    //    float sumQuiz = 0f;
    //    for (int i = 0; i < 5; i++)
    //    {
    //        quiz[i] = Random.Range(40, 100);
    //        sumQuiz += quiz[i];
    //    }
    //    gradePAverage = sumQuiz / quiz.Length;
    //    if (gradePAverage >= 90f)
    //    {
    //        print(gradePAverage + "A");
    //    }
    //    else if (gradePAverage >= 80f)
    //    {
    //        print(gradePAverage + "B");
    //    }
    //    else if (gradePAverage >= 70f)
    //    {
    //        print(gradePAverage + "C");
    //    }
    //    else 
    //    {
    //        print(gradePAverage + "F");
    //    }
    //}


    public override void CalculateMonthlySalary()
    {
        monthlySalary = hoursWorked * hourlyRate;
    }

}
