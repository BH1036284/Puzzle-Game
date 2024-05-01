using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (transform.localScale != new Vector3(0, transform.localScale.y, 0))
            horizontalShrink();
        else 
            Destroy(gameObject);
    }

    // Shrinks the lock on the "x" and "z" axes
    private void horizontalShrink()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale, new Vector3(0, transform.localScale.y, 0), Time.deltaTime);
    }
}
