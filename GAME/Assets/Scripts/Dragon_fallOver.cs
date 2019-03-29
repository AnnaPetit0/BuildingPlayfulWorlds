using UnityEngine;

public class Dragon_fallOver : MonoBehaviour
{
    public GameObject barrier;
    private bool fallover1 = false;
    private bool fallover2 = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "fallOver1")
        {
            fallover1 = true;
            Debug.Log("fallover1 geactiveerd");
        }

        if (other.gameObject.tag == "fallOver2")
        {
                fallover2 = true;
                Debug.Log("fallover2 geactiveerd");
        }
        
        if(fallover1 == true && fallover2 == true)
        {
            barrier.SetActive(false);
        }
    }
}
