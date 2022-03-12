using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public SceneManager sceneManager {get;}
    public InputManager inputManager {get;}
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
