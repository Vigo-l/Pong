using UnityEngine;
using TMPro;

public class BallShooter : MonoBehaviour
{
    public GameObject ballPrefab;
    public float shootForce = 20f;
    public TMP_Text ballCountText; // Reference to the TextMeshPro UI text element for ball count

    private GameObject lastBall;
    private int ballCount = 0;

    private void Start()
    {
        UpdateBallCountText();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootBall();
        }

        if (Input.GetMouseButtonDown(1))
        {
            DeleteLastBall();
        }
    }

    private void ShootBall()
    {
        GameObject ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);
        Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            Vector2 shootDirection = new Vector2(1, 0);
            if (GetComponent<PlayerController>())
            {
                shootDirection = new Vector2(-1, 0);
            }
            rb.AddForce(shootDirection * shootForce, ForceMode2D.Impulse);
            lastBall = ball;
            ballCount++;
            UpdateBallCountText();
        }
    }

    private void DeleteLastBall()
    {
        if (lastBall != null)
        {
            Destroy(lastBall);
            ballCount = Mathf.Max(0, ballCount - 1); // Ensure the ballCount doesn't go below zero
            UpdateBallCountText();
        }
    }

    private void UpdateBallCountText()
    {
        ballCountText.text = "Balls: " + ballCount.ToString();
    }
}
