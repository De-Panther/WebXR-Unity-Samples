using UnityEngine;
using WebXR;

public class FollowHead : MonoBehaviour
{
  [SerializeField]
  private WebXRCamera webXRCamera = null;

  private Transform _transform;

  void Start()
  {
    _transform = transform;
  }

  void Update()
  {
    _transform.localPosition = webXRCamera.GetLocalPosition();
    _transform.rotation = webXRCamera.GetLocalRotation();
  }
}
