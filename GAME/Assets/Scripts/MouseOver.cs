using UnityEngine;

public class MouseOver : MonoBehaviour
{
    public GameObject doorPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            doorPanel.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        doorPanel.SetActive(false);
    }
}
