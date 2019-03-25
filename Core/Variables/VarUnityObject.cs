namespace CustomScriptableObjects.Core.Variables
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.VARIABLES + "UnityObject")]
	[Serializable]
	public class VarUnityObject : BaseVariable<UnityEngine.Object> { }
}