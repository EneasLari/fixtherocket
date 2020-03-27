using UnityEngine;

namespace PathCreation.Examples
{
    // Moves along a path at constant speed.
    // Depending on the end of path instruction, will either loop, reverse, or stop at the end of the path.
    public class PathFollower : MonoBehaviour
    {
        public PathCreator pathCreator;
        public EndOfPathInstruction endOfPathInstruction;
        public float speed = 5;
        float distanceTravelled;
        AudioSource audiosource;

        void Start() {
            audiosource = GetComponent<AudioSource>();
            audiosource.Play();
            if (pathCreator != null) {
                // Subscribed to the pathUpdated event so that we're notified if the path changes during the game
                pathCreator.pathUpdated += OnPathChanged;
            }
        }

        void Update() {
            Thrust();
        }
        private bool finished = false;
        private void Thrust() {
            if (!finished && !Input.GetKey(KeyCode.Space)) {
                audiosource.pitch = 1;
                //print("GO UP");
                //if (audiosource!=null && !audiosource.isPlaying) {
                //    audiosource.Play();
                //}
                if (pathCreator != null) {
                    print(distanceTravelled + "--" + pathCreator.path.length);
                    distanceTravelled += speed * Time.deltaTime;
                    transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);
                    transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled, endOfPathInstruction);
                }
                if (distanceTravelled >= pathCreator.path.length) {
                    if (audiosource != null) {
                        audiosource.Stop();
                        finished = true;
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

        // If the path changes during the game, update the distance travelled so that the follower's position on the new path
        // is as close as possible to its position on the old path
        void OnPathChanged() {
            distanceTravelled = pathCreator.path.GetClosestDistanceAlongPath(transform.position);
        }
    }
}