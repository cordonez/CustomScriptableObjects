namespace CustomScriptableObjects.Core.Variables
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.VARIABLES + "Byte")]
	[Serializable]
	public class VarByte : BaseVariable<byte> { }
}