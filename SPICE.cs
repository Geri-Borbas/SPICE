using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;


public class SPICE : MonoBehaviour
{


	public const string libraryBundlePath = "Assets/Plugins/eppz!/SPICE/SPICE.bundle";


	[Range(0,1)] public float side;
	[Range(0,1)] public float radius;
	[Range(0,1)] public float a;
	[Range(0,1)] public float b;


	[DllImport(libraryBundlePath)]
	extern static double CubeArea(double side);

	[DllImport(libraryBundlePath)]
	extern static double RectangleArea(double a, double b);

	[DllImport(libraryBundlePath)]
	extern static double CircleArea(double radius);

	
	void Update()
	{
		Debug.Log("CubeArea("+side+"): "+CubeArea(side));
		Debug.Log("RectangleArea("+a+", "+b+"): "+RectangleArea(a, b));
		Debug.Log("CircleArea("+radius+"): "+CubeArea(radius));
	}
}
