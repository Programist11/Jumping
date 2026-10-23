using UnityEngine;

public class UIScript : MonoBehaviour
{
    public GameObject startPanel;
    public void TapToStart()
    {
        Debug.Log("Tap to start on click");
        startPanel.SetActive(false);
    }
}
