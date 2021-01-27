using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRotationInvert : MonoBehaviour
{
  [SerializeField]
  private Transform target = null;

  private Transform _transform;

  void Start()
  {
    _transform = transform;
  }

  void Update()
  {
    _transform.localEulerAngles = target.localEulerAngles * (-1f);
  }
}
