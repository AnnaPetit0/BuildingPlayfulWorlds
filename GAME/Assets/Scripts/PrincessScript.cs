using UnityEngine;
using UnityEngine.SceneManagement;

public class PrincessScript : MonoBehaviour
{
    public GameObject PrincessPanel;
    public GameObject player;

    public float MaxrangePrincess;

    private void OnMouseOver()
    {
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist <= MaxrangePrincess)
        {
            player.transform.position = new Vector3(-0.9905268f, 0.6146761f, -110.14f);
            PrincessPanel.SetActive(true);
            player.GetComponent<FirstPersonAIO>().enabled = false;
        }
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
}
