namespace Cordonez.Modules.CustomScriptableObjects.Core.Variables
{
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.CUSTOM_VARIABLES + "SO_Scene")]
	public class SO_Scene : CustomScriptableObject<string>
	{
		public override void ResetToDefault()
		{
			m_runtimeValue = m_value;
		}
	}
}