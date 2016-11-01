using UnityEngine;
using System.Collections;
using UnityEditor;

public class DeletePlayerPrefs : ScriptableObject {

	[MenuItem ("Editor/Delete Player Prefs")]
	static void DeletePrefs()
	{
		if (EditorUtility.DisplayDialog ("Delete all player preferences?",
			   "Are you sure you want to delete all the player preferences, this action cannot be undone." +
			   "Yes",
			   "No")) {
			PlayerPrefs.DeleteAll ();
		}
	}
}
