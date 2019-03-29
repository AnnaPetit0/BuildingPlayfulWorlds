using UnityEngine;

public class Instructions4 : MonoBehaviour
{
    public GameObject doorPanel4;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            doorPanel4.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        doorPanel4.SetActive(false);
    }
}
