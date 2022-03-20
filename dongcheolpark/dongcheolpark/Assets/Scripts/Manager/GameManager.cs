using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameManager : MonoBehaviour
{
    [SerializeField] public SceneManager sceneManager;
    [SerializeField] public InputManager inputManager;
    [SerializeField] public MapManager mapManager;
    [SerializeField] public ResourceManager resourceManager;
    [SerializeField] public SoundManager soundManager;
    public enum gameStatus {Play,Death,Clear};
    private gameStatus _status;
    public gameStatus status {
        get { return _status; }
        set {
            _status = value;
            Debug.Log(_status);
            if(_status == gameStatus.Play) {

            }
            else if(_status == gameStatus.Death) {

            }
        }
    }
    private static GameManager Instance;

    public static GameManager GetInstance() {
        return Instance;
    }
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        status = gameStatus.Play;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
