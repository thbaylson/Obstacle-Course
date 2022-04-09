using UnityEngine;
using Unity.MLAgents;

public class ObstacleCourseAgent : Agent
{
    public float moveSpeed = 10;
    private Vector3 orig;
    //private GameObject Target = null;

    public override void Initialize()
    {
        orig = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
    }

    public override void OnActionReceived(float[] vectorAction)
    {
        Globals.ScreenText();

        float xValue = vectorAction[0] * Time.deltaTime * moveSpeed;
        float zValue = vectorAction[1] * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0f, zValue);
    }

    public override void OnEpisodeBegin()
    {
        Globals.Episode++;
        this.transform.position = new Vector3(orig.x, orig.y, orig.z);
    }

    void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Finish") == true){
            Globals.Success++;
            AddReward(1f);
        }
        else if(other.gameObject.CompareTag("Obstacle") == true){
            Globals.Fail++;
            AddReward(-0.1f);
        }
        else if(other.gameObject.CompareTag("Hit") == true){
            Globals.Fail++;
            AddReward(-0.2f);
        }
        
        EndEpisode();
    }
}
