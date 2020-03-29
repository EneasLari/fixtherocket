using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody rigidbody;
    AudioSource audiosource;

    [SerializeField]//editale only in inspector not from other scripts
    float rcsThrust = 30;
    [SerializeField]//editale only in inspector not from other scripts
    float mainThrust = 300;

    public enum State {Alive,Dying,Transcending};

    public static State GameState = State.Alive;
   // Start is called before the first frame update
   void Start() {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.constraints = RigidbodyConstraints.FreezeRotationX
            | RigidbodyConstraints.FreezeRotationY
            | RigidbodyConstraints.FreezePositionZ;
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {
        Thrust();
        Rotate();
    }

    private void Rotate() {
        rigidbody.freezeRotation = true;//take manual control of rotation
        float rotationThisFrame = rcsThrust * Time.deltaTime;
        if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(Vector3.forward * rotationThisFrame);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(-Vector3.forward * rotationThisFrame);
        }

        rigidbody.freezeRotation = false;//take physics control of rotation
    }

    private void Thrust() {
        if (Input.GetKey(KeyCode.Space)) {
            print("GO UP");
            if (!audiosource.isPlaying) {
                audiosource.Play();
            }
            rigidbody.AddRelativeForce(Vector3.up * mainThrust);
        } else {
            audiosource.Stop();
        }
    }

    void OnCollisionEnter(Collision collision) {
        switch (collision.gameObject.tag) {
            case "Friendly":
                print("Hit the fan");
                break;
            case "Fuel":
                print("Hit the fan");
                break;
            default:
                print("dead");
                break;
        }
    }
}
