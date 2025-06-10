using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour
{
        //star += "¡Ú";
        //star += "¡¡";
        //star += "\n";
    string star;
    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }
        public void Phase1()
    {
        star = string.Empty;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < (i + 1); j++)
            {
                star += "¡Ú";
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < i; j++)
            {
                star += "¡¡";
            }
            for (int j = 0; j < (5 - i); j++)
            {
                star += "¡Ú";
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < (i + 1); j++)
            {
                star += "¡Ú";
            }
            star += "\n";
        }
        for (int i = 5 - 1;i >= 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                star += "¡Ú";
            }
            star += "\n";
        }
            Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < (5 - i); j++)
            {
                star += "¡¡";
            }
            for (int j = 0; j < (i + 1); j++)
            {
                star += "¡Ú";
            }
            star += "\n";
        }
        for (int i = 5 - 2; i >= 0; i--)
        {
            for (int j = 0; j < (5 - i); j++)
            {
                star += "¡¡";
            }
            for (int j = 0; j < (i + 1); j++)
            {
                star += "¡Ú";
            }
            star += "\n";
        }
        Debug.Log(star);
    }

    public void Phase5()
    {
        int allstar;
        star = string.Empty;
        for (int i = 0; i < 5; i++)
        {
            allstar = (i * 2) + 1;
            for (int j = 0; j < (9 - allstar) / 2; j++)
            {
                star += "¡¡";
            }
            for (int j = 0; j < allstar; j++)
            {
                star += "¡Ú";
            }
            star += "\n";
        }
        for (int i =(9 / 2) -1; i >= 0; i--)
        {
            allstar = (i * 2) + 1;
            for (int j = 0; j < (9 - allstar) / 2; j++)
            {
                star += "¡¡";
            }
            for (int j = 0; j < allstar; j++)
            {
                star += "¡Ú";
            }
            star += "\n";
        }
        Debug.Log(star);
    }
}
