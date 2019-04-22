using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineExplosion : MonoBehaviour
{

    public float m_ExplosionRadius = 2f;                // The maximum distance away from the explosion tanks can be and are still affected.
    public GameObject ExplosionPrefab;

    private ParticleSystem m_ExplosionParticles;         // Reference to the particles that will play on explosion.
    private AudioSource m_ExplosionAudio;                // Reference to the audio that will play on explosion.


    void Start()
    {

    }
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Tank")
        {
            Debug.Log("Y'a eu trigger avec " + collision.collider.name);
            Collider[] colliders = Physics.OverlapSphere(transform.position, m_ExplosionRadius);

            for (int i = 0; i < colliders.Length; i++)
            {
                Debug.Log("JAI touché " + colliders[i].name);
                Rigidbody targetRigidbody = colliders[i].GetComponent<Rigidbody>();
                Rigidbody parentTry = colliders[i].GetComponentInParent<Rigidbody>();

                // Si le parent de l'element a pas de rigidbody c'est pas un bout du tank, donc on passe au suivant.
                if (!parentTry)
                    continue;
                //Si on trouve pas le tag tank, on a rien a faire donc on continue
                if (parentTry.tag != "Tank")
                    continue;

                PilotController scriptpilote = parentTry.GetComponent<PilotController>();
                if (scriptpilote)
                {
                    if (colliders[i].name.Contains("L_"))
                    {
                        if (Random.Range(0, 5) == 0)
                            scriptpilote.DisableLeft();
                    }
                    if (colliders[i].name.Contains("R_"))
                    {
                        if (Random.Range(0, 5) == 0)
                        {
                            scriptpilote.DisableRight();
                        }
                    }
                }

                TankHealth targethealth = parentTry.GetComponent<TankHealth>();
                if (!targethealth)
                    continue;
                //on met 5 dégats par partie du tank qu'on trouve, ce qui permet de scale les dégats
                targethealth.TakeDamage(5);
            }

            m_ExplosionParticles = Instantiate(ExplosionPrefab).GetComponent<ParticleSystem>();
            m_ExplosionParticles.transform.position = transform.position;
            m_ExplosionAudio = m_ExplosionParticles.GetComponent<AudioSource>();
            m_ExplosionParticles.Play();
            m_ExplosionAudio.Play();

            // Once the particles have finished, destroy the gameobject they are on.
            ParticleSystem.MainModule mainModule = m_ExplosionParticles.main;
            Destroy(m_ExplosionParticles.gameObject, mainModule.duration);
            // Destroy la mine.
            Destroy(gameObject);
        }
        
    }
}