using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vint : MonoBehaviour
{
    public int locked = 0;
    private Outline outline;//компонент обводки
    public Blur locke;
    public int move = 0;
    public float c = 100;
    public Vector3 H = new Vector3(0.0f, 0.0f, 0.0f);
    Vector3 OO = new Vector3(0.004f, 0.88f, -0.267f);
    private void OnEnable()
    {
        outline = GetComponent<Outline>();   
    }

    void Update()
    {
        if (locke.locked != -1)
        {
            while (locked == 0)
            {
                if (move == 1 && transform.position.x <= 0.38)
                {
                    H = new Vector3(0.0f, 0.0f, 0.4f);
                    transform.RotateAround(OO, H, 20 * Time.deltaTime);
                }

                if (move == -1 && transform.position.x >= -0.61)
                {
                    H = new Vector3(0.0f, 0.0f, -0.4f);
                    transform.RotateAround(OO, H, 20 * Time.deltaTime);
                }
                break;
            }
            while (locked == 1)
            {
                if (move == 1)
                {
                    H = new Vector3(0.0f, 0.0f, 0.4f);
                    transform.RotateAround(OO, H, 20 * Time.deltaTime);
                }

                if (move == -1)
                {
                    H = new Vector3(0.0f, 0.0f, -0.4f);
                    transform.RotateAround(OO, H, 20 * Time.deltaTime);
                }
                break;
            }
            outline.OutlineWidth = 4;//обводка включена
        }
        else
        {
            outline.OutlineWidth = 0;//выключена
        }
    }
    public void Fix()
    {
        locked = 1;
    }
    public void Clock(int clo)
    {
        move = clo;
    }


}
