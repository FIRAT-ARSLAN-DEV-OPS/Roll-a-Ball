using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Rigidbody fizik;
    public float hiz = 10f; // float kullanmak daha iyi olur

    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        if (fizik == null)
        {
            Debug.LogError("Rigidbody bileşeni bulunamadı!");
        }
    }

    void FixedUpdate()
    {
        if (fizik == null) return; // Rigidbody yoksa işlemi durdur

        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vector = new Vector3(yatay, 0, dikey).normalized; // Normalize edilerek hız kontrolü sağlanır

        fizik.AddForce(vector * hiz, ForceMode.Acceleration); // Daha kontrollü hareket
    }
}
