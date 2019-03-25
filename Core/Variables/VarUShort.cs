namespace CustomScriptableObjects.Core.Variables
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.VARIABLES + "UShort")]
	[Serializable]
	public class VarUShort : BaseVariable<ushort> { }
}