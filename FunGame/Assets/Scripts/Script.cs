using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
  private float speed = 30.0f;

  public Vector3 scaleChange;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    transform.Translate(Vector3.left * Time.deltaTime * speed);
  }
}
