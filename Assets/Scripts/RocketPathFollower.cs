using Assets.Scripts.PersistentData;
using UnityEngine;

namespace PathCreation.PathFollower
{

    // Moves along a path at constant speed.
    // Depending on the end of path instruction, will either loop, reverse, or stop at the end of the path.
    public class RocketPathFollower : MonoBehaviour {


        public PathCreator pathCreator;
        public EndOfPathInstruction endOfPathInstruction;
        public GameObject OnWinPanel;
        public float speed = 5;
        float distanceTravelled;
        AudioSource audiosource;
        public GameObject FlameParticleSystem;

        public static RocketState rocketState=RocketState.None;
        void Start() {
            startingPosition = transform.position;
            endingPosition = new Vector3(transform.position.x, transform.position.y + Distance, transform.position.z);
            FlameParticleSystem.SetActive(false);
            audiosource = GetComponent<AudioSource>();
            audiosource.Stop();
        }

        void Update() {
            //if (Input.GetMouseButtonDown(0))
            //    print("Pressed");
            //else if (Input.GetMouseButtonUp(0))
            //    print("Released");

            if (rocketState == RocketState.StartEngines) {
                StartTheEngines();
                rocketState = RocketState.StartEnginesMove;
            } else if (rocketState == RocketState.StartEnginesMove) {
                StartTheEnginesMove();
            } else if (rocketState == RocketState.StartMoving) {
                Thrust();
            }


        }

        public void  StartEngineEvent() {
            rocketState = RocketState.StartEngines;
            StartTheEngines();
            if (pathCreator != null) {
                // Subscribed to the pathUpdated event so that we're notified if the path changes during the game
                pathCreator.pathUpdated += OnPathChanged;
            }
        }

        private void StartTheEngines() {
            audiosource.Play();
            FlameParticleSystem.SetActive(true);
        }

        //only for the StartEngineMove
        private Vector3 startingPosition;
        private Vector3 endingPosition;
        private float Timer;
        private float SpeedForFirstMove=0.2f;
        private float Distance = 2;
        private void StartTheEnginesMove() {
            Timer += Time.deltaTime * SpeedForFirstMove;
            transform.position = Vector3.Lerp(startingPosition, endingPosition, Timer);
        }

        private bool finished = false;
        private void Thrust() {
            if (!finished && !Input.GetKey(KeyCode.Space) && !Input.GetMouseButton(0)) {
                audiosource.pitch = 1;
                //print("GO UP");
                //if (audiosource!=null && !audiosource.isPlaying) {
                //    audiosource.Play();
                //}
                if (pathCreator != null) {
                   // print(distanceTravelled + "--" + pathCreator.path.length);
                    distanceTravelled += speed * Time.deltaTime;
                    transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);
                    transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled, endOfPathInstruction);
                }
                if (distanceTravelled >= pathCreator.path.length) {
                    if (audiosource != null) {
                        audiosource.Stop();
                        finished = true;
                        Invoke("LoadOnWinPanel", 1f);
                        FlameParticleSystem.SetActive(false);
                        Rigidbody rb= gameObject.AddComponent<Rigidbody>();
                        rb.mass = 1000;
                        rb.angularDrag = 10;
                        rb.drag = 10;
                    }
                } else if (distanceTravelled >= pathCreator.path.length * 0.9f) {
                    if (audiosource != null) {
                        audiosource.pitch = 0.5f;
                    }
                } else if (distanceTravelled >= pathCreator.path.length * 0.8f) {
                    if (audiosource != null) {
                        audiosource.pitch = 0.7f;
                    }
                }

            } else {
                if (audiosource != null) {
                    //audiosource.Stop();
                    audiosource.pitch = 0.5f;
                }

            }
        }

        public void LoadOnWinPanel() {
            OnWinPanel.SetActive(true);
        }


        // If the path changes during the game, update the distance travelled so that the follower's position on the new path
        // is as close as possible to its position on the old path
        void OnPathChanged() {
            distanceTravelled = pathCreator.path.GetClosestDistanceAlongPath(transform.position);
        }
    }
}