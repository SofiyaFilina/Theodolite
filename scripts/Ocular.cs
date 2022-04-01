using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ocular : MonoBehaviour
{

    public int locked = 0;
    private Outline outline;//компонент обводки
    public int clock = 0;
    public Vector3 H = new Vector3(0.0f, 0.0f, 0.0f);
    Vector3 OO = new Vector3(0.04460634f, 0.879f, -0.038f);
    private void OnEnable()
    {
        outline = GetComponent<Outline>();
    }
    void Update()
    {
        if (locked == 0)
        {
            
            if (clock == 1 && transform.position.x <= 0.54f)
            {
         
                H = new Vector3(0.0f, 0.0f, 0.4f);
                transform.RotateAround(OO, H, 20 * Time.deltaTime);
            }
               
            if (clock==-1 && transform.position.x >= -0.465f)
            {
                
                H = new Vector3(0.0f, 0.0f, -0.4f);
                transform.RotateAround(OO, H, 20 * Time.deltaTime);
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
        clock = clo;
    }
}
