using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class GameManager : MonoBehaviour
{
    [SerializeField] public SceneManager sceneManager;
    [SerializeField] public InputManager inputManager;
    [SerializeField] public MapManager mapManager;
    [SerializeField] public ResourceManager resourceManager;
    [SerializeField] public SoundManager soundManager;
    [SerializeField] public UIManager uIManager;
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
                Task.Delay(3000);
                UnityEngine.SceneManagement.SceneManager.LoadScene(1);
            }
            else if(_status == gameStatus.Clear) {
                Debug.Log("클리어");
                GameData.getInstance().clearStage();
                UnityEngine.SceneManagement.SceneManager.LoadScene(1);
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
        StageFactory.getStage(GameData.getInstance().stage);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
