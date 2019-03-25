namespace CustomScriptableObjects.Core.Variables
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.VARIABLES + "GameObject")]
	[Serializable]
	public class VarGameObject : BaseVariable<GameObject> { }
}