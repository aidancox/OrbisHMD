using UnityEngine;
using System.Collections;

public class Heart : MonoBehaviour
{
	void Update()
    {
        if (transform.localScale.x < 0.01f)
        {
            transform.eulerAngles = new Vector3(-90,Random.Range(0, 10) * 180,0);
        }
	}
}
