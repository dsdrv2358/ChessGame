using UnityEngine;

public class GameUI : MonoBehaviour
{
    public static GameUI Instance { set; get; }

    private void Awake()
    {
        Instance = this;
    }
}
