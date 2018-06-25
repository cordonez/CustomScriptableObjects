namespace Cordonez.Modules.CustomScriptableObjects.Core
{
	using System;
	using UnityEngine;

	[Serializable]
	public abstract class CustomScriptableObject<T> : BaseCustomScriptableObject
	{
		[SerializeField]
		protected T m_value;

		[SerializeField]
		protected T m_runtimeValue;

		private Action<T, T> m_onValueUpdated;

		public virtual T Value
		{
			get { return Application.isPlaying ? m_runtimeValue : m_value; }
			set
			{
				T oldValue;
				if (Application.isPlaying)
				{
					oldValue = m_runtimeValue;
					m_runtimeValue = value;
				}
				else
				{
					oldValue = m_value;
					m_value = value;
				}

				if (m_onValueUpdated != null)
				{
					m_onValueUpdated(oldValue, Value);
				}
			}
		}

		public void AddListenerOnUpdate(Action<T, T> _callback)
		{
			m_onValueUpdated += _callback;
		}

		public void RemoveListenerOnUpdate(Action<T, T> _callback)
		{
			m_onValueUpdated -= _callback;
		}

		public static implicit operator T(CustomScriptableObject<T> _value)
		{
			return _value.Value;
		}

		protected override void OnEnableImpl()
		{
			ResetToDefault();
		}

		public virtual void ResetToDefault()
		{
			if (m_value.GetType().IsValueType)
			{
				m_runtimeValue = m_value;
			}
			else
			{
				throw new NotImplementedException();
			}
		}
	}
}