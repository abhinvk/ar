using UnityEngine;
public class GeoTransform : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 50f;
    public float scaleSpeed = 0.5f;


    public static bool globalControl = false; // Toggle for common key movement


    void Update()
    {
        // Toggle global mode using Spacebar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            globalControl = !globalControl;
        }


        if (globalControl)
        {
            GlobalMovement(); // Move all objects together
        }
        else
        {
            IndividualMovement(); // Move objects separately
        }
    }


    void GlobalMovement()
    {
        // Move all objects using 1 (Forward), 2 (Backward), 3 (Left), 4 (Right)
        float moveX = 0, moveZ = 0;
        if (Input.GetKey(KeyCode.Alpha1)) moveZ += moveSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.Alpha2)) moveZ -= moveSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.Alpha3)) moveX -= moveSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.Alpha4)) moveX += moveSpeed * Time.deltaTime;
        transform.Translate(new Vector3(moveX, 0, moveZ));


        // Rotate all using 5 (Left) and 6 (Right)
        if (Input.GetKey(KeyCode.Alpha5)) transform.Rotate(Vector3.up, -rotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.Alpha6)) transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);


        // Scale all using 7 (Increase) and 8 (Decrease)
        if (Input.GetKey(KeyCode.Alpha7)) transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.Alpha8)) transform.localScale -= Vector3.one * scaleSpeed * Time.deltaTime;
    }


    void IndividualMovement()
    {
        if (gameObject.name == "Cube")
        {
            MoveCube();
        }
        else if (gameObject.name == "Sphere")
        {
            MoveSphere();
        }
        else if (gameObject.name == "Plane")
        {
            MovePlane();
        }
    }


    void MoveCube()
    {
        // Cube moves using WASD
        float moveX = 0, moveZ = 0;
        if (Input.GetKey(KeyCode.W)) moveZ += moveSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.S)) moveZ -= moveSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A)) moveX -= moveSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.D)) moveX += moveSpeed * Time.deltaTime;
        transform.Translate(new Vector3(moveX, 0, moveZ));


        // Rotate using Q and E
        if (Input.GetKey(KeyCode.Q)) transform.Rotate(Vector3.up, -rotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.E)) transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);


        // Scale using R and F
        if (Input.GetKey(KeyCode.R)) transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.F)) transform.localScale -= Vector3.one * scaleSpeed * Time.deltaTime;
    }


    void MoveSphere()
    {
        // Sphere moves using UHKJ
        float moveX = 0, moveZ = 0;
        if (Input.GetKey(KeyCode.U)) moveZ += moveSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.J)) moveZ -= moveSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.H)) moveX -= moveSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.K)) moveX += moveSpeed * Time.deltaTime;
        transform.Translate(new Vector3(moveX, 0, moveZ));


        // Rotate using Y and I
        if (Input.GetKey(KeyCode.Y)) transform.Rotate(Vector3.up, -rotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.I)) transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);


        // Scale using O and L
        if (Input.GetKey(KeyCode.O)) transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.L)) transform.localScale -= Vector3.one * scaleSpeed * Time.deltaTime;
    }


    void MovePlane()
    {
        // Plane moves using ZXCV
        float moveX = 0, moveZ = 0;
        if (Input.GetKey(KeyCode.Z)) moveZ += moveSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.V)) moveZ -= moveSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.X)) moveX -= moveSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.C)) moveX += moveSpeed * Time.deltaTime;
        transform.Translate(new Vector3(moveX, 0, moveZ));


        // Rotate using B and N
        if (Input.GetKey(KeyCode.B)) transform.Rotate(Vector3.up, -rotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.N)) transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);


        // Scale using M and <
        if (Input.GetKey(KeyCode.M)) transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.Comma)) transform.localScale -= Vector3.one * scaleSpeed * Time.deltaTime;
    }
}
