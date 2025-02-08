using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    private Vector3 distance;

    void Start()
    {
        if (ball == null)
        {
            Debug.LogError("Takip edilecek top atanmadı! Lütfen Inspector'dan atayın.");
            enabled = false; // Bileşeni devre dışı bırak, gereksiz çalışmasını önler
            return;
        }

        distance = transform.position - ball.transform.position;
    }

    void LateUpdate()
    {
        if (ball != null) // Güvenlik kontrolü
        {
            transform.position = ball.transform.position + distance;
        }
    }
}
