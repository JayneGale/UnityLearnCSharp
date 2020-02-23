using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDatabase : MonoBehaviour
{
    [SerializeField]
    //public Customer Juniper;
    //public Customer Miller;
    //public Customer Sossij;
    public Customer[] customers;

    // Start is called before the first frame update
    void Start()
    {
        //Juniper = CreateCustomer("Juniper", "Watson", 26, "F", "Welder");
        //Miller = CreateCustomer("Rand", "Miller", 66, "M", "CEO");
        //Sossij = CreateCustomer("Sossij", "The Cat", 6, "NB", "Detective");
    }

    private Customer CreateCustomer(string firstName, string lastName, int age, string gender, string occupation)
    {
        Customer customer = new Customer(firstName, lastName, age, gender, occupation);
        return customer;
    }
}
