namespace Cordonez.Modules.CustomScriptableObjects.Utils
{
	using Core;
	using UnityEngine;
	using UnityEngine.UI;

	[RequireComponent(typeof(Text))]
	public abstract class SOToText<TSo, TSoType> : MonoBehaviour where TSo : CustomScriptableObject<TSoType>
	{
		public TSo ScriptableVariable;

		private Text m_text;

		private void Awake()
		{
			m_text = GetComponent<Text>();
			UpdateText(ScriptableVariable);
		}

		private void OnEnable()
		{
			ScriptableVariable.AddListenerOnUpdate(OnValueUpdate);
		}

		private void OnValueUpdate(TSoType _arg1, TSoType _arg2)
		{
			UpdateText(_arg2);
		}

		private void UpdateText(TSoType _arg2)
		{
			m_text.text = _arg2.ToString();
		}

		private void OnDisable()
		{
			ScriptableVariable.RemoveListenerOnUpdate(OnValueUpdate);
		}
	}
}