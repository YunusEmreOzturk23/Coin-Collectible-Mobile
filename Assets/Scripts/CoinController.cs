using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField]
    private int rotationSpeed = 500; // Dönme hýzý

    void Update()
    {
        // Nesneyi kendi ekseni etrafýnda döndürme
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
