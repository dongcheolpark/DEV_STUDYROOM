using UnityEngine;
public static class StageFactory {
	public static void getStage(int stage) {
		string path = "Prefabs/Stages/";
		try {
        	GameObject.Instantiate(Resources.Load(path+"Stage_"+stage));
		}
		catch {
			return;
		}
	}
}