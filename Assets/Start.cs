using UnityEngine;
using System.Collections;

public class Start : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel("Orbis");
        }
    }
}
