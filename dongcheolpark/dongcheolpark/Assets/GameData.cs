using UnityEngine;
public class GameData
{
    GameData() {
        stage = 1;
    }
	private int _stage;
    public int stage {
        get {return _stage;}
        private set {
            stage = value;
        }
    }
    private GameData _instance = null;

    public GameData instance {
        get {
            if(_instance == null) {
                _instance = new GameData();
            }
            return _instance;
        }
    }

    public void clearStage() {
        _stage++;
    }
}