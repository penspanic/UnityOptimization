using UnityEngine;
using System.Collections;
using System;
using System.Text;

public class StringBuilderTester : MonoBehaviour
{

    void Awake()
    {
        StringAddTest();
        StringBuilderTest();
    }

    void StringAddTest()
    {
        DateTime start = DateTime.Now;

        for(int i =0;i<100000;++i)
        {
            string s = "Sample string";
            for(int j= 0;j<10;++j)
                s += " " + j.ToString();
        }

        DateTime end = DateTime.Now;

        Debug.Log("String Add  : " + (end - start).ToString());
    }

    void StringBuilderTest()
    {

        DateTime start = DateTime.Now;

        for(int i = 0;i<100000;++i)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Sample string");
            for (int j = 0; j < 10; ++j)
            {
                sb.Append(" ");
                sb.Append(j.ToString());
            }
        }

        DateTime end = DateTime.Now;

        Debug.Log("String Builder : " + (end - start).ToString());
    }
}