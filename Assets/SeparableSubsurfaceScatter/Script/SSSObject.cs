using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Renderer))]
public class SSSObject : MonoBehaviour {
    private List<Vector4> kernel = new List<Vector4>(11);
    public SkinData data;
	// Use this for initialization
	private void Awake () {
        data.renderer = GetComponent<Renderer>();
        SSSFunction.SetKernel(ref data, kernel);
    }

    private void OnWillRenderObject()
    {
        SSSFunction.UpdateSubsurface(ref SSSCamera.currentSkr, ref data, kernel);
    }
}
