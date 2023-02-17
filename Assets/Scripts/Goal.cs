using System.Collections;
using UnityEngine;


public class Goal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Ball").SendMessage("finish");
    }
}
