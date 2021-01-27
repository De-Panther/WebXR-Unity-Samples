using UnityEngine;
using WebXR;

public class ControllerLookAt : MonoBehaviour
{
  [SerializeField]
  private WebXRController controller = null;
  [SerializeField]
  private Transform target = null;
  [SerializeField]
  private Vector3 worldUp = Vector3.up;
  [SerializeField]
  private Vector3 offset = Vector3.zero;

  private Transform _transform;
  private bool lookAt = false;
  private Quaternion startRotation;

  void Start()
  {
    _transform = transform;
    startRotation = _transform.localRotation;
  }

  private void OnEnable()
  {
    controller.OnControllerActive += EnableLookAt;
    controller.OnHandActive += EnableLookAt;
  }

  private void OnDisable()
  {
    controller.OnControllerActive -= EnableLookAt;
    controller.OnHandActive -= EnableLookAt;
  }

  void Update()
  {
    if (lookAt)
    {
      _transform.LookAt(target, worldUp);
      _transform.Rotate(offset);
    }
  }

  void EnableLookAt(bool active)
  {
    lookAt = active;
    if (!lookAt)
    {
      _transform.localRotation = startRotation;
    }
  }
}
