using Assets.Scripts.PersistentData;
using Assets.Scripts.UserSystem.GlobalData;
using PathCreation;
using PathCreation.Examples;
using PathCreation.PathFollower;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCollider : MonoBehaviour
{

    private AudioSource ExplosionAudioSource;
    public AudioClip ExplosionClip;
    public GameObject BeforeExplosion;
    public float ExplosionPower = 60f;
    public GameObject OnLosePanel;


    private void Start() {
        GlobalData.SerialType = SerializationType.Binary;
        ExplosionAudioSource=gameObject.GetComponent<AudioSource>();
        ExplosionAudioSource.volume = GlobalData.GeneralSettings.Mastervolume;
    }
    void OnCollisionEnter(Collision collision) {
        switch (collision.gameObject.tag) {
            case "Player":
                //print("Hit the player");
                if (gameObject.GetComponent<ObstacleMovement>()!=null) {
                    gameObject.GetComponent<ObstacleMovement>().enabled = false;
                }
                if (gameObject.GetComponent<ObstacleMovement>().particleSystemSmoke != null) {
                    gameObject.GetComponent<ObstacleMovement>().particleSystemSmoke.SetActive(false);
                }
                GameObject parent= transform.Find("ExplosionPecies").gameObject;
                parent.SetActive(true);
                BeforeExplosion.GetComponent<MeshRenderer>().enabled = false;
                BeforeExplosion.GetComponent<MeshCollider>().enabled = false;
                ExplosionAudioSource.clip = ExplosionClip;
                ExplosionAudioSource.PlayOneShot(ExplosionAudioSource.clip);
                Destroy(gameObject, 4f);
                Explode(parent);
                collision.gameObject.transform.parent.gameObject.GetComponent<RocketPathFollower>().enabled = false;
                ExplodePlayer(collision.gameObject.transform.parent.gameObject);
                Invoke("LoadOnLosePanel", 2f);
                break;
            case "Fuel":
                print("Hit the fan");
                break;
            default:
                print("Hit Some Object");
                break;
        }
    }
    private float radius = 20;


    private void ExplodePlayer(GameObject player) {
        GameObject parent = player.transform.Find("ExplosionPecies").gameObject;
        List<Transform> childs = new List<Transform>();
        foreach (Transform child in player.transform) {
            if (child.gameObject.GetComponent<Rigidbody>() == null) {
                child.gameObject.AddComponent<Rigidbody>();
                child.gameObject.GetComponent<Rigidbody>().mass = 0.1f;
                childs.Add(child);
            }
        }
        parent.SetActive(true);
        ExplosionAudioSource.clip = ExplosionClip;
        ExplosionAudioSource.PlayOneShot(ExplosionAudioSource.clip);
        Destroy(gameObject, 4f);
        Explode2(parent);
        foreach (Transform child in childs) {
            child.parent = null;
            Destroy(child.gameObject, 4f);
            child.gameObject.tag = "Untagged";
            if (child.name.Equals("FlameParticleSystem")) {
                child.GetChild(0).gameObject.SetActive(false);
            }
        }
        player.GetComponent<AudioSource>().Stop();
    }


    private void Explode(GameObject explosionparent) {
        Vector3 explosionPos = explosionparent.transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders) {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(ExplosionPower, explosionPos, radius, 3.0F);
        }
    }

    private void Explode2(GameObject explosionparent) {
        Vector3 explosionPos = explosionparent.transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius*2);
        foreach (Collider hit in colliders) {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(ExplosionPower*2, explosionPos, radius*2, 3.0F);
        }
    }

    public void LoadOnLosePanel() {
        OnLosePanel.SetActive(true);
    }

    private void Update() {
        if (ExplosionAudioSource.volume != GlobalData.GeneralSettings.Mastervolume) {
            ExplosionAudioSource.volume = GlobalData.GeneralSettings.Mastervolume;
        }
        
    }

}
