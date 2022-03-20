using UnityEngine;
public static class StageFactory {
	public static void getStage(int stage) {
		GameObject stageObj;
		string path = "Prefabs/Stages/";
		switch(stage) {
			case 1: 
        		GameObject.Instantiate(Resources.Load(path+"Stage_1"));
				break;
			default:
				return;
		}
	}
}