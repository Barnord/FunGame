using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround;

  private Rigidbody _playerRb;
  // Start is called before the first frame update
  void Start()
  {
    _playerRb = GetComponent<Rigidbody>();
    Physics.gravity *= gravityModifier;
        isOnGround = true;
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space))
    {
      _playerRb.AddForce(Vector3.up * jumpForce);
    }
  }

  private void OnCollision()
  {
    isOnGround = true;
  }
}
