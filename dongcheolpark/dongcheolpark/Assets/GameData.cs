using UnityEngine;
public class GameData
{
    GameData() {
        stage = 1;
    }
	private int _stage;
    private int _StageAppleCount;
    public int StageAppleCount {
        get { return _StageAppleCount; }
        set {
            _StageAppleCount = value;
            GameManager.GetInstance().uIManager.changeAppleCount(_StageAppleCount);
        }
    }
    public int stage {
        get {return _stage;}
        private set {
            _stage = value;
        }
    }
    private static GameData _instance = null;

    public static GameData getInstance() {
        if(_instance == null) {
            _instance = new GameData();
        }
        return _instance;
    }

    public void clearStage() {
        _stage++;
    }
}