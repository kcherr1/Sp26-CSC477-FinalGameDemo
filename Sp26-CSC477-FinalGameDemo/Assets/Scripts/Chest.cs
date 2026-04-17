using UnityEngine;

public class Chest : MonoBehaviour {
  private void Start() {
    GetComponent<Animator>().SetTrigger("Open");
  }

  public void StartParticles() {
    GetComponentInChildren<ParticleSystem>().Play();
  }

  public void SpawnCoins(GameObject coinsPrefab) {
    Instantiate(coinsPrefab, transform.position, Quaternion.identity);
  }

  public void Foo(AnimationEvent ae) {
    print(ae.intParameter);
    print(ae.floatParameter);
    print(ae.stringParameter);
    print(ae.objectReferenceParameter.name);
  }
}
