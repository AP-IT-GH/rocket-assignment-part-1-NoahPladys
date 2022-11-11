using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private bool won;
    public Canvas nextLevelScreen;

    private void Start()
    {
        won = false;
        nextLevelScreen.enabled = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!won)
        {
            won = false;
            if(nextLevelScreen != null) nextLevelScreen.enabled = true;
        }
    }
}
