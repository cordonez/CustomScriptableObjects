namespace CustomScriptableObjects.Core.Variables
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.VARIABLES + "Double")]
	[Serializable]
	public class VarDouble : BaseVariable<double> { }
}