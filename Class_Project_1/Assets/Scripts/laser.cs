using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class laser : MonoBehaviour
{
    private LineRenderer laserRenderer;
    private int laserDistance = 100;
    private int numberReflectMax = 100;
    private int countLaser = 1;
    private Vector3 pos = new Vector3();
    private Vector3 directLaser = new Vector3();
    bool loopActive = true;
    GameObject last = null;
    public Color colour = Color.red;

    void Start(){
        laserRenderer = GetComponent<LineRenderer>();
    }
    void Update(){
        DrawLaser();
    }
    void DrawLaser(){
        loopActive = true;
        int countLaser = 1;
        pos = transform.position;
        directLaser = transform.right;
        laserRenderer.positionCount = countLaser;
        laserRenderer.SetPosition(0,pos);
        while(loopActive){
            RaycastHit2D hit = Physics2D.Raycast(pos, directLaser);
            if(hit){
                countLaser++;
                laserRenderer.positionCount = countLaser;
                directLaser = Vector3.Reflect(directLaser, hit.normal);
                pos = (Vector2) directLaser.normalized + hit.point;
                laserRenderer.SetPosition(countLaser-1, hit.point);
                switch(hit.collider.tag){
                    case "Receptor":
                        last = hit.collider.gameObject;
                        if(colour == last.GetComponent<receptorLogic>().getColour())
                            last.GetComponent<receptorLogic>().setClear(true);
                            loopActive = false;
                        break;
                    case "Mirror":
                        
                        //take away win condition
                        if(last != null)
                        {
                            last.GetComponent<receptorLogic>().setClear(false);
                            last = null;
                        }
                    break;
                    default:
                    if(last != null)
                    {
                        last.GetComponent<receptorLogic>().setClear(false);
                        last = null;
                    }
                    loopActive = false;
                    break;
                }
            }
            else{
                countLaser++;
                laserRenderer.positionCount = countLaser;
                laserRenderer.SetPosition(countLaser - 1, pos + (directLaser.normalized * laserDistance));
                loopActive = false;

                if(last != null)
                {
                    last.GetComponent<receptorLogic>().setClear(false);
                    last = null;
                }
            }
            if(countLaser > numberReflectMax){
                loopActive = false;
            }
        }
    }
    // [SerializeField] private float defDistanceRay = 100;
    // public Transform laserFirePoint;
    
    // Transform m_transform;
    // public Color colour = Color.red;
    // public int reflections;
    // public float maxLength;
    // public LineRenderer m_lineRenderer;
    // private Ray ray;
    // private RaycastHit hit;
    // private Vector2 direction;
    // GameObject last = null;
    // public int speed;
    // private Vector2 start;
    

    // private void Awake()
    // {
    //     start = transform.position;
    //     m_transform = GetComponent<Transform>();
    //     m_lineRenderer = GetComponent<LineRenderer>();
    // }

    // private void Update()
    // {
    //     //transform.position.x = Mathf.PingPong(Time.time, 2.0f) - 1.0f;
    //     ray = new Ray(transform.position, transform.right);

    //     m_lineRenderer.positionCount = 1;
    //     m_lineRenderer.SetPosition(0, transform.position);
    //     float remainingLength = maxLength;

    //     for (int i = 0; i < reflections; i++)
    //     {
    //         RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
    //         if(hit)
    //         {
    //             m_lineRenderer.positionCount += 1;
    //             m_lineRenderer.SetPosition(m_lineRenderer.positionCount - 1, hit.point);
    //             remainingLength -= Vector2.Distance(ray.origin, hit.point);
    //             //if(hit.normal[0] !% 0.7 )
                
    //             //ray = new Ray(hit.point, Vector2.Reflect(ray.direction, hit.normal));
                
    //             switch(hit.collider.tag){
    //                 case "Receptor":
    //                     last = hit.collider.gameObject;
    //                     if(colour == last.GetComponent<receptorLogic>().getColour())
    //                         last.GetComponent<receptorLogic>().setClear(true);
    //                     break;
    //                 case "Mirror":
    //                     // oppositePoints(hit.collider.gameObject.GetComponent<PolygonCollider2D>().points);
    //                     //ray = new Ray(hit.point, Vector2.Reflect(ray.direction, last.GetComponent<movement>().getNormal()));
    //                     //ray.direction = ;
    //                     //new Vector3(0, 1.0f, 0)
    //                     //Debug.Log(hit.point);
    //                     // Debug.Log(hit.normal);
    //                     // Debug.Log(ray.direction);
    //                     // Debug.Log(new Vector2(0.7f, 0.7f));
    //                     // Debug.Log(new Vector3(-1.0f, 0, 0));
    //                     //Debug.Log("hit");
    //                     ray = new Ray(hit.point, Vector2.Reflect(ray.direction, hit.normal));

    //                     //ray = new Ray(hit.point, last.GetComponent<movement>().getNormal());
    //                     //Debug.Log(hit.normal);
    //                     // Debug.Log(last.GetComponent<movement>().getNormal());
    //                     // Debug.Log(ray.direction);

    //                     // take away win condition
    //                     if(last != null)
    //                     {
    //                         last.GetComponent<receptorLogic>().setClear(false);
    //                         last = null;
    //                     }
    //                 break;
    //                 default:
    //                 if(last != null)
    //                 {
    //                     last.GetComponent<receptorLogic>().setClear(false);
    //                     last = null;
    //                 }
    //                 break;
    //             }                  
    //         }
    //         else
    //         {
    //             m_lineRenderer.positionCount += 1;
    //             m_lineRenderer.SetPosition(m_lineRenderer.positionCount - 1, ray.origin + ray.direction * remainingLength);
    //         }
    //     }
    // }

//     public void oppositePoints(Vector2 [] points){
//         for(int i = 0; i < points.Length; i++)
//             for(int j = 0; j < points.Length; j++)
//                 if(points[i] == -1*points[j])
//                     return new Vector2
//     }
}
