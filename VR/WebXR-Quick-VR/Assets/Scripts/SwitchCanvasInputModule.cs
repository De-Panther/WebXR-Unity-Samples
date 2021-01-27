using UnityEngine;
using UnityEngine.EventSystems;
using WebXR;

public class SwitchCanvasInputModule : MonoBehaviour
{
  public WebXRController controller;
  public GameObject controllerRay;
  public Camera mainCamera;
  public Camera controllerCamera;
  public ControllerInputModule controllerInputModule;
  public StandaloneInputModule standaloneInputModule;
  public Canvas canvas;

  public void Awake()
  {
    HandleControllerActive(false);
  }

  private void OnEnable()
  {
    if (controller.isControllerActive)
    {
      HandleControllerActive(true);
    }
    controller.OnControllerActive += HandleControllerActive;
  }

  private void OnDisable()
  {
    controller.OnControllerActive -= HandleControllerActive;
  }
  
  private void HandleControllerActive(bool active)
  {
    if (active)
    {
      controllerInputModule.enabled = true;
      standaloneInputModule.enabled = false;
      canvas.worldCamera = controllerCamera;
      controllerRay.SetActive(true);
    }
    else
    {
      controllerInputModule.enabled = false;
      standaloneInputModule.enabled = true;
      canvas.worldCamera = mainCamera;
      controllerRay.SetActive(false);
    }
  }
}
