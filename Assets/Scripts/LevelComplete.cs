using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    [SerializeField] private float posX;
    [SerializeField] private float posZ;

    private void OnEnable()
    {

    }

    private void Update()
    {
        if (transform.position.y != 5)
            moveLevelUp();
        else
        {
            moveLevel();
            resetRotation();
            if (transform.position == new Vector3(posX, 0, posZ))
                enabled = false;
        }
    }
    public void resetRotation()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 0), 10f * Time.deltaTime);
    }

    public void moveLevel()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(posX, transform.position.y, posZ),  5f * Time.deltaTime);
    }

    public void moveLevelUp()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 5, transform.position.z), 5f * Time.deltaTime);
    }
}
