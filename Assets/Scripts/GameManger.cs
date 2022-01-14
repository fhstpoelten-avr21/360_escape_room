using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public Animator[] animations;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            animations[0].Play("RollingBall", -1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            animations[1].Play("SpikeTrap", -1);
            animations[3].Play("SpikeTrap", -1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            animations[2].Play("Barrel", -1);
        }
    }
}
