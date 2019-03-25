namespace CustomScriptableObjects.Core.Variables
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.VARIABLES + "ULong")]
	[Serializable]
	public class VarULong : BaseVariable<ulong> { }
}