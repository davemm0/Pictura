using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[SerializeField]
public class PointOfInterest : MonoBehaviour {

    public enum TYPE { STATIC, AUDIO, ANIMATION, FORCE, COLOR, PARTICLE }

    public bool isSecret = false;
    public int points = 10;
    public float minDistance = 5.0f;
    public float optimalDistance = 10.0f;
    public float maxDistance = 100.0f;

    public bool useAngle = false;
    public float angleFalloff = 90.0f;

    public TYPE type = TYPE.STATIC;

    public float actionTime = 1.0f;
    public int actionBonus = 0;
    public bool actionRepeatable = false;

    public GameObject[] affectedObjects;

    public Vector3 force;
    public Vector3 forceApplicationPoint;
    public Color color;
    public string animationTriggerName;

#if UNITY_EDITOR

    void OnDrawGizmosSelected() {
        if (useAngle) {
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(transform.position, transform.position - transform.forward * maxDistance);

            Gizmos.color = Color.green;
            Gizmos.DrawLine(transform.position, transform.position - transform.forward * optimalDistance);

            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, transform.position - transform.forward * minDistance);
        }
        else {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, maxDistance);

            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(transform.position, optimalDistance);

            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, minDistance);
        }
    }

#endif
}
