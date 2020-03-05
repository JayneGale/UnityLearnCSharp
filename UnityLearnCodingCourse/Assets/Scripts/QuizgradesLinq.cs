using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class QuizgradesLinq : MonoBehaviour
{
    [System.Serializable]
    public class Item
    {
        public string name;
        public int itemID;
        public int buff;
    }
    public List<Item> items;
    public int[] quizGrades = { 0, 52, 76, 84, 88, 46 };
    public bool hasItem3;

    void Start()
    {
        //foreach (var item in items) hasItem3 = item.itemID == 3 ? true: false; 
        //identify if the list of items has item with itemID3 print true if yes false if not
        hasItem3 = items.Any(item => item.itemID == 3);
        string has = hasItem3 ? "True" : "False";
        Debug.Log("################# Has item with itemID3 = " + has);
        //grab all the items with buff?20 and print them out
        var highBuff = items.Where(item => item.buff >= 20);
        foreach (var item in highBuff)
            Debug.Log("High buff item " + item.name + " with buff level " + item.buff);
        //next print the average of all the buff stats
        var avBuff = items.Average(item => item.buff);
        Debug.Log("Average of all the buffs is " +avBuff);

        var passingGrades = quizGrades.Where(g => g > 69).OrderByDescending(x => x);
    }

}
