
using UnityEngine;
using TMPro;

public class Target : MonoBehaviour
{
    public TMP_Text message;
    public TMP_Text scoreText;

    public int totalAlvos = 5;

    private int pontos = 0;
    private bool jogoTerminado = false;

    void Start()
    {
        message.text = "Apanha os alvos!";
        scoreText.text = "Pontos: 0/5";
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (jogoTerminado) return;

        if (other.CompareTag("Player"))
        {
            pontos++;

            scoreText.text = "Pontos: " + pontos + "/" + totalAlvos;

            if (pontos >= totalAlvos)
            {
                jogoTerminado = true;
                message.text = "GANHASTE!";
                gameObject.SetActive(false);
            }
            else
            {
                message.text = "Boa! Proximo alvo!";

                float x = Random.Range(-6f, 6f);
                float y = Random.Range(-3f, 3f);

                transform.position = new Vector3(x, y, transform.position.z);
            }
        }
    }
}
