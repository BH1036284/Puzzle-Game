using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevate : MonoBehaviour
{
    public Animator m_Animator;
    public bool platformState;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Move();
    }

    void Move()
    {
        if (platformState == false)
            m_Animator.SetTrigger("Raise");
        else
            m_Animator.SetTrigger("Lower");
    }
}
