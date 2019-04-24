using UnityEngine;

    public class ShellExplosion : MonoBehaviour
    {
        public float m_MaxLifeTime = 2f;                    // The time in seconds before the shell is removed.
        public float m_ExplosionRadius = 5f;                // The maximum distance away from the explosion tanks can be and are still affected.
        public GameObject ExplosionPrefab;

        private ParticleSystem m_ExplosionParticles;         // Reference to the particles that will play on explosion.
        private AudioSource m_ExplosionAudio;                // Reference to the audio that will play on explosion.

    private void Awake ()
        {
            // If it isn't destroyed by then, destroy the shell after it's lifetime.
            Destroy (gameObject, m_MaxLifeTime);
    }
    

    private void OnTriggerEnter (Collider other)
        {
        //Debug.Log("JAI TRIGGER");
        // Collect all the colliders in a sphere from the shell's current position to a radius of the explosion radius.
        Collider[] colliders = Physics.OverlapSphere (transform.position, m_ExplosionRadius);

            // Go through all the colliders...
            for (int i = 0; i < colliders.Length; i++)
            {
            //Debug.Log("JAI COLLIDE "+colliders[i].name);
            // ... and find their rigidbody.
            Rigidbody targetRigidbody = colliders[i].GetComponent<Rigidbody> ();
            Rigidbody parentTry = colliders[i].GetComponentInParent<Rigidbody>();

            // Si le parent de l'element a pas de rigidbody c'est pas un bout du tank, donc on passe au suivant.
            if (!parentTry)
                continue;

            //Debug.Log("je trouve " + parentTry.name+" from "+colliders[i].name);
            //Si on trouve pas le tag tank, on a rien a faire donc on continue
            if (parentTry.tag != "Tank")
                continue;

            //Debug.Log("le tag tank fonctionne");
            PilotController scriptpilote = parentTry.GetComponent<PilotController>();
            //si y'a pas de script pilote on passe au collider suivant
            if (scriptpilote)
            {
                if (colliders[i].name.Contains("L_"))
                {
                    if (Random.Range(0, 10) == 0)
                        scriptpilote.DisableLeft();
                }
                if (colliders[i].name.Contains("R_"))
                {
                    if (Random.Range(0, 10) == 0)
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
            Destroy (m_ExplosionParticles.gameObject, mainModule.duration);
            // Destroy the shell.
            Destroy (gameObject);
        }
    }