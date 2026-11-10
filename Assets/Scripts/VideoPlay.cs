
using UnityEngine;

public class VideoPlay : MonoBehaviour {
    public Camera arCamera;

    [SerializeField]
    private string url = "https://www.youtube.com/";

    void Update() {
        // Detectar toque en el móvil
        if (Input.touchCount > 0 &&
            Input.GetTouch(0).phase == TouchPhase.Began) {
            DetectarToque(Input.GetTouch(0).position);
        }

        // Detectar clic en Unity
#if UNITY_EDITOR
        if (Input.GetMouseButtonDown(0)) {
            DetectarToque(Input.mousePosition);
        }
#endif
    }

    void DetectarToque(Vector2 posicion) {
        Ray ray = arCamera.ScreenPointToRay(posicion);

        if (Physics.Raycast(ray, out RaycastHit hit)) {
            if (hit.collider.gameObject == gameObject) {
                Debug.Log("Ambrosía pulsada");

                Application.OpenURL(url);
            }
        }
    }
}

