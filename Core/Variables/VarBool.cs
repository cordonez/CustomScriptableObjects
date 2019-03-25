namespace CustomScriptableObjects.Core.Variables
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.VARIABLES + "Bool")]
	[Serializable]
	public class VarBool : BaseVariable<bool> { }
}