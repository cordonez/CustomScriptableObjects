using System.Collections;
using System.Collections.Generic;
using Cordonez.Modules.CustomScriptableObjects.Core;
using UnityEngine;

public class TestReferenceInt : MonoBehaviour
{
	public ReferenceInt RefInt;

	// Use this for initialization
	void Start()
	{
		RefInt.Value = 3;
		
	}

	// Update is called once per frame
	void Update() { }
}