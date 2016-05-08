using UnityEngine;
using System.Collections;

public class GrowthControl : MonoBehaviour
{
    public Mesh[] forms;
    public float sizeTrigger;
    public float sizeDestory;
    public bool triggered;
    public float growth;
    public float speed;

    void Start()
    {
        if (gameObject.name.Contains("Clone"))
        {
            transform.localScale = Vector3.zero;
            growth += speed;
        }
    }
   
    void Update()
    {
        if (transform.localScale.x < 1)
        {
            transform.localScale += Vector3.one / 500 * growth;
        }
        else
        {
            transform.localScale += Vector3.one / 500 * growth * transform.localScale.x;
        }
        transform.position = new Vector3(0, -0.75f*transform.localScale.x, 0);
        if(transform.localScale.x > sizeTrigger && !triggered)
        {
            GameObject form = Instantiate(gameObject);
            form.GetComponent<MeshFilter>().mesh = forms[Random.Range(0, forms.Length)];
            form.GetComponent<MeshCollider>().sharedMesh = form.GetComponent<MeshFilter>().mesh;
            triggered = true;
        }

        if (transform.localScale.x > sizeDestory)
        {
            Destroy(gameObject);
        }
    }
}
