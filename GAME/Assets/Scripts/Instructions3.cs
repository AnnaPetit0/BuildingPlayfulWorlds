using UnityEngine;

public class Instructions3 : MonoBehaviour
{
    public GameObject doorPanel3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            doorPanel3.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        doorPanel3.SetActive(false);
    }
}