using UnityEngine;
using System.Collections;

public class floatyScript2: MonoBehaviour
{
    public AnimationCurve curve;

    void Start()
    {
        curve = new AnimationCurve(new Keyframe(0, 0), new Keyframe(1, 1));
        curve.preWrapMode = WrapMode.PingPong;
        curve.postWrapMode = WrapMode.PingPong;
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, curve.Evaluate(Time.time) + 4.4f, transform.position.z);
    }
}