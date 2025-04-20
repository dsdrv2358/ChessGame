using UnityEngine;

public class GameUI : MonoBehaviour
{
    public static GameUI Instance { set; get; }

    private void Awake()
    {
        Instance = this;
    }

    // Buttons
    public void OnLocalGameButton()
    {
        Debug.Log("OnLocalGameButton");
    }
    public void OnOnlineGameButton()
    {
        Debug.Log("OnOnlineGameButton");
    }
}
