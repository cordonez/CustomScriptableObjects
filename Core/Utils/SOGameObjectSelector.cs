namespace CustomScriptableObjects.Core.Utils
{
	using System.Collections.Generic;
	using Collections;
	using Events;
	using UnityEngine;
	using Variables;

	public class SOGameObjectSelector : MonoBehaviour
	{
		public CollectionGameObject array;

		[HideInInspector]
		[SerializeField]
		private List<GameObject> m_collection = new List<GameObject>();

		public EventVoid Previous;
		public EventVoid Next;

		public VarGameObject Selected;

		private int m_indexSelected;

		private void Awake()
		{
			if (array.Value.Count == 0)
			{
				Debug.LogWarning("Empty collection. Disabling Gameobject selector: " + name);
				enabled = false;
				return;
			}

			foreach (GameObject ship in array.Value)
			{
				m_collection.Add(Instantiate(ship));
				m_collection[m_collection.Count - 1].SetActive(false);
			}

			Selected.Value = m_collection[0];
			UpdateSelection();
		}

		private void OnEnable()
		{
			Previous.AddListener(PreviousHandler);
			Next.AddListener(NextHandler);
		}

		private void OnDisable()
		{
			Previous.RemoveListener(PreviousHandler);
			Next.RemoveListener(NextHandler);
		}

		private void PreviousHandler()
		{
			m_collection[m_indexSelected].SetActive(false);
			m_indexSelected--;
			UpdateSelection();
		}

		private void NextHandler()
		{
			m_collection[m_indexSelected].SetActive(false);
			m_indexSelected++;
			UpdateSelection();
		}

		private void UpdateSelection()
		{
			if (m_indexSelected < 0)
			{
				m_indexSelected = m_collection.Count - 1;
			}
			else if (m_indexSelected >= m_collection.Count)
			{
				m_indexSelected = 0;
			}

			m_collection[m_indexSelected].SetActive(true);
			Selected.Value = array.Value[m_indexSelected];
		}

		private void OnDestroy()
		{
			for (int i = 0; i < m_collection.Count; i++)
			{
				Destroy(m_collection[i]);
			}
		}
	}
}