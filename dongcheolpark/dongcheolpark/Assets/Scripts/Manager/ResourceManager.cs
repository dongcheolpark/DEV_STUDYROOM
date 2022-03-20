using UnityEngine;
public class ResourceManager : MonoBehaviour {
	public GameObject getPrefabs(string src) {
		GameObject res = Resources.Load<GameObject>("Prefabs/"+src);
		if(res == null) {
			Debug.Log("잘못된 경로이거나 해당 경로에 오브젝트가 존재하지 않습니다.");
			return null;
		}
		return res;
	}
}