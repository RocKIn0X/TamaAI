using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosText : MonoBehaviour {

  public Avatar avatar = null;

  // Use this for initialization
  void Start () {

  }

  // Update is called once per frame
  void Update () {
    if (avatar != null)
    {
      GetComponent<Text>().text = avatar.target.x + " - " + avatar.target.y;
    }
  }
}
