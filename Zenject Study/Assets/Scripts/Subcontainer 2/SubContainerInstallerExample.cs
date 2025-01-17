using UnityEngine;
using Zenject;

public class SubContainerInstallerExample : MonoInstaller {
    public override void InstallBindings() {
        Container.Bind<SubContainerUserExample>().AsSingle().NonLazy();
    }
}

public class SubContainerUserExample {
    // This call can not be done due to hierarchy of dependencies, subcontainer can see this class but this one can not see subcontainer
    // public SubContainerUserExample(SubContainerHealthExample subContainerHealthExample) {
    //     subContainerHealthExample.Log();
    // }

    public void Log() {
        Debug.Log("User log");
    }
}