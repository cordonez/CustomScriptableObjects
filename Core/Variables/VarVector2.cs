namespace CustomScriptableObjects.Core.Variables
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.VARIABLES + "Vector2")]
	[Serializable]
	public class VarVector2 : BaseVariable<Vector2> { }
}