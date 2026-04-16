using UnityEngine;

public class Test : MonoBehaviour {
  public void AeVoid() {
    print("hi");
  }
  public void AeInt(int i) {
    print(i);
  }
  public void AeStr(string s) {
    print(s);
  }
  public void AeFloat(float f) {
    print(f);
  }
  public void AeObj(GameObject go) {
    print(go.name);
  }
  public void AeAe(AnimationEvent ae) {
    print(ae.intParameter);
    print(ae.floatParameter);
    print(ae.stringParameter);
    print(ae.objectReferenceParameter.name);
  }

}
