using Cordonez.Modules.CustomScriptableObjects.Core;
using UnityEngine;
using UnityEngine.UI;

namespace Cordonez.Modules.CustomScriptableObjects.Utils
{
	[RequireComponent(typeof(Text))]
	public abstract class SOToText<TSo, TSoType> : MonoBehaviour where TSo : CustomScriptableObject<TSoType>
	{
		public TSo ScriptableVariable;

		private Text m_text;

		private void Awake()
		{
			m_text = GetComponent<Text>();
			OnValueUpdate();
		}

		private void OnEnable()
		{
			ScriptableVariable.AddListenerOnUpdate(OnValueUpdate);
		}

		private void OnDisable()
		{
			ScriptableVariable.RemoveListenerOnUpdate(OnValueUpdate);
		}

		private void OnValueUpdate()
		{
			m_text.text = ScriptableVariable.Value.ToString();
		}
	}
}