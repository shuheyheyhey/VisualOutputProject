using System;
using UnityEditor.TextCore.Text;
using UnityEngine;
using UnityEngine.VFX;
using Random = UnityEngine.Random;

public class Scene1 : MonoBehaviour
{
    public Camera camera;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public VisualEffect visualEffect;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.UpdateGameObjectsPosition();
        this.UpdateGameObjectsAngle();
    }

    private void UpdateGameObjectsPosition()
    {
        var positionRange = 1.5f;
        Vector3 newPosition1 = new Vector3(Random.Range(-0f, 0f), Random.Range(-positionRange, positionRange), Random.Range(-positionRange, positionRange));
        var newPosition2 = new Vector3(Random.Range(-0f, positionRange), Random.Range(-positionRange, positionRange), Random.Range(-positionRange, positionRange));
        var newPosition3 = new Vector3(Random.Range(-positionRange, positionRange), Random.Range(-positionRange, positionRange), Random.Range(-positionRange, positionRange));

        // var sinTheta = Math.Sin(Time.time);
        // var cosTheta = Math.Cos(Time.time);
        //
        // newPosition1.x = newPosition1.x * (float) sinTheta;
        // newPosition1.y = newPosition1.y * (float) sinTheta;
        // newPosition1.z = newPosition1.z * (float) sinTheta;
        //
        // newPosition2.x = newPosition2.x * (float) cosTheta;
        // newPosition2.y = newPosition2.y * (float) cosTheta;
        // newPosition2.y = newPosition2.y * (float) cosTheta;
        //
        // newPosition3.x = newPosition3.x * (float) cosTheta;
        // newPosition3.y = newPosition3.y * (float) cosTheta; newPosition3.y = newPosition3.y * (float) cosTheta;

        this.obj1.transform.position = newPosition1;
        this.obj2.transform.position = newPosition2;
        this.obj3.transform.position = newPosition3;

        var scale = this.transform.localScale * 3;
        //this.visualEffect.transform.localScale = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));

        var scale1 = Random.Range(0.1f, (float)1);
        var scale2 = Random.Range(0.1f, (float)1);
        var scale3 = Random.Range(0.1f, (float)1);

        this.obj1.transform.localScale = scale * scale1;
        this.obj2.transform.localScale = scale * scale2;
        this.obj3.transform.localScale = scale * scale3;
        
        this.UpdateCameraPosition();
    }

    private void UpdateGameObjectsAngle()
    {
    }

    private void UpdateCameraPosition()
    {
        var radius = 3f;
        var audioSignal = this.transform.localScale.x;
        var x = (float)(radius * Math.Sin(Time.time * audioSignal));
        var z = (float)(radius * Math.Cos(Time.time * audioSignal));
        //this.visualEffect.transform.rotation = new Quaternion(x, 0, z, 1);

        var max = 20f/audioSignal;
        // this.camera.transform.position =
        //     Vector3.Lerp(this.camera.transform.position, (new Vector3(Random.Range(-max, max), Random.Range(-max, max), Random.Range(-max, max))), Time.deltaTime * 5f);
        this.camera.transform.LookAt(Vector3.zero);
        
    }
}
