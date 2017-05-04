using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

    [Header("Qual a velocidade da rotação?")]
    public float velocidade;

    void FixedUpdate () {
        transform.Rotate(new Vector3(0f, 0f, velocidade) * Time.deltaTime);
    }
}
