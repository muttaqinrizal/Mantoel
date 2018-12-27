using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerak : MonoBehaviour {
    //public untuk global variabel
    public float kecepatan=10;
    float cepat = 20;
    Vector2 ball;
    Rigidbody2D lompat;
	// Use this for initialization
	void Start () {
        //harus diinialisasi
        lompat = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        //Get key sebagai inputan tombol, keycode berdasarkan code tombol
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Translate untuk pergerakan object, vector2 merupakan vector x dan y, vector3 xyz
            transform.Translate(Vector2.right * kecepatan * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * kecepatan * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            lompat.AddForce(new Vector2(0, cepat));
        }


	}
}
