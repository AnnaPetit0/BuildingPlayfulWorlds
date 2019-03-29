using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public GameObject player;
    public GameObject river;
    public GameObject barrier;
    public GameObject steeringWheel;
    public GameObject textPanel;

    public float Maxrange_steeringWheel;
    public float MaxRange_plane_barrier;

    private bool inRange = false;
    private bool WillMove = false;
    
    private void OnMouseOver()
    {
        float dist = Vector3.Distance(player.transform.position, steeringWheel.transform.position);
        if (dist <= Maxrange_steeringWheel)
        {
            textPanel.SetActive(true);
            inRange = true;
        }
    }

    private void OnMouseExit()
    {
        textPanel.SetActive(false);
        inRange = false;
    }

    private void OnMouseDown()
    {
        if (inRange)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("mousedown");
                player.GetComponent<FirstPersonAIO>().enabled = false;

                WillMove = true;

                player.transform.eulerAngles = new Vector3(
                player.transform.eulerAngles.x - 28.4f,
                player.transform.eulerAngles.y - 15f,
                player.transform.eulerAngles.z);
                Debug.Log("passed rotation");

            }
        }
    }

    private void Update()
    {
        if (WillMove)
        {
            textPanel.SetActive(false);
            player.transform.position = transform.position + new Vector3(0.021f, 1.686f, 0f);
            transform.Translate(new Vector3(1.5f,0,0) * Time.deltaTime);
        }

        float distance = Vector3.Distance(barrier.transform.position, transform.position);
        if (distance <= MaxRange_plane_barrier)
        {
            WillMove = false;
            textPanel.SetActive(false);
            barrier.SetActive(false);
            player.GetComponent<FirstPersonAIO>().enabled = true;
        }
    }
}
