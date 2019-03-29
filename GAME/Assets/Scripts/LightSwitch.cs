using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject LightPanel;
    public GameObject player;
    public GameObject Lights;
    public GameObject Barrier;
  
    public float MaxrangeLight;

    private bool inRange = false;

    private void OnMouseOver()
    {
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist <= MaxrangeLight)
        {
            LightPanel.SetActive(true);
            inRange = true;
        }
    }

    private void OnMouseExit()
    {
        LightPanel.SetActive(false);
    }

    private void OnMouseDown()
    {
        if (inRange)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Lights.SetActive(true);
                Barrier.SetActive(false);
            }
        }
    }
}