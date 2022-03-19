using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameManager : MonoBehaviour
{
    [SerializeField] public SceneManager sceneManager;
    [SerializeField] public InputManager inputManager;
    [SerializeField] public MapManager mapManager;
    private static GameManager Instance;

    public static GameManager GetInstance() {
        return Instance;
    }
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
