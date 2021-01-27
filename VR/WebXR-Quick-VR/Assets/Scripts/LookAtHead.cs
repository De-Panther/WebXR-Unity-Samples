using UnityEngine;

public class LookAtHead : MonoBehaviour
{
  [SerializeField]
  private Transform target = null;
  [SerializeField]
  private bool transformLevel = false;

  private Transform _transform;
  private Vector3 targetPosition = Vector3.zero;

  void Start()
  {
    _transform = transform;
  }

  void Update()
  {
    targetPosition = target.position;
    if (transformLevel)
    {
      targetPosition.y = _transform.position.y;
    }
    _transform.LookAt(targetPosition);
  }
}
