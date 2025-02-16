using UnityEngine;
using UnityEngine.Events;

public class BallController : MonoBehaviour
{
    [SerializeField] private float force = 1f;

    private bool isBallLaunched;
    private InputManager inputManager;
    private Rigidbody ballRB;
    void Start()
    {  
        ballRB = GetComponent<Rigidbody>();

        inputManager.OnSpacePressed.AddListener(LaunchBall);
        
    }

    private void LaunchBall()
    {
        if (isBallLaunched) return;

        isBallLaunched = true;
        ballRB.AddForce(transform.forward * force, ForceMode.Impulse);
    }


}
