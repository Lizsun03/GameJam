using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


//conditional, if 5 memories in inventory and step to certain location, end scene loads
public class EndSceneLoad : MonoBehaviour
{
	if (Inventory.memories = 5)
	{
		SceneManager.LoadScene("End Scene");
		Debug.Log("Scene Found");
	}
}
