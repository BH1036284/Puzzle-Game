using UnityEngine;
using UnityEngine.Events;

public class KeyGet : MonoBehaviour
{
    public UnityEvent KeyCollected = new UnityEvent();
    private void OnEnable()
    {
        
    }

    public void OnTriggerEnter(Collider Key)
    {
        if (gameObject.activeSelf)
        {
            KeyCollected.Invoke();

            gameObject.SetActive(false);
        }
    }
}
