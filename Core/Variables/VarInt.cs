namespace CustomScriptableObjects.Core.Variables
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.VARIABLES + "Int")]
	[Serializable]
	public class VarInt : BaseVariable<int> { }
}