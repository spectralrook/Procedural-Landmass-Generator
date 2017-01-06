using UnityEngine;
using System.Collections;

[CreateAssetMenu()]
public class TerrainDetailData : UpdatableData {
	
	public float uniformScale = 2.5f;
	
	public bool useFlatShading;
	
	public bool useFalloff;
	
	public float meshHeightMultiplier;
	public AnimationCurve meshHeightCurve;
	
	[Range(0.5f,3f)]
	public float maxHeightMagnitude = 1f;	
	
	public float minHeight {
		get {
			return uniformScale * meshHeightMultiplier * meshHeightCurve.Evaluate (0);
		}	
	}
	
	public float maxHeight {
		get {
			return uniformScale * meshHeightMultiplier * meshHeightCurve.Evaluate (1);
		}	
	}
}
