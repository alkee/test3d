using UnityEngine;

public class SampleTester
    : MonoBehaviour
{
    public aus.Geometry.WavefrontObjMesh objLoader;

    #region Unity message handlers
    async void Start()
    {
        var objFilePath = Application.streamingAssetsPath + "/mesh/HeadSample1.obj";
        await objLoader.LoadAsync(objFilePath);
        var mesh = objLoader.GetMeshFilter().mesh;
        Camera.main.transform.position = mesh.bounds.center + Vector3.up * 0.7f;
        Camera.main.transform.LookAt(mesh.bounds.center);
    }
    #endregion
}
