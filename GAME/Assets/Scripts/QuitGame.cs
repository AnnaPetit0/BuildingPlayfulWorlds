
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void Quit ()
    {
        Cursor.visible = true;
        Application.Quit();
        Debug.Log("QUIT GAME");
    }

}
