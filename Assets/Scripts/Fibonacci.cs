using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fibonacci : MonoBehaviour
{
    public InputField IP;
    public Text Displaytext;
    public Text TotalText;

    int length;
    int total;
    // Use this for initialization
    void Start()
    {
        Displaytext.text = "Fibonacci Sequence: \n" + " ";
    }

    public void clear()
    {
        Displaytext.text = "Fibonacci Sequence:" + " ";
        TotalText.text = " ";
        IP.text = "";
    }

    public void Ok()
    {

        length = int.Parse(IP.text);
        if (length <= 10)
        {
            TotalText.text = "Enter More Than 10 Numbers";
        }

        if (length>10 && length <= 800)
        {
           
            total = 0;

            length = int.Parse(IP.text);
            for (int i = 0; i < length; i++)
            {

                print(FibonacciSeries(i));
                if (i < 10)
                {
                    total += FibonacciSeries(i);
                }
                Displaytext.text += " " + FibonacciSeries(i).ToString();
                TotalText.text = "Total of 1st Ten Numbers Is:" + total.ToString();
            }
        }
        if (length >= 800)
        {
            TotalText.text = "Enter Between 10 and 800";
        }

    }

    static int FibonacciSeries(int n)
    {
        int firstnumber = 0, secondnumber = 1, result = 0;

        if (n == 0) return 0;
        if (n == 1) return 1;

        for (int i = 2; i <= n; i++)
        {
            result = firstnumber + secondnumber;
            firstnumber = secondnumber;
            secondnumber = result;
        }

        return result;
    }
}

