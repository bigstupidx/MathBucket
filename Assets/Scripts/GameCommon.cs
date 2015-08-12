﻿using UnityEngine;
using System.Collections;
using System;

public class GameCommon : MonoBehaviour 
{
	public static Color ballColorBackDigit;
	public static float ballScaleDigit;

	public static Color ballColorBackOperand;
	public static float ballScaleOperand;

	public static Color ballColorBackEquals;
	public static float ballScaleEquals;

	public static Color ballColorHilite;	

	public static void InitDefaults()
	{
		//default colors & scales
		ballColorBackDigit = new Color(0.9f, 0.9f, 0.9f, 1f);
		ballScaleDigit = 1f;

		ballColorBackOperand = new Color(0.5f, 0.5f, 0.5f, 1f);
		ballScaleOperand = 0.75f;

		ballColorBackEquals = new Color(0.3f, 0.3f, 0.3f, 1f);
		ballScaleEquals = 0.65f;

		ballColorHilite = new Color(0.9f, 0.9f, 0.9f, 1f);

	}

	static public CentralCalculator getCentralCalculatorClass()
	{
		GameObject _centralCalculatorObject = GameObject.Find("CentralCalculator");
		if (_centralCalculatorObject != null) 
		{
			CentralCalculator _centralCalculatorScript = _centralCalculatorObject.GetComponent<CentralCalculator> ();
			if(_centralCalculatorScript != null) 
			{
				return _centralCalculatorScript;
			}
			Debug.Log("_centralCalculatorScript == null");
			throw new Exception();
		}
		Debug.Log("_centralCalculatorObject = null");
		throw new Exception();
	}

	static public FormulaFactory getFormulaFactoryClass()
	{
		GameObject _formulaFactoryObject = GameObject.Find("FormulaFactory");
		if (_formulaFactoryObject != null) 
		{
			FormulaFactory _formulaFactoryScript = _formulaFactoryObject.GetComponent<FormulaFactory> ();
			if(_formulaFactoryScript != null) 
			{
				return _formulaFactoryScript;
			}
			Debug.Log("_formulaFactoryScript == null");
			throw new Exception();
		}
		Debug.Log("_formulaFactoryObject = null");
		throw new Exception();
	}

}