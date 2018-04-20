using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour {

  public Vector2 target;

  // Use this for initialization
  void Start () {
    target = new Vector2(transform.position.x, transform.position.y);
  }

  // Update is called once per frame
  void Update () {
    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
    {
      target = Input.GetTouch(0).position;
    }
    else if (Input.GetButtonDown("Tap"))
    {
      target = Input.mousePosition;
    }
  }
}
