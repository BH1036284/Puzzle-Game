using UnityEngine;
using UnityEngine.Events;

public class ReachGoal : MonoBehaviour
{
    public UnityEvent GoalEntered = new UnityEvent();
    private void OnEnable()
    {
        
    }

    public void OnTriggerEnter(Collider Goal)
    {
        if (gameObject.activeSelf)
        {
            GoalEntered.Invoke();

            gameObject.SetActive(false);
        }
    }
}