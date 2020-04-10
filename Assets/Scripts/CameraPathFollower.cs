using UnityEngine;


namespace PathCreation.PathFollower
{

    // Moves along a path at constant speed.
    // Depending on the end of path instruction, will either loop, reverse, or stop at the end of the path.
    public class CameraPathFollower : MonoBehaviour
    {
        public PathCreator PathToRocketGame;
        public PathCreator PathToSkinSelection;
        public CanvasManager CanvasGameobject;
        private PathCreator pathCreator;
        public EndOfPathInstruction endOfPathInstruction;
        public GameObject Player;
        public float speed = 5;
        float distanceTravelled;
        private Vector3 InitialPosition;
        private Quaternion InitialRotation;

        void Start() {
            pathCreator = PathToRocketGame;
            InitialPosition = gameObject.transform.position;
            InitialRotation = gameObject.transform.rotation;
        }

        void Update() {
            if (RocketPathFollower.rocketState != RocketPathFollower.RocketState.None || pathCreator.Equals(PathToSkinSelection)) {
                Transit();
            }

        }

        public void BackToIntialPosition() {
            gameObject.transform.position = InitialPosition;
            gameObject.transform.rotation = InitialRotation;
        }

        public void ChangeToSkinPath() {
            distanceTravelled = 0;
            pathCreator = PathToSkinSelection;
        }

        public void ChangeToRocketPath() {
            distanceTravelled = 0;
            pathCreator = PathToRocketGame;
        }

        public void BeginCameraTransit() {
            //Player.GetComponent<RocketPathFollower>().enabled=false;
            if (pathCreator != null) {
                // Subscribed to the pathUpdated event so that we're notified if the path changes during the game
                pathCreator.pathUpdated += OnPathChanged;
            }
        }
        private void Transit() {
            if (pathCreator != null) {
                distanceTravelled += speed * Time.deltaTime;
                transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);
                //transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled, endOfPathInstruction);
            }
            if (distanceTravelled >= pathCreator.path.length) {
                gameObject.GetComponent<CameraPathFollower>().enabled = false;
                //Player.GetComponent<RocketPathFollower>().enabled = true;
                if (pathCreator.Equals(PathToRocketGame)) {
                    RocketPathFollower.rocketState = RocketPathFollower.RocketState.StartMoving;
                }

            }
            if (distanceTravelled >= pathCreator.path.length * 0.9f) {
                if (pathCreator.Equals(PathToSkinSelection)) {
                    CanvasGameobject.ActivateSkinSelection();
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