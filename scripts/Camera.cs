using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Vector3 H = new Vector3(0.0f,0.0f,0.0f);
    public int side = 0;
    void Update()
    {
        if (side < 0)
        {
            H = new Vector3(0.0f, -0.4f, 0.0f);
            MoveC();
        }

        if (side > 0)
        {
            H = new Vector3(0.0f, 0.4f, 0.0f);
            MoveC();
        }
            
    }
    public void Side(int sid)
    {
        side = sid;
    }
    public void MoveC()
    {
        Vector3 OO = new Vector3(0.028f, 0.685f, -0.032f);
        transform.RotateAround(OO, H, 4 * Time.deltaTime);
    }
}
