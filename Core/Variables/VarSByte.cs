namespace CustomScriptableObjects.Core.Variables
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.VARIABLES + "SByte")]
	[Serializable]
	public class VarSByte : BaseVariable<sbyte> { }
}