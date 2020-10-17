using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello console!");
        showMainMenu();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void showMainMenu()
    {
        Terminal.WriteLine("What would you like to hack into? \n");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Press 3 for NASA");
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter your selection:");
    }
}
