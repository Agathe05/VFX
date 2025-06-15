using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{

    public float number = 2f;
    private float reste = 0f;

    public float enumNumber = 4f;
    private float actualNumber = 0f;
    public string StringToInvert = "Oui";

    void Start()
    {
        Print();
        IsPair();
        EnumNumber();
        InvertCharacters();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Print()
    {
        Debug.Log("Hello Worold");
    }

    public void IsPair()
    {
        reste = number % 2;
        if (reste == 0)
        {
            Debug.Log("Le nombre est pair");
        }
        else
        {
            Debug.Log("Le Nombre est impair");
        }
    }

    public void EnumNumber()
    {
        for (int i = -1; i != enumNumber; i = i + 1)
        {
            Debug.Log(i + 1);

        }
        
        //while (actualNumber != enumNumber)
        //{
        //    Debug.Log(actualNumber);
        //    actualNumber = actualNumber + 1;
        //}
        //Debug.Log(enumNumber);
    }

    public void InvertCharacters()
    {
        string newCharacters ="";

        for (int i = StringToInvert.Length; i==0;i = i-1)
        {

            newCharacters.Insert(1, "test");
        }
        Debug.Log(newCharacters);
    }
}
