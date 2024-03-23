using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateIt : MonoBehaviour
{
    [SerializeField] private GameObject _steve;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_steve, new Vector3(1,1,1), Quaternion.identity);
    }
}
