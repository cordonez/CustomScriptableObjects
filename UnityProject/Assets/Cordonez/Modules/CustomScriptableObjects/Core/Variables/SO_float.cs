using UnityEngine;

namespace Cordonez.Modules.CustomScriptableObjects.Core.Variables
{
	[CreateAssetMenu(menuName = MenuPath.VARIABLES + "SO_float")]
	[System.Serializable]
	public class SO_float : CustomScriptableObject<float>
	{
	}
}