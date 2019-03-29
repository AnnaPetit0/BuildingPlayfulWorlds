using UnityEngine;

public class Instructions2: MonoBehaviour
{
    public GameObject doorPanel2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            doorPanel2.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        doorPanel2.SetActive(false);
    }
}
