namespace CustomScriptableObjects.Core.Variables
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.VARIABLES + "UInt")]
	[Serializable]
	public class VarUInt : BaseVariable<uint> { }
}