using UnityEngine;

public class FollowHand : MonoBehaviour
{
  [SerializeField]
  private Transform target = null;
  [SerializeField]
  private bool local = false;

  private Transform _transform;

  void Start()
  {
    _transform = transform;
  }

  void Update()
  {
    if (local)
    {
      _transform.localPosition = target.localPosition;
    }
    else
    {
      _transform.position = target.position;
    }
  }
}
