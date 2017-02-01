/* Author: Jan Groß
 * 
 * C# Script for tests
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSharpTestScript : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		this.gameObject.transform.Rotate (new Vector3 (0, 100 * Time.deltaTime, 0));
	}
}
