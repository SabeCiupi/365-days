using UnityEngine;

public class MoveGameObject : MonoBehaviour
{
    public float speed = 5f;
    public float rotateSpeed = 100f;
    public float scaleSpeed = 1f;

    void Update()
    {
        Vector3 movement = Vector3.zero;
        Vector3 rotation = Vector3.zero;
        Vector3 scaleChange = Vector3.zero;

        if (Input.anyKey)
        {
            switch (Input.inputString.ToLower())
            {
                case "w":
                    movement = Vector3.forward;
                    break;
                case "s":
                    movement = Vector3.back;
                    break;
                case "a":
                    movement = Vector3.left;
                    break;
                case "d":
                    movement = Vector3.right;
                    break;
                case "q":
                    rotation = new Vector3(0, -rotateSpeed * Time.deltaTime, 0);
                    break;
                case "e":
                    rotation = new Vector3(0, rotateSpeed * Time.deltaTime, 0);
                    break;
                case "z":
                    scaleChange = Vector3.one * scaleSpeed * Time.deltaTime;
                    break;
                case "x":
                    scaleChange = -Vector3.one * scaleSpeed * Time.deltaTime;
                    break;
            }

            transform.Translate(movement * speed * Time.deltaTime);
            transform.Rotate(rotation);
            transform.localScale += scaleChange;
        }
    }
}
