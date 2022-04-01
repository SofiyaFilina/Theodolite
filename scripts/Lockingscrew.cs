using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lockingscrew : MonoBehaviour
{
    public Ocular locke;
    private Outline outline;//компонент обводки
    Vector3 OO = new Vector3(0.021f, 1.036f, -0.196f);
    Vector3 axs = new Vector3(0.0f, 0.4f, 0.0f);
    private void OnEnable()
    {
        outline = GetComponent<Outline>();
    }
    public void Update()
    {
        
        if (locke.locked == 1)
        {           
            if (transform.position.z>-0.32)
            {
                transform.RotateAround(OO, axs, 20 * Time.deltaTime);
                outline.OutlineWidth = 4;//обводка включена
            }
            else
            {
                outline.OutlineWidth = 0;//выключена

            }
        }
       
        
    }
}
