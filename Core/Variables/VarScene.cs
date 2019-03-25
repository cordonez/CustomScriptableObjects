namespace CustomScriptableObjects.Core.Variables
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.VARIABLES + "Scene")]
	[Serializable]
	public class VarScene : BaseVariable<string> { }
}