using System;
using UnityEngine;

namespace Cordonez.Modules.CustomScriptableObjects.Core
{
	public abstract class CustomScriptableEvent : BaseCustomScriptableObject
	{
		[SerializeField]
		private Action m_actions;

		public virtual void Invoke()
		{
			if (m_actions != null)
			{
				m_actions();
			}
		}

		public virtual void AddListener(Action _callback)
		{
			m_actions += _callback;
		}

		public virtual void RemoveListener(Action _callback)
		{
			m_actions -= _callback;
		}

		public virtual void ClearCallbacks()
		{
			m_actions = null;
		}
	}

	public abstract class CustomScriptableEvent<T1> : BaseCustomScriptableObject
	{
		[SerializeField]
		private Action<T1> m_actions;

		public virtual void Invoke(T1 _t1)
		{
			if (m_actions != null)
			{
				m_actions(_t1);
			}
		}

		public virtual void AddListener(Action<T1> _callback)
		{
			m_actions += _callback;
		}

		public virtual void RemoveListener(Action<T1> _callback)
		{
			m_actions -= _callback;
		}

		public virtual void ClearCallbacks()
		{
			m_actions = null;
		}
	}

	public abstract class CustomScriptableEvent<T1, T2> : BaseCustomScriptableObject
	{
		[SerializeField]
		private Action<T1, T2> m_actions;

		public virtual void Invoke(T1 _t1, T2 _t2)
		{
			if (m_actions != null)
			{
				m_actions(_t1, _t2);
			}
		}

		public virtual void AddListener(Action<T1, T2> _callback)
		{
			m_actions += _callback;
		}

		public virtual void RemoveListener(Action<T1, T2> _callback)
		{
			m_actions -= _callback;
		}

		public virtual void ClearCallbacks()
		{
			m_actions = null;
		}
	}

	public abstract class CustomScriptableEvent<T1, T2, T3> : BaseCustomScriptableObject
	{
		[SerializeField]
		private Action<T1, T2, T3> m_actions;

		public virtual void Invoke(T1 _t1, T2 _t2, T3 _t3)
		{
			if (m_actions != null)
			{
				m_actions(_t1, _t2, _t3);
			}
		}

		public virtual void AddListener(Action<T1, T2, T3> _callback)
		{
			m_actions += _callback;
		}

		public virtual void RemoveListener(Action<T1, T2, T3> _callback)
		{
			m_actions -= _callback;
		}

		public virtual void ClearCallbacks()
		{
			m_actions = null;
		}
	}
}