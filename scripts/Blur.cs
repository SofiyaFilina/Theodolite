using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Blur : MonoBehaviour
{

    public PostProcessProfile postProcessProfile;
    public int move = 0;
    public int locked = 0;
    private int c = 0;
    private void Start()
    {
        postProcessProfile.GetSetting<DepthOfField>().focalLength.value = 228;
    }
    void Update()
    {
        
        while (locked >= 1)
        {
            if (postProcessProfile.GetSetting<DepthOfField>().focalLength.value == 1)
            {
                locked = -1;
            }
            if (postProcessProfile.GetSetting<DepthOfField>().focalLength.value == 300)
            {
                c += 1;
            }
            if (c % 2 == 0)
            {
                if (move == 1)
                {
                    postProcessProfile.GetSetting<DepthOfField>().focalLength.value += 5;
                }
                if (move == -1)
                {
                    postProcessProfile.GetSetting<DepthOfField>().focalLength.value -= 5;
                }
            }
            if (c % 2 != 0)
            {
                if (move == 1)
                {
                    postProcessProfile.GetSetting<DepthOfField>().focalLength.value -= 5;
                }
                if (move == -1)
                {
                    postProcessProfile.GetSetting<DepthOfField>().focalLength.value += 5;
                }
            }
            break;
        }
    }
    public void Move(int moved)
    {
        move = moved;   
    }
    public void Fix()
    {
        locked = 1;
    }
}
