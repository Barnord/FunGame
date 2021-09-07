using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BricCube : MonoBehaviour
{
  public Vector3 RotationChange;
  // Start is called before the first frame update
  void Start()
  {
      
  }

  // Update is called once per frame
  void Update()
  {
    transform.Rotate(RotationChange);
  }
}
