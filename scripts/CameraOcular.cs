using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraOcular : MonoBehaviour
{
    public int locked = 0;
    public int move = 0;
    public Vector3 H = new Vector3(0.0f, 0.0f, 0.0f);
    Vector3 OO = new Vector3(0.04460634f, 0.879f, -0.038f);

    void Update()
    {
        while (locked == 0)
        {

            if (move == 1 && transform.position.y >= 0.885f)
            {
                H = new Vector3(0.0f, 0.0f, 0.4f);
                transform.RotateAround(OO, H * 100, 20 * Time.deltaTime);
            }

            if (move == -1 && transform.position.y <= 0.96f)
            {
                H = new Vector3(0.0f, 0.0f, -0.4f);
                transform.RotateAround(OO, H * 100, 20 * Time.deltaTime);
            }
            if (move == 2 && transform.position.z <= -0.0607f)
            {
                H = new Vector3(0.0f, 0.4f, 0.0f);
                transform.RotateAround(OO, H * 100, 20 * Time.deltaTime);
            }

            if (move == -2 && transform.position.z >= -0.083f)
            {
                H = new Vector3(0.0f, -0.4f, 0.0f);
                transform.RotateAround(OO, H * 100, 20 * Time.deltaTime);
            }
            break;
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
