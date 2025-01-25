using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();

    void Start()
    {
        
    }

   
    void Update()
    {
        Vector2 inputVector = Vector2.zero;

        if (Input.GetKey(KeyCode.W)){
            inputVector += Vector2.up;
            Debug.Log("W key is pressed");
            }

        if (Input.GetKey(KeyCode.S)){
            inputVector += Vector2.down;
            Debug.Log("S key is pressed");
            }

        if (Input.GetKey(KeyCode.A)){
            inputVector += Vector2.left;
            Debug.Log("A key is pressed");
            }

        if (Input.GetKey(KeyCode.D)){
            inputVector += Vector2.right;
            Debug.Log("D key is pressed");
            }

        OnMove?.Invoke(inputVector);
    }
}
